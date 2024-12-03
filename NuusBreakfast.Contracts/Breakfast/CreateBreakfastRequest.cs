namespace NuusBreakfast.Contracts.Breakfast
{
    public record CreateBreakfastRequest(
        string Name,
        string Desc,
        DateTime StartDateTime,
        DateTime EndDateTime,
        List<string> Savory,
        List<string> Sweet);
}