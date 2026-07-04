// See https://aka.ms/new-console-template for more information




int arraySize;
Console.Write("Enter the array size: ");
while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Invalid input! Please enter a positive integer.");
    Console.ResetColor();
    Console.Write("Try again: ");
}

int[] numbers = new int[arraySize];

var r = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = r.Next(1, 10);
}

foreach (int s in numbers)
{
    Console.WriteLine($"{s,5} {s*s,5}");
}

