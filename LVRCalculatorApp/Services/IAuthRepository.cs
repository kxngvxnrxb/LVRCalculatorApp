using LVRCalculatorApp.Models;

namespace LVRCalculatorApp.Services
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> CreateToken(string username, string password);
        Task<bool> UserExists(string username);
    }
}
