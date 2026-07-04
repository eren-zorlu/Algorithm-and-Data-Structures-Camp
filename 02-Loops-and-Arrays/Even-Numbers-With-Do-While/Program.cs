// See https://aka.ms/new-console-template for more information




int maxNumber;


Console.Write("Enter a number (Minimum 2): ");
while (!int.TryParse(Console.ReadLine(), out maxNumber) || maxNumber < 2)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Invalid input! Please enter a whole number greater than or equal to 2.");
    Console.ResetColor();
    Console.Write("Try again: ");
}

int currentNumber = 2;

// The 'do' block runs at least once before checking the 'while' condition.
// In a standard 'while' loop, the condition is checked first.

do                     
{
    Console.WriteLine(currentNumber);
    currentNumber += 2;
    
} while (currentNumber <=maxNumber);


