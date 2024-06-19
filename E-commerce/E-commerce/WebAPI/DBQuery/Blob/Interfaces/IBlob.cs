using System.Drawing;

namespace ecommerce.WebAPI.DBQuery.Blob.Interfaces
{
    public interface IBlob
    {
        public Task<bool> UploadAsync(string localfilepath);
        public Task<bool> DeleteAsync(string filename);
    }
}
