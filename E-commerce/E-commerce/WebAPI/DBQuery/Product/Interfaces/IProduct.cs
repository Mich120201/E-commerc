namespace ecommerce.WebAPI.DBQuery.Option.Interfaces
{
    using Models.Product.Models;

    /// <summary>
    /// Interface for product model
    /// </summary>
    public interface IProduct
    {
        ///<Get>

        ///<summary>
        ///Get product by id
        /// </summary>
        /// <param name="id">Product id</param>
        /// <returns>Product/null</returns>
        Task<Product?> GetProductByIdAsync(int id);

        /*
        ///<summary>
        ///Get product name
        /// </summary>
        /// <param name="product">Product</param>
        /// <returns>string</returns>
        Task<string> GetProductName(Product product);

        /// <summary>
        /// Get product description
        /// </summary>
        /// <param name="product">Product</param>
        /// <returns>string/null</returns>
        Task<string?> GetProductDescription(Product product);

        /// <summary>
        /// Get product total price
        /// </summary>
        /// <param name="product">Product</param>
        /// <returns>float</returns>
        Task<float> GetProductTotalPrice(Product product);

        /// <summary>
        /// Get product weight
        /// </summary>
        /// <param name="product">Product</param>
        /// <returns>float</returns>
        Task<float> GetProductWeight(Product product);

        /// <summary>
        /// Get product size X
        /// </summary>
        /// <param name="product">Product</param>
        /// <returns>float</returns>
        Task<float> GetProductSizeX(Product product);

        /// <summary>
        /// Get product size Y
        /// </summary>
        /// <param name="product">Product</param>
        /// <returns>float</returns>
        Task<float> GetProductSizeY(Product product);

        /// <summary>
        /// Get product size Z
        /// </summary>
        /// <param name="product">Product</param>
        /// <returns>float</returns>
        Task<float> GetProductSizeZ(Product product);

        /// <summary>
        /// Get product stock
        /// </summary>
        /// <param name="product">Product</param>
        /// <returns>uint</returns>
        Task<Product> GetProductStock(Product product);
        */
        /// </Get>

        ///<Post>

        ///<summary>
        ///Create new product
        /// </summary>
        /// <param name="productname">Product name</param>
        /// <param name="productdescription">Product description</param>
        /// <param name="producttotalprice">Product total price</param>
        /// <param name="productweight">Product weight</param>
        /// <param name="productsizex">Product size X</param>
        /// <param name="productsizey">Product size Y</param>
        /// <param name="productsizez">Product size Z</param>
        /// <param name="productstock">Product stock</param>
        /// <returns>bool</returns>
        Task<bool> CreateProductAsync(
            string productname,
            string productdescription,
            float producttotalprice,
            float productweight,
            float productsizex,
            float productsizey,
            float productsizez,
            uint productstock
            );

        /// <summary>
        /// Update product name
        /// </summary>
        /// <param name="id">Product id</param>
        /// <param name="productname">New product Name</param>
        /// <returns>bool</returns>
        Task<bool> UpdateProductNameAsync(int id, string productname);

        /// <summary>
        /// Update product description
        /// </summary>
        /// <param name="id">Product id</param>
        /// <param name="productdescription">New product description</param>
        /// <returns>bool</returns>
        Task<bool> UpdateProductDescriptionAsync(int id, string productdescription);

        /// <summary>
        /// Update product total price
        /// </summary>
        /// <param name="id">Product id</param>
        /// <param name="producttotalprice">New product total price</param>
        /// <returns>bool</returns>
        Task<bool> UpdateProductTotalPriceAsync(int id, float producttotalprice);

        /// <summary>
        /// Update product weight
        /// </summary>
        /// <param name="id">Product id</param>
        /// <param name="productweight">New product weight</param>
        /// <returns>bool</returns>
        Task<bool> UpdateProductWeightAsync(int id, float productweight);

        /// <summary>
        /// Update roduct size X
        /// </summary>
        /// <param name="id">Product id</param>
        /// <param name="productsizex">New product size X</param>
        /// <returns>bool</returns>
        Task<bool> UpdateProductSizeXAsync(int id, float productsizex);

        /// <summary>
        /// Update product size Y
        /// </summary>
        /// <param name="id">Product id</param>
        /// <param name="productsizey">New product size Y</param>
        /// <returns>bool</returns>
        Task<bool> UpdateProductSizeYAsync(int id, float productsizey);

        /// <summary>
        /// Update product size Z
        /// </summary>
        /// <param name="id">Product id</param>
        /// <param name="productsizez">New product size Z</param>
        /// <returns>bool</returns>
        Task<bool> UpdateProductSizeZAsync(int id, float productsizez);

        /// <summary>
        /// Update product stock
        /// </summary>
        /// <param name="id">Product id</param>
        /// <param name="productstock">New product stock</param>
        /// <returns>bool</returns>
        Task<bool> UpdateProductStockAsync(int id, uint productstock);

        /// </Post>

        ///<Delete>

        ///<summary>
        ///Delete product
        /// </summary>
        /// <param name="id">Product id</param>
        /// <returns>bool</returns>
        Task<bool> DeleteProductAsync(int id);

        /// </Delete>
    }
}
