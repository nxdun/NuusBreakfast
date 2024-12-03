namespace NuusBreakfast.Contracts.Breakfast
{
    public record BreakfastResponse(
        Guid Id,
        string Name,
        string Desc,
        DateTime StartDateTime,
        DateTime EndDateTime,
        DateTime LastModifiedDateTime,
        List<string> Savory,
        List<string> Sweet);
}