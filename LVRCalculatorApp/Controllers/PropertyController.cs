using LVRCalculatorApp.Models;
using LVRCalculatorApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LVRCalculatorApp.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class PropertyController : ControllerBase
{
    private readonly IPropertyService _propertyService;

    public PropertyController(IPropertyService propertyService)
    {
        _propertyService = propertyService;
    }

    [HttpPost]
    public ActionResult<ServiceResponse<string>> ComputeLVR(Property property)
    {
        if (property.PropertyValue == 0)
            return BadRequest("Property value should not be 0.");

        var response = _propertyService.GetLVR(property.LoanAmount, property.PropertyValue);
        ServiceResponse<string> serviceResponse = new();
        serviceResponse.Data = response.ToString("0.##") + "%";
        return serviceResponse;
    }
}
