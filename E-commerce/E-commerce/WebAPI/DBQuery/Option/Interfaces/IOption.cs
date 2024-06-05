namespace ecommerce.WebAPI.DBQuery.Option.Interfaces
{
    using Models.Option.Models;

    /// <summary>
    /// Interface for Option model
    /// </summary>
    public interface IOption
    {
        ///<get>

        ///<summary>
        ///Get option by id
        /// </summary>
        /// <param name="Id">Option id</param>
        /// <returns>Option/null</returns>
        Task<Option?> GetOptionId(int Id);

        /// <summary>
        /// Get option name
        /// </summary>
        /// <param name="option">Option</param>
        /// <returns>Option</returns>
        Task<string> GetOptionName(Option option);

        /// </get>

        ///<set>

        ///<summary>
        ///Create new option
        /// </summary>
        /// <param name="optionname">Option name</param>
        /// <returns>Option/null</returns>
        Task<Option?> CreateOption(string optionname);

        /// <summary>
        /// Update option name
        /// </summary>
        /// <param name="option"></param>
        /// <param name="optionname">New option name</param>
        /// <returns>Option</returns>
        Task<Option> UpdateOptionName(Option option, string optionname);

        /// </set>
    }
}
