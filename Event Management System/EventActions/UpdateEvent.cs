namespace Event_Management_System;

public partial class EventManager
{
    public void UpdateEvent(int id)
    {
        var ev = Events.Find(e => e.Id == id);
        if (ev == null)
        {
            Console.WriteLine("Event not found.");
            return;
        }
        ev.Name = PromptRequiredInput("Enter new Event Name: ");
        ev.Description = PromptOptionalInput("Enter new Description: ");
        ev.Date = PromptRequiredDate("Enter new Date (yyyy-MM-dd): ");
        ev.Location = PromptOptionalInput("Enter new Location: ");
        Console.WriteLine("Event updated successfully!");
    }

}