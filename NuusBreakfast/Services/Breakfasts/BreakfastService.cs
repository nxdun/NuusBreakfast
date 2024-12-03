public class BreakfastService : IBreakfastService
{
    //constructor
    public BreakfastService()
{
    Console.WriteLine("--------BreakfastService instance created.");
}

    
    // Key-value pair to store breakfasts by id
    private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();

    public void CreateBreakfast(Breakfast breakfast)
    {
        _breakfasts.Add(breakfast.Id, breakfast);
    }

    public Breakfast GetBreakfast(Guid id)
    {
        Console.WriteLine("GetBreakfast() called count in breakfasts: " + _breakfasts.Count);
        //print breakfasts
        foreach (var breakfas in _breakfasts)
        {
            Console.WriteLine(breakfas);
        }
        if (_breakfasts.TryGetValue(id, out var breakfast))
        {
            return breakfast;
        }

        // Throw a custom exception >>>
        throw new KeyNotFoundException($"Breakfast with ID '{id}' was not found.");
    }

    
}
