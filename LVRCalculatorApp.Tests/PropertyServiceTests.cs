using LVRCalculatorApp.Services;

namespace LVRCalculatorApp.Tests;

public class PropertyServiceTests
{
    [Fact]
    public void GetLVR_Returns_Double()
    {
        //Arrange
        PropertyService propertyService = new();
        double propertyValue = 1000000;
        double loanAmount = 900000;
        //Act
        var result = propertyService.GetLVR(loanAmount, propertyValue);
        //Assert
        Assert.IsType<double>(result);
    }

    [Fact]
    public void GetLVR_Returns_Exception_When_PropertyValueIsZero()
    {
        //Arrange
        PropertyService propertyService = new();
        double propertyValue = 0;
        double loanAmount = 900000;
        //Act
        Func<Task> act = () => Task.FromResult(propertyService.GetLVR(loanAmount, propertyValue));
        //Assert
        Assert.ThrowsAsync<Exception>(act);
    }

}