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
        Task<Option?> GetOptionByIdAsync(Guid Id);

        /// </get>

        ///<post>

        ///<summary>
        ///Create new option
        /// </summary>
        /// <param name="option">Option</param>
        /// <returns>bool</returns>
        Task<bool> CreateOptionAsync(Option option);

        /// <summary>
        /// Update option name
        /// </summary>
        /// <param name="id">Option id</param>
        /// <param name="optionname">New option name</param>
        /// <returns>bool</returns>
        Task<bool> UpdateOptionNameAsync(Guid id, string optionname);

        /// <summary>
        /// Update all option
        /// </summary>
        /// <param name="id">Option id</param>
        /// <param name="option">New option</param>
        /// <returns>bool</returns>
        Task<bool> UpdateOptionAsync(Guid id, Option option);

        /// </post>

        ///<delete>

        ///<summary>
        /// Delete option
        /// </summary>
        /// <param name="id">Option id</param>
        /// <returns>bool</returns>
        Task<bool> DeleteOptionAsync(Guid id);

        /// </delete>
    }
}
