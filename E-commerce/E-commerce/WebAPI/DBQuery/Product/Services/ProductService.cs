using ecommerce.WebAPI.DBQuery.Option.Interfaces;

namespace ecommerce.WebAPI.DBQuery.Product.Services
{
    using ecommerce.DBContext;
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

        public async Task<Product?> GetProductByIdAsync(int id)
        {

            Product? product = await _appDbContext.Products.FindAsync(id) ?? null;
            return product;

        }

        public async Task<bool> CreateProductAsync(
            string productname,
            string productdescription,
            float producttotalprice,
            float productweight,
            float productsizex,
            float productsizey,
            float productsizez,
            uint productstock
            )
        {
            try
            {
                Product product = new();
                product.ProductName = productname;
                product.PrductDescription = productdescription;
                product.ProductTotalPrice = producttotalprice;
                product.ProductWeight = productweight;
                product.ProductSizeX = productsizex;
                product.ProductSizeY = productsizey;
                product.ProductSizeZ = productsizez;
                product.ProductStock = productstock;

                _appDbContext.Products.Add(product);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errorHandler.NewException(ex);
            }
            return false;
        }

        public async Task<bool> UpdateProductNameAsync(int id, string productname)
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

        public async Task<bool> UpdateProductDescriptionAsync(int id, string productdescription)
        {
            Product? product = await GetProductByIdAsync(id);

            if (product != null)
            {
                product.PrductDescription = productdescription;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProductTotalPriceAsync(int id, float producttotalprice)
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

        public async Task<bool> UpdateProductWeightAsync(int id, float productweight)
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

        public async Task<bool> UpdateProductSizeXAsync(int id, float productsizex)
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

        public async Task<bool> UpdateProductSizeYAsync(int id, float productsizey)
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

        public async Task<bool> UpdateProductSizeZAsync(int id, float productsizez)
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

        public async Task<bool> UpdateProductStockAsync(int id, uint productstock)
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

        public async Task<bool> DeleteProductAsync(int id)
        {
            Product? product = await GetProductByIdAsync(id);

            if (product != null)
            {
                _appDbContext.Remove(product);
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
