// See https://aka.ms/new-console-template for more information




// List<T> Usage and Core Logic

var sayilar = new List<int>();

int x = 55;
int[] seri = new int[] { 70, 80, 90, };

sayilar.Add(10);
sayilar.Add(15);
sayilar.Add(20);
sayilar.Add(x);
sayilar.AddRange(seri); // Adds the entire array to the list at once
sayilar.AddRange(new int[] { 7, 8, 9 }); // Modern shortcut: Adding an array directly inline without declaring a variable first!
// Inserts 123 at index 3, shifting the subsequent elements to the right
sayilar.Insert(3, 123); 
sayilar.InsertRange(4,new int[]  { 77, 88, 99 });
sayilar.RemoveAt(3);  // Removes the element at the specified index
sayilar.Remove(55); 


// Iterates through the list and prints each element left-aligned with a 5-character width
foreach (int a in sayilar)  
{
    Console.Write($"{a,-5} ");
}

Console.ReadKey();



