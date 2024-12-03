namespace NuusBreakfast.Contracts.Breakfast
{
    public record UpsertBreakfastRequest(
        string Name,
        string Desc,
        DateTime StartDateTime,
        DateTime EndDateTime,
        List<string> Savory,
        List<string> Sweet);
}