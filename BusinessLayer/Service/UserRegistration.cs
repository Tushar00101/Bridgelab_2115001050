using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Service;

namespace BusinessLayer.Service
{
    public class UserRegistration
    {
        UserRepository _userRegistrationRL;
        public UserRegistration(UserRepository userRegistrationRL) 
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public bool UserLoginBL(LoginDTO loginDTO)
        {
            string email = loginDTO.email;
            string password = loginDTO.password;
            //_userRegistrationRL.LoginUserRL(loginDTO)
            bool result=CheckUser(_userRegistrationRL.LoginUserRL(loginDTO), email, password);

            return result;

        }

        public bool CheckUser(LoginDTO loginDTO, string email, string password)
        {
            if (loginDTO == null) return false;

            if (loginDTO.email == email && loginDTO.password == password) return true;

            return false;
        }

        public bool UserRegistrationBL(RegisterUserDTO registerUserDTO)
        {
            return _userRegistrationRL.RegisterUserRL(registerUserDTO) != null;
        }
    }
}
