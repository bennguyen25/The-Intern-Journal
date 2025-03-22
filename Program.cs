// Import the Entry class from the Models folder
using InternJournal.Models;

// Create a new instance of the Entry class
var entry = new Entry
{
    Id = 1,  // Unique identifier for the entry
    Title = "First Day of Intern Journal",  // Short summary of the day
    Body = "Today I created the project and wrote my first class in C#!",  // Full reflection
    Mood = "Productive",  // How I felt today
    Tags = new List<string> { "setup", "csharp", "day1" },  // Descriptive tags
    Date = DateTime.Now  // Automatically sets to current date and time
};

// Print the entry's date, title, and mood
Console.WriteLine($"[{entry.Date.ToShortDateString()}] {entry.Title} ({entry.Mood})");

// Print the tags as a comma-separated string
Console.WriteLine($"Tags: {string.Join(", ", entry.Tags)}");

// Print the full body of the journal entry
Console.WriteLine(entry.Body);
