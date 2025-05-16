// See https://aka.ms/new-console-template for more information

// input
Console.Write("Input: ");
string input = Console.ReadLine();

// Split the input string by commas
string[] parts = input.Split(',');

int sum = 0;

// Loop through each part of the input
foreach (string part in parts)
{
    // Trim whitespace and try to convert to integer
    if (int.TryParse(part.Trim(), out int number))
    {
        sum += number; // Add valid number to sum
    }
    else
    {
        // Handle invalid input
        Console.WriteLine($"Invalid number: {part}");
        return; // Exit the program if any number is invalid
    }
}

// Output 
Console.WriteLine("Output: " + sum);
