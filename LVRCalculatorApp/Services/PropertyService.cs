using LVRCalculatorApp.Models;

namespace LVRCalculatorApp.Services
{
    public class PropertyService : IPropertyService
    {
        public ServiceResponse<string> GetLVR(double loan, double value)
        {
            var response = new ServiceResponse<string>();

            if (value == 0)
            {
                response.Success = false;
                response.Message = "Property value should not be 0.";
                return response;
            }

            double result = (loan / value) * 100;
            response.Data = result.ToString("0.##") + "%";
            response.Success = true;

            return response;
        }
    }
}
