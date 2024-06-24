namespace ecommerce.WebAPI.DBQuery.Option.Services
{
    using ecommerce.Database.DBContext;
    using ecommerce.Models.Option.Models;
    using ecommerce.WebAPI.DBQuery.Option.Interfaces;

    /// <summary>
    /// 
    /// </summary>
    public class OptionService : IOption
    {

        private readonly ErrorHandler _errorHandler;
        private readonly AppDbContext _appDbContext;

        public OptionService(AppDbContext context)
        {
            ILoggerFactory loggerFactory = new LoggerFactory();
            ILogger<OptionService> _logger = loggerFactory.CreateLogger<OptionService>();
            _errorHandler = new ErrorHandler(_logger);
            _appDbContext = context;
        }

        ~OptionService()
        {
            _errorHandler.RiseExceptions();
        }

        public async Task<Option?> GetOptionByIdAsync(Guid Id)
        {
            Option? option = await _appDbContext.Options.FindAsync(Id);
            return option;
        }

        public async Task<bool> CreateOptionAsync(Option option)
        {
            try
            {
                await _appDbContext.Options.AddAsync(option);
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errorHandler.NewException(ex);
            }
            return false;
        }

        public async Task<bool> UpdateOptionNameAsync(Guid id, string optionname)
        {
            Option? option = await GetOptionByIdAsync(id);

            if (option != null)
            {
                option.OptionName = optionname;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOptionAsync(Guid id, Option _option)
        {
            Option? option = await GetOptionByIdAsync(id);

            if (option != null)
            {
                option.OptionName = _option.OptionName;
                _appDbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteOptionAsync(Guid id)
        {
            Option? option = await GetOptionByIdAsync(id);

            if (option != null)
            {
                _appDbContext.Options.Remove(option);
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
