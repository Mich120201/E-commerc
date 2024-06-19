using ecommerce.Database.DBContext;
using ecommerce.Models.Option.Models;
using ecommerce.Models.Product.Models;
using ecommerce.WebAPI.DBQuery.Option.Interfaces;
using ecommerce.WebAPI.DBQuery.Product.Services;

namespace ecommerce.WebAPI.DBQuery.Option.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductOptionService : IProductOption
    {

        private readonly ErrorHandler _errorHandler;
        private readonly AppDbContext _appDbContext;

        public ProductOptionService(AppDbContext context)
        {
            ILoggerFactory loggerFactory = new LoggerFactory();
            ILogger<ProductOptionService> _logger = loggerFactory.CreateLogger<ProductOptionService>();
            _errorHandler = new ErrorHandler(_logger);
            _appDbContext = context;
        }

        ~ProductOptionService()
        {
            _errorHandler.RiseExceptions();
        }

        public async Task<ProductOption?> GetProductOptionByIdAsync(Guid id)
        {
            ProductOption? productOption = await _appDbContext.ProductOptions.FindAsync(id);
            return productOption;
        }

        public async Task<bool> CreateProductOptionAsync(ProductOption productoption)
        {
            try
            {
                await _appDbContext.ProductOptions.AddAsync(productoption);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errorHandler.NewException(ex);
            }
            return false;
        }

        public async Task<bool> UpdateProductOptionPriceIncrementAsync(Guid id, double optionpriceincrement)
        {
            ProductOption? productOption = await GetProductOptionByIdAsync(id);

            if (productOption != null)
            {
                productOption.OptionPriceIncrement = optionpriceincrement;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProductOptionAsync(Guid id, ProductOption _productoption)
        {
            ProductOption? productOption = await GetProductOptionByIdAsync(id);

            if (productOption != null)
            {
                productOption.OptionPriceIncrement = _productoption.OptionPriceIncrement;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteProductOptionAsync(Guid id)
        {
            ProductOption? productOption = await GetProductOptionByIdAsync(id);

            if (productOption != null)
            {
                _appDbContext.ProductOptions.Remove(productOption);
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
