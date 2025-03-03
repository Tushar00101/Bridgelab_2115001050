using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using ModelLayer.DTO;
using BusinessLayer.Interface;
using Microsoft.Extensions.Logging;

namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloAppController : ControllerBase
    {
        private readonly IRegisterHelloBL _registerHelloBL;
        private readonly ILogger<HelloAppController> _logger;
        ResponseModel<String> response;

        public HelloAppController(IRegisterHelloBL registerHelloBL, ILogger<HelloAppController> logger)
        {
            _registerHelloBL = registerHelloBL;
            _logger = logger;
        }

        [HttpGet("users")]
        public IActionResult GetAllUsers()
        {
            try
            {
                _logger.LogInformation("Fetching all users...");
                var result = _registerHelloBL.GetAllUsersBL();
                _logger.LogInformation("Users retrieved successfully.");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving users.");
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public String Get()
        {
            _logger.LogInformation("Handling GET request in controller.");
            return _registerHelloBL.registration("Value from controller");
        }

        [HttpPost("login")]
        public IActionResult LoginUser(LoginDTO loginDTO)
        {
            try
            {
                _logger.LogInformation("Login attempt for user: {Email}", loginDTO.Email);
                response = new ResponseModel<String>();

                bool result = _registerHelloBL.loginuser(loginDTO);

                if (result)
                {
                    _logger.LogInformation("Login successful for user: {Email}", loginDTO.Email);
                    response.Success = true;
                    response.Message = "Login Successful";
                    response.Data = loginDTO.Email;
                    return Ok(response);
                }
                _logger.LogWarning("Login failed for user: {Email}", loginDTO.Email);
                response.Success = false;
                response.Message = "Login failed, Password not matched";
                response.Data = "";
                return NotFound(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Login failed for user: {Email}", loginDTO.Email);
                response.Success = false;
                response.Message = "Login failed";
                response.Data = ex.Message;
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegisterDTO registerDTO)
        {
            try
            {
                _logger.LogInformation("User registration attempt: {Email}", registerDTO.Email);

                var result = _registerHelloBL.RegistrationBL(registerDTO);

                _logger.LogInformation("User registration successful: {Email}", registerDTO.Email);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "User registration failed: {Email}", registerDTO.Email);
                return BadRequest(ex.Message);
            }
        }
    }
}
