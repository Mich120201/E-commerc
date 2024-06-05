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
        /// <returns>ProductOption</returns>
        Task<ProductOption> GetProductOption(int id);

        /// <summary>
        /// Get product option id
        /// </summary>
        /// <param name="ProductOption">Product option</param>
        /// <returns>int</returns>

        Task<int> GetOptionId(ProductOption ProductOption);

        /// <summary>
        /// Get product option product id
        /// </summary>
        /// <param name="ProductOption">Product option</param>
        /// <returns>int</returns>

        Task<int> GetProductId(ProductOption ProductOption);

        /// <summary>
        /// Get product option group id
        /// </summary>
        /// <param name="ProductOption">Product option</param>
        /// <returns>uint</returns>
        Task<uint> GetOptionGroupId(ProductOption ProductOption);

        /// <summary>
        /// Get product option price increment
        /// </summary>
        /// <param name="ProductOption">Product option</param>
        /// <returns>double</returns>
        Task<double> GetOptionPriceIncrement(ProductOption ProductOption);

        /// </get>

        ///<set>

        ///<summary>
        ///Create new production option
        /// </summary>
        /// <param name="optionid">Option id</param>
        /// <param name="productid">Product id</param>
        /// <param name="optiongroupid">Option group id</param>
        /// <param name="optionpriceincrement">Option price increment</param>
        /// <returns>ProductOption</returns>
        Task<ProductOption> CreateProductOption(
            int optionid,
            int productid,
            uint optiongroupid,
            double optionpriceincrement
            );

        /// <summary>
        /// Update option id
        /// </summary>
        /// <param name="ProductOption">Product option</param>
        /// <param name="optionid">Option id</param>
        /// <returns>ProductOption</returns>
        Task<ProductOption> UpdateOptionId(ProductOption ProductOption, int optionid);

        /// <summary>
        /// Update product option
        /// </summary>
        /// <param name="ProductOption">Product option</param>
        /// <param name="productid">Product id</param>
        /// <returns>ProductOption</returns>
        Task<ProductOption> UpdateProductId(ProductOption ProductOption, int productid);

        /// <summary>
        /// Update option group id
        /// </summary>
        /// <param name="ProductOption">Product option</param>
        /// <param name="productid">Product id</param>
        /// <returns>ProductOption</returns>
        Task<ProductOption> UpdateOptionGroupId(ProductOption ProductOption, uint productid);

        /// <summary>
        /// Update option price increment
        /// </summary>
        /// <param name="ProductOption">Product option</param>
        /// <param name="optionpriceincrement">Option price increment</param>
        /// <returns>ProductOption</returns>
        Task<ProductOption> UpdateOptionPriceIncrement(ProductOption ProductOption, double optionpriceincrement);

        /// </set>
    }
}
