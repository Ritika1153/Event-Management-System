namespace Event_Management_System;

public partial class EventManager
{
    public void ManageEvent()
    {
        Console.WriteLine("Welcome to the Event Management System!");
        var exit = false;
        while (!exit)
        {
            Console.Write("Please enter a command:");
            var input = Console.ReadLine()?.Trim().ToLower().Split(" ");
            if (input == null)
                continue;
            int eventId = 0;
            var command = input[0];
            if (input.Length >=2)
                int.TryParse(input[1], out eventId);

            switch (command)
            {
                case "create":
                    CreateEvent();
                    break;

                case "list":
                    ListEvent();
                    break;

                case "get":

                    GetEvent(eventId);
                    break;


                case "update":
                    UpdateEvent(eventId);
                    break;

                case "delete":
                    DeleteEvent(eventId);

                    break;

                case "exit":
                    Console.WriteLine("Exiting the system.");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Unknown command. Available commands: create, list, get, update, delete, exit");
                    break;
            }
        }


    }
}