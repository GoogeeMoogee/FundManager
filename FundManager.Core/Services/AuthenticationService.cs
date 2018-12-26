using System;
using System.Threading.Tasks;
using FundManager.Core.DataAccess;
using FundManager.Core.Model;

namespace FundManager.Core.Services
{
    public class AuthenticationService
    {
        private readonly AuthenticationDataAccess _authenticationDataAccess;

        public AuthenticationService()
        {
            _authenticationDataAccess = new AuthenticationDataAccess();
        }

        public async Task<ServiceResponse> RegisterUser(RegistrationModel registrationModel)
        {
            try
            {
                var result = await _authenticationDataAccess.Register(registrationModel);
                return new ServiceResponse
                {
                    ErrorMessage = result.ErrorMessage,
                    IsSuccessful = result.IsSuccessfult
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse
                {
                    ErrorMessage = e.Message,
                    IsSuccessful = false
                };
            }
        }

        public async Task<ServiceResponse<UserModel>> LoginUser(LoginModel loginModel)
        {
            try
            {
                var result = await _authenticationDataAccess.Login(loginModel);
                return new ServiceResponse<UserModel>
                {
                    ErrorMessage = result.ErrorMessage,
                    IsSuccessful = result.IsSuccessfult,
                    Data = result.Result
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<UserModel>
                {
                    ErrorMessage = e.Message,
                    IsSuccessful = false,
                    Data = null
                };
            }
        }

        public async Task<bool> CheckIfExist(string userName)
        {
            return await _authenticationDataAccess.IfUserAlreadyExist(userName);
        }
    }
}