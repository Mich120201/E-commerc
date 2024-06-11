
namespace ecommerce.WebAPI.DBQuery.Option.Interfaces
{
    using ecommerce.Models.Option.Models;

    public interface IOptiongroup
    {
        ///<get>

        ///<summary>
        ///Get option group by id
        ///</summary
        ///<param name = "id">Option group id</param>
        ///<returns>OptionGroup</returns>
        Task<OptionGroup> GetOptionGroupByIdAsync(Guid id);

        ///</get>
        
        ///<post>
        
        ///<summary>
        ///Create new option group
        /// </summary>
        /// <param name="optionGroup">Option group</param>
        /// <returns>bool</returns>
        Task<bool> CreateOptionGroupAsync(OptionGroup optionGroup);

        /// <summary>
        /// Update option group name
        /// </summary>
        /// <param name="id">Option group id</param>
        /// <param name="groupName">New option group name</param>
        /// <returns>bool</returns>
        Task<bool> UpdateOptionGroupNameAsync(Guid id, string groupName);

        /// <summary>
        /// Update all option group
        /// </summary>
        /// <param name="id">Option group id</param>
        /// <param name="optiongroup">New option group</param>
        /// <returns>bool</returns>
        Task<bool> UpdateOptionGroupAsync(Guid id, OptionGroup optiongroup);

        ///</post>

        ///<delete>

        ///<summary>
        ///Delete option group
        ///</summary>
        ///<param name="id">Option group id</param>
        ///<returns>bool</returns>
        Task<bool> DeleteOptionGroupAsync(Guid id);

        ///</delete>
        
    }
}
