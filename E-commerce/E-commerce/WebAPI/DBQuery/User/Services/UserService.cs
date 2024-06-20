using ecommerce.Database.DBContext;
using ecommerce.WebAPI.DBQuery.User.Interfaces;

namespace ecommerce.WebAPI.DBQuery.User.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class UserService : IUser
    {

        private readonly ErrorHandler _errorHandler;
        private readonly AppDbContext _appDbContext;

        public UserService(AppDbContext context)
        {
            ILoggerFactory loggerFactory = new LoggerFactory();
            ILogger<UserService> _logger = loggerFactory.CreateLogger<UserService>();
            _errorHandler = new ErrorHandler(_logger);
            _appDbContext = context;
        }

        ~UserService()
        {
            _errorHandler.RiseExceptions();
        }

        Task<bool> IUser.CreateUserAsync(Models.User.Models.User user)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUser.DeleteUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User?> IUser.GetUserByEmailAsync(string Email)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User?> IUser.GetUserByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdateAddress1Async(Models.User.Models.User user, string? address1)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdateAddress2Async(Models.User.Models.User user, string? address2)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdateCityAsync(Models.User.Models.User user, string? city)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdateCountryAsync(Models.User.Models.User user, string? country)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdateEmailAsync(Models.User.Models.User user, string email)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdateEmailVerifiedAsync(Models.User.Models.User user, byte emailverified)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdateFaxAsync(Models.User.Models.User user, string? fax)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdateFirstNameAsync(Models.User.Models.User user, string? firstname)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdateIpAsync(Models.User.Models.User user, string? ip)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdateLastNameAsync(Models.User.Models.User user, string? lastname)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdatePasswordAsync(Models.User.Models.User user, string password)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdatePhoneAsync(Models.User.Models.User user, string? phone)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdateStateAsync(Models.User.Models.User user, string? state)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdateVerificationCodeAsync(Models.User.Models.User user, string verificationcode)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUser.UpdateUserAsync(Guid id, Models.User.Models.User user)
        {
            throw new NotImplementedException();
        }

        Task<Models.User.Models.User> IUser.UpdateZipAsync(Models.User.Models.User user, string? zip)
        {
            throw new NotImplementedException();
        }
    }
}
