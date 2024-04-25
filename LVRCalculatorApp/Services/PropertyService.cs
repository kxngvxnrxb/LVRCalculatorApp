using LVRCalculatorApp.Models;

namespace LVRCalculatorApp.Services
{
    public class PropertyService : IPropertyService
    {
        public double GetLVR(double loan, double value)
        {
            double result = (loan / value) * 100;
            return result;
        }
    }
}
