// See https://aka.ms/new-console-template for more information


Console.Write("Input: ");
int size = int.Parse(Console.ReadLine());

if (size % 2 == 0 || size < 1)
{
    Console.WriteLine("Please enter a positive odd number.");
    return;
}

int mid = size / 2;

// Top half including middle line
for (int i = 0; i <= mid; i++)
{
    for (int j = 0; j < mid - i; j++)
        Console.Write(" ");

    for (int k = 0; k < 2 * i + 1; k++)
        Console.Write("*");

    Console.WriteLine();
}

// Bottom half
for (int i = mid - 1; i >= 0; i--)
{
    for (int j = 0; j < mid - i; j++)
        Console.Write(" ");

    for (int k = 0; k < 2 * i + 1; k++)
        Console.Write("*");

    Console.WriteLine();
}