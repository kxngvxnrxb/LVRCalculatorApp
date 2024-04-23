using LVRCalculatorApp.Models;

namespace LVRCalculatorApp.Services
{
    public interface IPropertyService
    {
        ServiceResponse<string> GetLVR(double loan, double value);
    }
}
