// See https://aka.ms/new-console-template for more information




// Initializing a generic Stack for character management
var karakterYigini = new Stack<char>();

// 1. Populating the stack with uppercase letters (A-Z) using ASCII table integer casting
for (int i = 65; i <=90; i++)
{
    karakterYigini.Push((char)i);
    Console.WriteLine($"{karakterYigini.Peek()} yığına eklendi.");
    Console.WriteLine($"Yığındaki eleman sayısı : {karakterYigini.Count()}");
}

// 2. Pro Tip: Converting a Stack directly into a standard Array
// This takes a snapshot of the stack elements in their current order without modifications.
var dizi = karakterYigini.ToArray(); 


Console.WriteLine("\nYığından çıkarma işlemi için bir tuşa basınız :)");
Console.ReadKey();

// 3. Popping elements using a dynamic while loop until the stack is completely empty
// REMINDER: Stacks always operate on the Last-In, First-Out (LIFO) principle.

while (karakterYigini.Count>0) 
{
    Console.WriteLine($" {karakterYigini.Pop()} yığından çıkarıldı.");
    Console.WriteLine($"Yığındaki eleman sayısı : {karakterYigini.Count()}");
}


Console.ReadKey();

