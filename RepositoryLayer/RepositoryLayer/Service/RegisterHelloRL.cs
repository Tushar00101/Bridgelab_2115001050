using ModelLayer.DTO;

namespace RepositoryLayer.Service;
using RepositoryLayer.Interface;

public class RegisterHelloRL : IRegisterHelloRL
{
    private string databaseUsername = "root";
    private string databasePassword = "root";

    public RegisterHelloRL()
    {

    }

    public string GetHello(string name)
    {
        return name + " Hello from Repository layer ";
    }

    public LoginDTO getUsernamePassword(LoginDTO loginDTO)
    {
        loginDTO.username = databaseUsername;
        loginDTO.password = databasePassword;

        return loginDTO;

    }
}
