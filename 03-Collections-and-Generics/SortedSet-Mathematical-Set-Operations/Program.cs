// See https://aka.ms/new-console-template for more information



// Application: Demonstrating Mathematical Set Operations using SortedSet

var A = new SortedSet<int>() { 1, 2, 3, 4 };
var B = new SortedSet<int>() { 1, 2, 5, 6 };

// 1. Displaying Initial Sets
Console.WriteLine();
Console.WriteLine("A kümesi");
foreach (int x in A)
{
    Console.Write($"{x,5}");
}

Console.WriteLine();
Console.WriteLine("B Kümesi");
foreach (int y in B)
{
    Console.Write($"{y,5}");
}

// 2. Mathematical Union Operation (A ∪ B)
// UnionWith modifies the invoking set to contain all elements present in both sets.
A.UnionWith(B);
Console.WriteLine();
Console.WriteLine("A ve B kümesinin birleşimi");
foreach (int b in A)
{
    Console.Write($"{b,5}");
}

// 3. Mathematical Intersection Operation (A ∩ B)
// CRITICAL NOTE: IntersectWith operates on the MODIFIED state of setA (which is now the union).

A.IntersectWith(B); 
Console.WriteLine();
Console.WriteLine("A ve B kümesinin kesişimi");
foreach (int k in A)
{
    Console.WriteLine($"{k,5}");
}


Console.ReadKey();


