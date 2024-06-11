using ecommerce.WebAPI.DBQuery.Option.Interfaces;

namespace ecommerce.WebAPI.DBQuery.Product.Services
{
    using ecommerce.DBContext;
    using ecommerce.Models.Order.Models;
    using ecommerce.Models.Product.Models;

    /// <summary>
    /// DB query service for product
    /// </summary>
    public class ProductService : IProduct
    {
        private readonly ErrorHandler _errorHandler;
        private readonly AppDbContext _appDbContext;

        public ProductService(AppDbContext context)
        {
            ILoggerFactory loggerFactory = new LoggerFactory();
            ILogger<ProductService> _logger = loggerFactory.CreateLogger<ProductService>();
            _errorHandler = new ErrorHandler(_logger);
            _appDbContext = context;
        }

        ~ProductService()
        {
            _errorHandler.RiseExceptions();
        }

        public async Task<Product?> GetProductByIdAsync(Guid id)
        {

            Product? product = await _appDbContext.Products.FindAsync(id) ?? null;
            return product;

        }

        public async Task<bool> CreateProductAsync(Product product)
        {
            try
            {
                await _appDbContext.Products.AddAsync(product);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errorHandler.NewException(ex);
            }
            return false;
        }

        public async Task<bool> UpdateProductNameAsync(Guid id, string productname)
        {
            Product? product = await GetProductByIdAsync(id);

            if (product != null)
            {
                product.ProductName = productname;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProductDescriptionAsync(Guid id, string productdescription)
        {
            Product? product = await GetProductByIdAsync(id);

            if (product != null)
            {
                product.ProductDescription = productdescription;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProductTotalPriceAsync(Guid id, float producttotalprice)
        {
            Product? product = await GetProductByIdAsync(id);

            if (product != null)
            {
                product.ProductTotalPrice = producttotalprice;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProductWeightAsync(Guid id, float productweight)
        {
            Product? product = await GetProductByIdAsync(id);

            if (product != null)
            {
                product.ProductWeight = productweight;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProductSizeXAsync(Guid id, float productsizex)
        {
            Product? product = await GetProductByIdAsync(id);

            if (product != null)
            {
                product.ProductSizeX = productsizex;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProductSizeYAsync(Guid id, float productsizey)
        {
            Product? product = await GetProductByIdAsync(id);

            if (product != null)
            {
                product.ProductSizeY = productsizey;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProductSizeZAsync(Guid id, float productsizez)
        {
            Product? product = await GetProductByIdAsync(id);

            if (product != null)
            {
                product.ProductSizeZ = productsizez;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProductStockAsync(Guid id, uint productstock)
        {
            Product? product = await GetProductByIdAsync(id);

            if (product != null)
            {
                product.ProductStock = productstock;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProductAsync(Guid id, Product _product)
        {
            Product? product = await GetProductByIdAsync(id);

            if (product != null)
            {
                product.ProductStock = _product.ProductStock;
                product.ProductName = _product.ProductName;
                product.ProductTotalPrice = _product.ProductTotalPrice;
                product.ProductDescription = _product.ProductDescription;
                product.ProductSizeX = _product.ProductSizeX;
                product.ProductSizeY = _product.ProductSizeY;
                product.ProductSizeZ = _product.ProductSizeZ;
                product.ProductWeight = _product.ProductWeight;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteProductAsync(Guid id)
        {
            Product? product = await GetProductByIdAsync(id);

            if (product != null)
            {
                _appDbContext.Products.Remove(product);
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
