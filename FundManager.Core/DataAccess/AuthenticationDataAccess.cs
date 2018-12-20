using System;
using System.Threading.Tasks;
using FundManager.Core.Model;
using Dapper;
using FundManager.Core.Component;

namespace FundManager.Core.DataAccess
{
    public class AuthenticationDataAccess : BaseDataAccess
    {
        private const string RegisterQuery = @"INSERT INTO [FundManagerDB].[dbo].[User] (UserName, Email, PasswordHash, PasswordSalt) VALUES (@UserName, @Email, @PasswordHash, @PasswordSalt)";

        private const string GetUserData =
            @"SELECT UserName, Email, PasswordHash, PasswordSalt FROM [FundManagerDB].[dbo].[User]
                                             WHERE UserName = @UserName";

        public async Task<QueryResult> Register(RegistrationModel input)
        {
            try
            {
                using (DbConnection)
                {
                    DbConnection.Open();

                    var hashSalt = EncryptionUtilities.CreatePasswordSalt(input.Password).Split(':');
                    var salt = hashSalt[0];
                    var hash = hashSalt[1];

                    var result = await DbConnection.ExecuteAsync(RegisterQuery, new
                    {
                        UserName = input.UserName,
                        Email = input.Email,
                        PasswordHash = hash,
                        PasswordSalt = salt
                    });

                    return new QueryResult
                    {
                        RowAffected = result,
                        IsSuccessfult = result > 0
                    };
                }
            }
            catch (Exception ex)
            {
                return new QueryResult
                {
                    IsSuccessfult = false,
                    ErrorMessage = $"An error has been occured. Error message: {ex.Message}"
                };
            }
        }

        public async Task<QueryResult<UserModel>> Login(LoginModel input)
        {
            try
            {
                var result = await DbConnection.QueryFirstAsync<SecretDataModel>(GetUserData, input.UserName);

                var isPasswordValid = EncryptionUtilities.IsPasswordValid(input.Password, $"{result.PasswordSalt}:{result.PasswordHash}");

                if (isPasswordValid)
                {
                    return new QueryResult<UserModel>
                    {
                        IsSuccessfult = true,
                        Result = new UserModel
                        {
                            UserName = result.UserName,
                            Email = result.Email,
                            Id = result.Id
                        }
                    };
                }

                return new QueryResult<UserModel>
                {
                    IsSuccessfult = false,
                    ErrorMessage = "User is not exist or incorrect password"
                };
            }
            catch (Exception ex)
            {
                return new QueryResult<UserModel>
                {
                    IsSuccessfult = false,
                    ErrorMessage = $"An internal error has been occured. Error message: {ex.Message}"
                };
            }
        }
    }
}
