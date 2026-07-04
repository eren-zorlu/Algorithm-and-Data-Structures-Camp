// See https://aka.ms/new-console-template for more information

using System.Collections;


// Initializing a SortedList (Automatically sorts elements by Key upon insertion)
var list = new SortedList()
{
    {1,"Bir" },
    {2,"İki" },
    {3,"Üç" },
    {8,"Sekiz" },
    {5,"Beş" },
    {6,"Altı" },
};

list.Add(4, "Dört");


// Iterating through the automatically sorted list
foreach (DictionaryEntry item in list)  
{
    Console.WriteLine(item);
}

// Memory and capacity analytics
Console.WriteLine("Listedeki eleman sayısı : {0} ",list.Count);
Console.WriteLine("Listenin kapasitesi : {0} ", list.Capacity);
list.TrimToSize(); // Trims excess capacity to optimize RAM usage
Console.WriteLine("listenin yeni kapasitesi : {0} ",list.Capacity);

// Accessing elements directly by Key
Console.WriteLine(list[4]);

// Accessing components by internal index position
Console.WriteLine(list.GetByIndex(0));
Console.WriteLine(list.GetKey(0));

// Retrieving the very last element components dynamically
Console.WriteLine(list.GetByIndex(list.Count-1));
Console.WriteLine(list.GetKey(list.Count-1));


// Extracting and iterating through the entire collection of Keys
var anahtarlar = list.Keys;
Console.WriteLine("\nAnahtarlar");
foreach (var item in anahtarlar)
{
    Console.WriteLine(item);
}


// Extracting and iterating through the entire collection of Values
var degerler = list.Values;
Console.WriteLine("\nDeğerler");
foreach (var item in degerler)
{
    Console.WriteLine(item);
}


Console.ReadKey();

// --- Key Verification and Data Update Safety Check ---

if (list.ContainsKey(1))
{
    list[1] = "One";
    list[2] = "Two";
    list[3] = "Three";
    list[4] = "Four";
    list[5] = "Five";
    list[6] = "Six";
    list[8] = "Eight";
}

Console.WriteLine();
foreach (DictionaryEntry item in list)
{
    Console.WriteLine($"{item.Key} - {item.Value} ");
}

Console.ReadKey();

// Removing an element by its index position instead of its Key
list.RemoveAt(4);
foreach (DictionaryEntry item in list)
{
    Console.WriteLine($" {item.Key}  {item.Value}");
}

Console.ReadKey();
