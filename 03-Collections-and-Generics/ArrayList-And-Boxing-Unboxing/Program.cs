// See https://aka.ms/new-console-template for more information



// ArrayList Usage and Memory Concepts

using System.Collections;



var arrayList = new ArrayList();

arrayList.Add(10);   //boxing işlemi yapılır burada
arrayList.Add("BTK Akademi");
arrayList.Add(true);
arrayList.Add('e');

foreach (var e in arrayList)
{
    Console.Write($"{e} ");
}

int[] sayilar = new int[] { 23, 44, 55 };  // Defining a standard array and adding its entire range to the ArrayList
arrayList.AddRange(sayilar);

Console.WriteLine();
foreach (var e in arrayList) // Printing the updated ArrayList elements after AddRange
{
    Console.Write($"{e} ");
}
Console.WriteLine();
Console.WriteLine(arrayList[4]); // Accessing element by index


var x = (int)arrayList[0];  // Unboxing (Casting): To extract a value type from an ArrayList, an explicit cast is required
Console.WriteLine(x+10);  // Adding 10 to the extracted integer value


// --- ArrayList Deletion Methods ---

arrayList.Remove(10); // Removes the specific element with value 10
arrayList.RemoveAt(1);// Removes the element at index 1 after the previous deletion
Console.WriteLine();  

foreach (var a in arrayList)
{
    Console.Write($"{a} ");// Printing elements to see the state after initial deletions
}
// Removes 3 elements starting from index 2
arrayList.RemoveRange(2, 3); 
Console.WriteLine("\n");

// Final print to verify the remaining items
foreach (var a in arrayList)
{
    Console.Write($"{a} ");
}

Console.ReadKey();











