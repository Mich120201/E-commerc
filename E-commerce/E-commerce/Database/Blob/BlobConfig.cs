using Azure.Storage.Blobs;

namespace ecommerce.Database.Blob
{
    public class BlobConfig
    {
        public readonly BlobServiceClient _blobServiceClient;
        public readonly BlobClientOptions? _blobClientOptions;
        public readonly BlobContainerClient _blobContainerClient;

        public BlobConfig(BlobServiceClient blobServiceClient, BlobClientOptions blobClientOptions)
        {
            
            _blobServiceClient = blobServiceClient;
            _blobClientOptions = blobClientOptions;
            _blobContainerClient = _blobServiceClient.GetBlobContainerClient("thumbs");
            _blobContainerClient.CreateIfNotExists();
        }
    }
}
