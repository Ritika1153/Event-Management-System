using Event_Management_System.Models;

namespace Event_Management_System;
public partial class EventManager
{
    public void CreateEvent()
    {
        var newEvent = new Event
        {
            Name = PromptRequiredInput("Enter Event Name: "),
            Description = PromptOptionalInput("Enter Description (optional): "),
            Date = PromptRequiredDate("Enter Date (yyyy-MM-dd): "),
            Location = PromptOptionalInput("Enter Location (optional): "),
            Id = _nextId++
        };
        Events.Add(newEvent);
        Console.WriteLine("Event created successfully!");
    }

}