using ecommerce.Database.DBContext;
using ecommerce.Models.Product.Models;
using ecommerce.WebAPI.DBQuery.Product.Interfaces;

namespace ecommerce.WebAPI.DBQuery.Product.Services
{
    /// <summary>
    /// DB query service for thumb image
    /// </summary>
    public class ThumbImageService : IThumbImage
    {
        private readonly ErrorHandler _errorHandler;
        private readonly AppDbContext _appDbContext;

        public ThumbImageService(AppDbContext context)
        {
            ILoggerFactory loggerFactory = new LoggerFactory();
            ILogger<ThumbImageService> _logger = loggerFactory.CreateLogger<ThumbImageService>();
            _errorHandler = new ErrorHandler(_logger);
            _appDbContext = context;
        }

        ~ThumbImageService()
        {
            _errorHandler.RiseExceptions();
        }

        public async Task<ThumbImage?> GetThumbImageByIdAsync(Guid id)
        {
            ThumbImage? thumbImage = await _appDbContext.Thumbs.FindAsync(id);
            return thumbImage;
        }

        public async Task<bool> CreateThumbImageAsync(ThumbImage thumbImage)
        {
            try
            {
                await _appDbContext.Thumbs.AddAsync(thumbImage);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errorHandler.NewException(ex);
            }
            return false;
        }

        public async Task<bool> UpdateThumbImageLinkAsync(Guid id, string thumbimagelink)
        {
            ThumbImage? thumbImage = await GetThumbImageByIdAsync(id);

            if (thumbImage != null)
            {
                thumbImage.ThumbImageLink = thumbimagelink;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateThumbImageAsync(Guid id, ThumbImage _thumbimage)
        {
            ThumbImage? thumbimage = await GetThumbImageByIdAsync(id);

            if (thumbimage != null)
            {
                thumbimage.ThumbImageLink = _thumbimage.ThumbImageLink;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteThumbImageAsync(Guid id)
        {
            ThumbImage? thumbImage = await GetThumbImageByIdAsync(id);

            if (thumbImage != null)
            {
                _appDbContext.Thumbs.Remove(thumbImage);
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
