namespace ecommerce.WebAPI.DBQuery.User.Interfaces
{
    using Models.User.Models;
    using NuGet.Packaging.Signing;

    /// <summary>
    /// Interface for user model
    /// </summary>
    public interface IUser
    {
        ///<get>

        ///<summary>
        ///Get user by id
        /// </summary>
        /// <param name="id">User id</param>
        /// <returns>User/null</returns>
        Task<User?> GetUserByIdAsync(Guid id);

        /// <summary>
        /// Get user by email
        /// </summary>
        /// <param name="Email">User email</param>
        /// <returns>User/null</returns>
        Task<User?> GetUserByEmailAsync(string Email);
        /*
        /// <summary>
        /// Get user id
        /// </summary>
        /// <param name="user"></param>
        /// <returns>int</returns>
        Task<int> GetId(User user);

        /// <summary>
        /// Get user email
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string</returns>
        Task<string> GetEmail(User user);

        /// <summary>
        /// Get user password hash
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string</returns>
        Task<string> GetPassword(User user);

        /// <summary>
        /// Get user first name
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string/null</returns>
        Task<string?> GetFirstName(User user);

        /// <summary>
        /// Get user last name
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string/null</returns>
        Task<string?> GetLastName(User user);

        /// <summary>
        /// Get user city
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string/null</returns>
        Task<string?> GetCity(User user);

        /// <summary>
        /// Get user geopolitical state
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string/null</returns>
        Task<string?> GetState(User user);

        /// <summary>
        /// Get user zip
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string/null</returns>
        Task<string?> GetZip(User user);

        /// <summary>
        /// Get email verification
        /// </summary>
        /// <param name="user"></param>
        /// <returns>bool</returns>
        Task<bool> EmailVerification(User user);

        /// <summary>
        /// Get user registration date
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Timestamp</returns>
        Task<Timestamp> GetRegistrationDate(User user);

        /// <summary>
        /// Get verification code
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string</returns>
        Task<string> VerificationCode(User user);

        /// <summary>
        /// Get user IP
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string/null</returns>
        Task<string?> GetIP(User user);

        /// <summary>
        /// Get user Phone number
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string/null</returns>
        Task<string?> GetPhone(User user);

        /// <summary>
        /// Get user fax
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string/null</returns>
        Task<string?> GetFax(User user);

        /// <summary>
        /// Get user country
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string/null</returns>
        Task<string?> GetCountry(User user);

        /// <summary>
        /// Get user first address
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string/null</returns>
        Task<string?> GetAddress1(User user);

        /// <summary>
        /// Get user second address
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string/null</returns>
        Task<string?> GetAddress2(User user);
        */

        ///</get>

        ///<post>

        ///<summary>
        ///Create new user
        /// </summary>
        /// <param name="user">User</param>
        /// <returns>bool</returns>
        Task<bool> CreateUserAsync(User user);

        /// <summary>
        /// Update user email
        /// </summary>
        /// <param name="user"></param>
        /// <param name="email">User new email</param>
        /// <returns>user</returns>
        Task<User> UpdateEmailAsync(User user, string email);

        /// <summary>
        /// Update user password
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password">User new password</param>
        /// <returns>User</returns>
        Task<User> UpdatePasswordAsync(User user, string password);

        /// <summary>
        /// Update user first name
        /// </summary>
        /// <param name="user"></param>
        /// <param name="firstname">User new first name</param>
        /// <returns>User</returns>
        Task<User> UpdateFirstNameAsync(User user, string? firstname);

        /// <summary>
        /// Update user last name
        /// </summary>
        /// <param name="user"></param>
        /// <param name="lastname">User new last name</param>
        /// <returns>User</returns>
        Task<User> UpdateLastNameAsync(User user, string? lastname);

        /// <summary>
        /// Update user city
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="city">User new city</param>
        /// <returns>User</returns>
        Task<User> UpdateCityAsync(User user, string? city);

        /// <summary>
        /// Update user state
        /// </summary>
        /// <param name="user"></param>
        /// <param name="state">User new state</param>
        /// <returns>User</returns>
        Task<User> UpdateStateAsync(User user, string? state);

        /// <summary>
        /// Update user zip
        /// </summary>
        /// <param name="user"></param>
        /// <param name="zip">New user zip</param>
        /// <returns>User</returns>
        Task<User> UpdateZipAsync(User user, string? zip);

        /// <summary>
        /// Update user email verification
        /// </summary>
        /// <param name="user"></param>
        /// <param name="emailverified">User new email verification</param>
        /// <returns>User</returns>
        Task<User> UpdateEmailVerifiedAsync(User user, byte emailverified);

        /// <summary>
        /// Update user verification code
        /// </summary>
        /// <param name="user"></param>
        /// <param name="verificationcode">User new verification code</param>
        /// <returns>User</returns>
        Task<User> UpdateVerificationCodeAsync(User user, string verificationcode);

        /// <summary>
        /// Update user ip address
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ip">User new ip address</param>
        /// <returns>User</returns>
        Task<User> UpdateIpAsync(User user, string? ip);

        /// <summary>
        /// Update user phone number
        /// </summary>
        /// <param name="user"></param>
        /// <param name="phone">User new phone number</param>
        /// <returns>User</returns>
        Task<User> UpdatePhoneAsync(User user, string? phone);

        /// <summary>
        /// Update user fax
        /// </summary>
        /// <param name="user"></param>
        /// <param name="fax">User new fax</param>
        /// <returns>User</returns>
        Task<User> UpdateFaxAsync(User user, string? fax);

        /// <summary>
        /// Update user country
        /// </summary>
        /// <param name="user"></param>
        /// <param name="country">User new country</param>
        /// <returns>User</returns>
        Task<User> UpdateCountryAsync(User user, string? country);

        /// <summary>
        /// Update user first address
        /// </summary>
        /// <param name="user"></param>
        /// <param name="address1">User new first address</param>
        /// <returns>User</returns>
        Task<User> UpdateAddress1Async(User user, string? address1);

        /// <summary>
        /// Update user second address
        /// </summary>
        /// <param name="user"></param>
        /// <param name="address2">User new second address</param>
        /// <returns>User</returns>
        Task<User> UpdateAddress2Async(User user, string? address2);

        /// <summary>
        /// Update all User
        /// </summary>
        /// <param name="id">User id</param>
        /// <param name="user">New user</param>
        /// <returns>bool</returns>
        Task<bool> UpdateUserAsync(Guid id, User user);

        /// </post>

        ///<delete>

        ///<summary>
        /// Delete user
        /// </summary>
        /// <param name="id">User id</param>
        /// <returns>bool</returns>
        Task<bool> DeleteUserAsync(Guid id);

        /// </Delete>
    }
}
