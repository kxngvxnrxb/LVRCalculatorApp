using LVRCalculatorApp.Controllers;
using LVRCalculatorApp.Models;
using LVRCalculatorApp.Services;
using Moq;

namespace LVRCalculatorApp.Tests;

public class PropertyControllerTests
{
    [Fact]
    public void ComputeLVR_Returns_ServiceResponse()
    {
        //Arrange
        IPropertyService propertyService = new PropertyService();
        PropertyController propertyController = new(propertyService);
        Property property = new()
        {
            PropertyValue = 1000000,
            LoanAmount = 900000
        };
        //Act
        var res = propertyController.ComputeLVR(property);
        //Assert
        Assert.IsType<ServiceResponse<string>>(res.Value);
    }
}
