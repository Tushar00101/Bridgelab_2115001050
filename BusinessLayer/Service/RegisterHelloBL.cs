using System;
using System.Collections.Generic;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
using Microsoft.Extensions.Logging;

namespace BusinessLayer.Service
{
    public class RegisterHelloBL : IRegisterHelloBL
    {
        private readonly IRegisterHelloRL _registerHelloRL;
        private readonly ILogger<RegisterHelloBL> _logger;

        public RegisterHelloBL(IRegisterHelloRL registerHelloRL, ILogger<RegisterHelloBL> logger)
        {
            _registerHelloRL = registerHelloRL;
            _logger = logger;
        }

        public string registration(string str)
        {
            _logger.LogInformation("Business Layer: Handling registration input.");
            return "";
        }

        public ResponseRegisterDTO RegistrationBL(RegisterDTO registerDTO)
        {
            try
            {
                _logger.LogInformation("Business Layer: Registering user {Email}", registerDTO.Email);
                var result = _registerHelloRL.RegistrationRL(registerDTO);

                if (result == null)
                {
                    _logger.LogWarning("Business Layer: Registration failed for {Email}", registerDTO.Email);
                    return null;
                }

                ResponseRegisterDTO responseRegisterDTO = new ResponseRegisterDTO
                {
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    Email = result.Email
                };

                _logger.LogInformation("Business Layer: Registration successful for {Email}", registerDTO.Email);
                return responseRegisterDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Business Layer: Error in RegistrationBL for {Email}", registerDTO.Email);
                throw;
            }
        }

        public bool loginuser(LoginDTO loginDTO)
        {
            try
            {
                _logger.LogInformation("Business Layer: Login attempt for {Email}", loginDTO.Email);

                string frontendEmail = loginDTO.Email;
                string frontendPassword = loginDTO.Password;

                LoginDTO result = _registerHelloRL.getUsernamePassword(loginDTO);

                if (result == null)
                {
                    _logger.LogWarning("Business Layer: Login failed, user not found: {Email}", loginDTO.Email);
                    return false;
                }

                bool res = checkUsernamePassword(frontendEmail, frontendPassword, result);

                if (res)
                {
                    _logger.LogInformation("Business Layer: Login successful for {Email}", loginDTO.Email);
                }
                else
                {
                    _logger.LogWarning("Business Layer: Login failed, incorrect password for {Email}", loginDTO.Email);
                }

                return res;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Business Layer: Error during login for {Email}", loginDTO.Email);
                throw;
            }
        }

        public List<ResponseRegisterDTO> GetAllUsersBL()
        {
            try
            {
                _logger.LogInformation("Business Layer: Fetching all users.");
                var result = _registerHelloRL.GetAllUsersRL();

                _logger.LogInformation("Business Layer: Retrieved {UserCount} users.", result.Count);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Business Layer: Error while fetching all users.");
                throw;
            }
        }

        private bool checkUsernamePassword(string frontendEmail, string frontendPassword, LoginDTO result)
        {
            bool isValid = frontendEmail.Equals(result.Email) && frontendPassword.Equals(result.Password);

            if (isValid)
            {
                _logger.LogInformation("Business Layer: Password matched for {Email}", frontendEmail);
            }
            else
            {
                _logger.LogWarning("Business Layer: Password mismatch for {Email}", frontendEmail);
            }

            return isValid;
        }
    }
}
