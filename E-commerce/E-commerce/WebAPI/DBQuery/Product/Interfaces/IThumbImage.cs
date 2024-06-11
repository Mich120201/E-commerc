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
        /// <returns>ThumbImage/null</returns>
        Task<ThumbImage?> GetThumbImageByIdAsync(Guid id);

        /*
        ///<summary>
        ///Get product id
        /// </summary>
        /// <param name="ThumbImage">ThumbImage</param>
        /// <returns>int</returns>
        Task<int> GetProductIdAsync(ThumbImage ThumbImage);
        

        /// <summary>
        /// Get thumb image link
        /// </summary>
        /// <param name="ThumbImage">ThumbImage</param>
        /// <returns>string</returns>
        Task<string> GetThumbImageLinkAsync(ThumbImage ThumbImage);
        */
        /// </get>

        ///<Post>

        ///<summary>
        ///Create new thumb image
        /// </summary>
        /// <param name="thumbimage">Thumb image</param>
        /// <returns>ThumbImage</returns>
        Task<bool> CreateThumbImageAsync(ThumbImage thumbimage);

        /// <summary>
        /// Update thumb image link
        /// </summary>
        /// <param name="id">Thumb image id</param>
        /// <param name="ThumbImagelink">New thumb image link</param>
        /// <returns>ThumbImage</returns>
        Task<bool> UpdateThumbImageLinkAsync(Guid id, string thumbimagelink);

        /// <summary>
        /// Update all thumb image
        /// </summary>
        /// <param name="id">Thumb image id</param>
        /// <param name="thumbImage">New thumb image</param>
        /// <returns>bool</returns>
        Task<bool> UpdateThumbImageAsync(Guid id, ThumbImage thumbImage);

        /// </Post>

        ///<Delete>

        ///<summary>
        ///Delete thumb image by id
        /// </summary>
        /// <param name="id">Thumb image id</param>
        /// <returns>bool</returns>
        Task<bool> DeleteThumbImageAsync(Guid id);

        /// </Delete>
    }
}
