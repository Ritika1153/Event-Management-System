namespace Event_Management_System;

public partial class EventManager
{
    public void GetEvent(int id)
    {
        var ev = Events.Find(e => e.Id == id);
        if (ev == null)
        {
            Console.WriteLine("Event not found.");
            return;
        }

        Console.WriteLine("Event Details:");
        PrintEvent(ev,true);
    }

}