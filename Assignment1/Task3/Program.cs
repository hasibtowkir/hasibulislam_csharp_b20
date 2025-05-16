// See https://aka.ms/new-console-template for more information

// Set array size
int rows = 5, cols = 5;
int[,] grid = new int[rows, cols];

Console.WriteLine("Enter coordinates (x,y). Press Enter on a blank line to finish:");

while (true)
{
    string input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
        break;

    string[] parts = input.Split(',');
    if (parts.Length != 2)
    {
        Console.WriteLine("Invalid format. Enter as x,y");
        continue;
    }

    if (int.TryParse(parts[0], out int x) && int.TryParse(parts[1], out int y))
    {
        if (x >= 0 && x < rows && y >= 0 && y < cols)
        {
            grid[x, y]++;
        }
        else
        {
            Console.WriteLine($"Ignored: ({x},{y}) is out of bounds.");
        }
    }
    else
    {
        Console.WriteLine("Invalid numbers. Please enter integers like 1,2");
    }
}

Console.WriteLine("\nOutput:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(grid[i, j] + " ");
    }
    Console.WriteLine();
}