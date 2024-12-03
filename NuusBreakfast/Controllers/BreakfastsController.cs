using Microsoft.AspNetCore.Mvc;
using NuusBreakfast.Contracts.Breakfast;

//Attribute ASP.NET Core controller
[ApiController]
public class BreakfastsController : ControllerBase
{
    //Post request to create a breakfast
    [HttpPost("/breakfasts")]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        // Create a breakfast
        return Ok(request);
    }

    //Get request to create a breakfast
    [HttpGet("/breakfasts/{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        // Create a breakfast
        return Ok(id);
    }

    //Put request to create a breakfast
    [HttpPut("/breakfasts/{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id,UpsertBreakfastRequest request)
    {
        // Create a breakfast
        return Ok(request);
    }

    //Delete request to create a breakfast
    [HttpDelete("/breakfasts/{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id)
    {
        // Create a breakfast
        return Ok(id);
    }
}