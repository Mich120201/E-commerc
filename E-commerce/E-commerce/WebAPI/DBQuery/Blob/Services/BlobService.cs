using Azure;
using Azure.Storage.Blobs;
using ecommerce.Database.Blob;
using ecommerce.WebAPI.DBQuery.Blob.Interfaces;
using ecommerce.WebAPI.DBQuery.Option.Services;

namespace ecommerce.WebAPI.DBQuery.Blob.Services
{
    public class BlobService : IBlob
    {
        private readonly BlobServiceClient blobServiceClient;
        private readonly BlobContainerClient blobContainerClient;
        private readonly ErrorHandler _errorHandler;

        public BlobService(BlobConfig blobConfig)
        {
            blobServiceClient = blobConfig._blobServiceClient;
            blobContainerClient = blobConfig._blobContainerClient;
            ILoggerFactory loggerFactory = new LoggerFactory();
            ILogger<OptionGroupService> _logger = loggerFactory.CreateLogger<OptionGroupService>();
            _errorHandler = new ErrorHandler(_logger);
        }

        ~BlobService()
        {
            _errorHandler.RiseExceptions();
        }

        public async Task<bool> UploadAsync(string localfilepath)
        {
            try
            {
                string fileName = Path.GetFileName(localfilepath);
                BlobClient blobClient = blobContainerClient.GetBlobClient(fileName);

                if (blobClient.Exists())
                {
                    uint counter = 0;
                    BlobClient newBlobClient;

                    string newFileName = Path.GetFileNameWithoutExtension(fileName);
                    char p = newFileName[newFileName.Length - 1];

                    if (p == ')')
                    {
                        int index = newFileName.Length;
                        char q;
                        do
                        {
                            index--;
                            q = newFileName[index];

                        } while (q != '(' | index >= 0);

                        if (q == ')')
                        {
                            newFileName = newFileName.Remove(index, newFileName.Length - 1);
                        }
                    }

                    do
                    {
                        counter++;
                        newBlobClient = blobContainerClient.GetBlobClient(newFileName + "(" + counter + ")" + Path.GetExtension(fileName));
                    }
                    while (newBlobClient.Exists());

                    blobClient = newBlobClient;

                }

                FileStream fileStream = File.OpenRead(localfilepath);
                await blobClient.UploadAsync(fileStream, true);
                fileStream.Close();
                return true;
            }
            catch (Exception ex)
            {
                _errorHandler.NewException(ex);
            }
            return false;
        }

        public async Task<bool> DeleteAsync(string filename)
        {
            Response<bool> response = await blobContainerClient.DeleteBlobIfExistsAsync(filename);
            if (response.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
