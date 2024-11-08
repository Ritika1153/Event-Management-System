namespace Event_Management_System;

public partial class EventManager
{

    public void ListEvent()
    {
        if (Events.Count == 0)
        {
            Console.WriteLine("No events found.");
            return;
        }

        foreach (var ev in Events)
        {
            PrintEvent(ev,true);
            Console.WriteLine();
        }
    }
}