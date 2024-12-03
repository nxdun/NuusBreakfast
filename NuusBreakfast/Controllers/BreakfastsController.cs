using Microsoft.AspNetCore.Mvc;
using NuusBreakfast.Contracts.Breakfast;

//Attribute ASP.NET Core controller
[ApiController]
// [Route("breakfasts")]
//ROUTE PREFIX FOR THE CONTROLLER "/breakfasts/..."
[Route("[controller]")]  //This will use the name of the controller as the route prefix
public class BreakfastsController : ControllerBase
{
    private readonly IBreakfastService _breakfastService;
    public BreakfastsController(IBreakfastService breakfastService)
    {
        _breakfastService = breakfastService;
    }


    //Post request to create a breakfast
    [HttpPost()]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
    Console.WriteLine("CreateBreakfast endpoint hit");
    var breakfast = new Breakfast(
        Guid.NewGuid(),
        request.Name,
        request.Desc,
        request.StartDateTime,
        request.EndDateTime,
        DateTime.UtcNow,
        request.Savory,
        request.Sweet);

    _breakfastService.CreateBreakfast(breakfast);

    var response = new BreakfastResponse(
        breakfast.Id,
        breakfast.Name,
        breakfast.Desc,
        breakfast.StartDateTime,
        breakfast.EndDateTime,
        breakfast.LastModifiedDateTime,
        breakfast.Savory,
        breakfast.Sweet);

    return CreatedAtAction(nameof(GetBreakfast), new { id = response.Id }, response);
    }

    //Get request to create a breakfast
    [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
    try
    {
        Breakfast breakfast = _breakfastService.GetBreakfast(id);

        //print the breakfast object to the console
        Console.WriteLine("Breakfast ",breakfast);

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

        Console.WriteLine("Response ",response);
        return Ok(response);
    }
    catch (KeyNotFoundException ex)
    {
        // Log the exception if needed
        return NotFound(new { message = ex.Message });
    }
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