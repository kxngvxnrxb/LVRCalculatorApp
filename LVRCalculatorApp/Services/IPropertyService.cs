using LVRCalculatorApp.Models;

namespace LVRCalculatorApp.Services
{
    public interface IPropertyService
    {
        double GetLVR(double loan, double value);
    }
}
