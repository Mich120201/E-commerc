namespace ecommerce.WebAPI.DBQuery.Product.Interfaces
{
    using Models.Product.Models;

    /// <summary>
    /// Interface fot ThumbImage model
    /// </summary>
    public interface IThumbImage
    {
        ///<get>

        ///<summary>
        ///Get thumb image by id
        /// </summary>
        /// <param name="id">ThumbImage id</param>
        /// <returns>ThumbImage</returns>
        Task<ThumbImage> GetThumbImageById(int id);

        ///<summary>
        ///Get product id
        /// </summary>
        /// <param name="ThumbImage">ThumbImage</param>
        /// <returns>int</returns>
        Task<int> GetProductId(ThumbImage ThumbImage);

        /// <summary>
        /// Get thumb image link
        /// </summary>
        /// <param name="ThumbImage">ThumbImage</param>
        /// <returns>string</returns>
        Task<string> GetThumbImageLink(ThumbImage ThumbImage);

        /// </get>

        ///<Post>

        ///<summary>
        ///Create new thumb image
        /// </summary>
        /// <param name="productid">Product id</param>
        /// <param name="ThumbImagelink">Thumb image link</param>
        /// <returns>ThumbImage</returns>
        Task<bool> CreateThumbImage(
            int productid,
            string ThumbImagelink
            );

        /// <summary>
        /// Update product Id
        /// </summary>
        /// <param name="ThumbImage">ThumbImage</param>
        /// <param name="productid">New product id</param>
        /// <returns>ThumbImage</returns>
        Task<bool> UpdateProductId(ThumbImage ThumbImage, int productid);

        /// <summary>
        /// Update thumb image link
        /// </summary>
        /// <param name="ThumbImage">ThumbImage</param>
        /// <param name="ThumbImagelink">New thumb image link</param>
        /// <returns>ThumbImage</returns>
        Task<bool> UpdateThumbImageLink(ThumbImage ThumbImage, string ThumbImagelink);

        /// </Post>

        ///<Delete>

        ///<summary>
        ///Delete thumb image by id
        /// </summary>
        /// <param name="id">Thumb image id</param>
        /// <returns>bool</returns>
        Task<bool> DeleteThumbImageById(int id);

        /// </Delete>
    }
}
