public class Breakfast
{
    public Guid Id { get; }
    public string Name { get; } = string.Empty; 
    public string Desc { get; } = string.Empty; 
    public DateTime StartDateTime { get; }
    public DateTime EndDateTime { get; }
    public DateTime LastModifiedDateTime { get; }
    public List<string> Savory { get; } = new(); 
    public List<string> Sweet { get; } = new();  

public Breakfast(Guid id, string? name, string? desc, DateTime startDateTime, DateTime endDateTime, DateTime lastModifiedDateTime, List<string>? savory, List<string>? sweet)
{
    Id = id;
    Name = name ?? string.Empty;
    Desc = desc ?? string.Empty;
    StartDateTime = startDateTime;
    EndDateTime = endDateTime;
    LastModifiedDateTime = lastModifiedDateTime;
    Savory = savory ?? new List<string>();
    Sweet = sweet ?? new List<string>();
}

}
