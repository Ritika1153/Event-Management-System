namespace Event_Management_System.Models;

public class Event
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateOnly Date { get; set; }

    public string Location { get; set; } = string.Empty;

}