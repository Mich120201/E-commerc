namespace ecommerce.WebAPI.DBQuery.Option.Interfaces
{
    using ecommerce.Models.Option.Models;

    /// <summary>
    /// Interface for ProductOption model
    /// </summary>

    public interface IProductOption
    {
        ///<get>

        ///<summary>
        ///Get product option
        /// </summary>
        /// <param name="id">Product option id</param>
        /// <returns>ProductOption/null</returns>
        Task<ProductOption?> GetProductOptionByIdAsync(Guid id);

        /// </get>

        ///<post>

        ///<summary>
        ///Create new production option
        /// </summary>
        /// <param name="productoption">Option option</param>
        /// <returns>ProductOption</returns>
        Task<bool> CreateProductOptionAsync(ProductOption productoption);

        /// <summary>
        /// Update option id
        /// </summary>
        /// <param name="id">Product option id</param>
        /// <param name="optionpriceincrement">New pption price increment</param>
        /// <returns>ProductOption</returns>
        Task<bool> UpdateProductOptionPriceIncrementAsync(Guid id, double optionpriceincrement);

        /// <summary>
        /// Update all product option
        /// </summary>
        /// <param name="id">Product option id</param>
        /// <param name="productoption">New product option</param>
        /// <returns>bool</returns>
        Task<bool> UpdateProductOptionAsync(Guid id, ProductOption productoption);

        /// </post>

        ///<delete>

        ///<summary>
        ///Delete product option
        /// </summary>
        /// <param name="id">Product option id</param>
        /// <returns>bool</returns>
        Task<bool> DeleteProductOptionAsync(Guid id);

        /// </delete>
    }
}
