using Microsoft.AspNetCore.Mvc;
using NuusBreakfast.Contracts.Breakfast;

//Attribute ASP.NET Core controller
[ApiController]
// [Route("breakfasts")]
//ROUTE PREFIX FOR THE CONTROLLER "/breakfasts/..."
[Route("[controller]")]  //This will use the name of the controller as the route prefix
public class BreakfastsController : ControllerBase
{
    //Post request to create a breakfast
    [HttpPost()]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        //map the request data to the breakfast object
        Breakfast breakfast = new Breakfast(
            Guid.NewGuid(),
            request.Name,
            request.Desc,
            request.StartDateTime,
            request.EndDateTime,
            DateTime.UtcNow,
            request.Savory,
            request.Sweet);
        //database operation

        //taking back data from system/db and returning it to the client
        var response = new BreakfastResponse(
            breakfast.Id,
            breakfast.Name ?? string.Empty,
            breakfast.Desc ?? string.Empty,
            breakfast.StartDateTime,
            breakfast.EndDateTime,
            breakfast.LastModifiedDateTime,
            breakfast.Savory ?? new List<string>(),
            breakfast.Sweet ?? new List<string>()
        );

        return CreatedAtAction(nameof(GetBreakfast), new { id = response.Id }, response);
    }

    //Get request to create a breakfast
    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        return Ok(id);
    }

    //Put request to create a breakfast
    [HttpPut("{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id,UpsertBreakfastRequest request)
    {
        return Ok(request);
    }

    //Delete request to create a breakfast
    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id)
    {
        return Ok(id);
    }
}