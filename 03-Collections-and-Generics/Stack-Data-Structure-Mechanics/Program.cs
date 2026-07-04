// See https://aka.ms/new-console-template for more information


// Defining a generic Stack structure for safe char management
var karakterYıgını = new Stack<char>();

// Pushing elements onto the stack (Adding to the top)
karakterYıgını.Push('A');
Console.WriteLine(karakterYıgını.Peek());
karakterYıgını.Push('B');
Console.WriteLine(karakterYıgını.Peek());
karakterYıgını.Push('C');
Console.WriteLine(karakterYıgını.Peek());

// Popping elements from the stack (Removing from the top - LIFO principle)
// Note: Pop() doesn't take parameters because it always removes the top item, like a stack of plates!
Console.WriteLine(karakterYıgını.Pop() + " yığından çıkarıldı."); 
Console.WriteLine(karakterYıgını.Pop() + " yığından çıkarıldı.");
Console.WriteLine(karakterYıgını.Pop() + " yığından çıkarıldı.");




Console.ReadKey();

