using ecommerce.Database.DBContext;
using ecommerce.Models.Option.Models;
using ecommerce.Models.Product.Models;
using ecommerce.WebAPI.DBQuery.Option.Interfaces;
using ecommerce.WebAPI.DBQuery.Product.Services;

namespace ecommerce.WebAPI.DBQuery.Option.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class OptionGroupService : IOptiongroup
    {
        private readonly ErrorHandler _errorHandler;
        private readonly AppDbContext _appDbContext;

        public OptionGroupService(AppDbContext context)
        {
            ILoggerFactory loggerFactory = new LoggerFactory();
            ILogger<OptionGroupService> _logger = loggerFactory.CreateLogger<OptionGroupService>();
            _errorHandler = new ErrorHandler(_logger);
            _appDbContext = context;
        }
        ~OptionGroupService()
        {
            _errorHandler.RiseExceptions();
        }

        public async Task<OptionGroup> GetOptionGroupByIdAsync(Guid id)
        {
            OptionGroup? optionGroup = await _appDbContext.OptionsGroups.FindAsync(id);
            return optionGroup;
        }

        public async Task<bool> CreateOptionGroupAsync(OptionGroup optionGroup)
        {
            try
            {
                await _appDbContext.OptionsGroups.AddAsync(optionGroup);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errorHandler.NewException(ex);
            }
            return false;
        }

        public async Task<bool> UpdateOptionGroupNameAsync(Guid id, string groupName)
        {
            OptionGroup? optionGroup = await GetOptionGroupByIdAsync(id);

            if (optionGroup != null)
            {
                optionGroup.OptionGroupName = groupName;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOptionGroupAsync(Guid id, OptionGroup _optiongroup)
        {
            OptionGroup? optionGroup = await GetOptionGroupByIdAsync(id);

            if (optionGroup != null)
            {
                optionGroup.OptionGroupName = _optiongroup.OptionGroupName;
                optionGroup.Options = _optiongroup.Options;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteOptionGroupAsync(Guid id)
        {
            OptionGroup? optionGroup = await GetOptionGroupByIdAsync(id);

            if (optionGroup != null)
            {
                _appDbContext.OptionsGroups.Remove(optionGroup);
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
