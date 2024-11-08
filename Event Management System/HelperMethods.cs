using Event_Management_System.Models;

namespace Event_Management_System;

public partial class EventManager
{
    private DateOnly PromptRequiredDate(string prompt)
    {
        DateOnly date;
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            if (!DateOnly.TryParse(input, out date))
            {
                Console.WriteLine("Invalid date format. Please enter a valid date (yyyy-MM-dd).");
            }
        } while (!DateOnly.TryParse(input, out date));

        return date;
    }

    private string PromptOptionalInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    private string PromptRequiredInput(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("This field is required. Please enter a value.");
            }
        } while (string.IsNullOrEmpty(input));

        return input;
    }

    public void PrintIfNotEmpty(string input)
    {
        if(!string.IsNullOrEmpty(input) || !string.IsNullOrWhiteSpace(input))
            Console.Write(input);
    }

    private void PrintEvent(Event ev,bool isNewLine = false)
    {
        PrintIfNotEmpty("ID: ", $"{ev.Id}", isNewLine);
        PrintIfNotEmpty("Name: ", ev.Name, isNewLine);
        PrintIfNotEmpty("Date: ", ev.Date.ToString(), isNewLine);
        PrintIfNotEmpty("Description: ", ev.Description, isNewLine);
        PrintIfNotEmpty("Location: ", ev.Location, isNewLine);

    }

    private void PrintIfNotEmpty(string label,string input,bool isnewLine = false)
    {
        if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            return;

        if(isnewLine)
            Console.WriteLine(label + input);
        else
            Console.Write(label + input);

    }

}