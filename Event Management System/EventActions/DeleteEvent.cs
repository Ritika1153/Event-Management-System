namespace Event_Management_System;

public partial class EventManager
{
    public void DeleteEvent(int id)
    {
        var ev = Events.Find(e => e.Id == id);
        if (ev == null)
        {
            Console.WriteLine("Event not found.");
            return;
        }

        Events.Remove(ev);
        Console.WriteLine("Event deleted successfully!");
    }
}