using ModelLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IRegisterHelloBL
    {
        bool loginuser(LoginDTO loginDTO);
        string registration(string name);
    }
}
