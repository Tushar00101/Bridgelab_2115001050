using ModelLayer.DTO;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryLayer.Service
{
    public class RegisterHelloRL : IRegisterHelloRL
    {
        private readonly HelloAppContext _context;
        private readonly ILogger<RegisterHelloRL> _logger;

        public RegisterHelloRL(HelloAppContext context, ILogger<RegisterHelloRL> logger)
        {
            _context = context;
            _logger = logger;
        }

        public string GetHello(string name)
        {
            _logger.LogInformation("Repository Layer: Processing GetHello for {Name}", name);
            return name + " Hello from Repository layer ";
        }

        public LoginDTO getUsernamePassword(LoginDTO loginDTO)
        {
            try
            {
                _logger.LogInformation("Repository Layer: Retrieving user credentials for {Email}", loginDTO.Email);

                var result = _context.Users.FirstOrDefault(e => loginDTO.Email == e.Email);

                if (result == null)
                {
                    _logger.LogWarning("Repository Layer: User not found for {Email}", loginDTO.Email);
                    return null;
                }

                loginDTO.Email = result.Email;
                loginDTO.Password = result.Password;

                _logger.LogInformation("Repository Layer: User credentials retrieved successfully for {Email}", loginDTO.Email);
                return loginDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Repository Layer: Error while retrieving user credentials for {Email}", loginDTO.Email);
                return null;
            }
        }

        public List<ResponseRegisterDTO> GetAllUsersRL()
        {
            try
            {
                _logger.LogInformation("Repository Layer: Fetching all users.");

                var users = _context.Users.Select(e => new ResponseRegisterDTO
                {
                    UserId = e.UserId,
                    Email = e.Email,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                }).ToList();

                _logger.LogInformation("Repository Layer: Retrieved {UserCount} users.", users.Count);
                return users;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Repository Layer: Error while fetching all users.");
                return new List<ResponseRegisterDTO>();
            }
        }

        public Entity.UserEntity RegistrationRL(RegisterDTO registrationDTO)
        {
            try
            {
                _logger.LogInformation("Repository Layer: Checking if user already exists {Email}", registrationDTO.Email);

                var result = _context.Users.FirstOrDefault(e => e.Email == registrationDTO.Email);

                if (result != null)
                {
                    _logger.LogWarning("Repository Layer: User already exists {Email}", registrationDTO.Email);
                    return result;
                }

                var userEntity = new UserEntity
                {
                    Email = registrationDTO.Email,
                    Password = registrationDTO.Password,
                    FirstName = registrationDTO.FirstName,
                    LastName = registrationDTO.LastName
                };

                _context.Users.Add(userEntity);
                _context.SaveChanges();

                _logger.LogInformation("Repository Layer: User registered successfully {Email}", registrationDTO.Email);
                return userEntity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Repository Layer: Error during registration for {Email}", registrationDTO.Email);
                return null;
            }
        }
    }
}
