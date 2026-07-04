// See https://aka.ms/new-console-template for more information



using System.Collections;

// Initializing a Hashtable collection (Key-Value structure)
var cities = new Hashtable(); 
cities.Add(6, "Ankara");
cities.Add(34, "İstanbul");
cities.Add(55, "Samsun");
cities.Add(23, "Elazığ");


foreach (DictionaryEntry a in cities)
{
    Console.WriteLine($" {a.Key,-5}  -----> {a.Value,-20}");
}

// 1. Retrieving and printing Keys only
Console.WriteLine("\nAnahtarlar(Keys)");
var anahtarlar = cities.Keys;
foreach (var item in anahtarlar)
{
    Console.WriteLine(item);
}


// 2. Retrieving and printing Values only via ICollection interface
Console.WriteLine("\nDeğerler(Values)");
ICollection degerler = cities.Values;
foreach (var item in degerler)
{
    Console.WriteLine(item);
}

// 3. Direct Element Access via Key indexer
Console.WriteLine("\nElemana erişme");
Console.WriteLine(cities[55]);
Console.WriteLine(cities[6]);


// 4. Removing an element by its Key
Console.WriteLine("\nEleman silme");
cities.Remove(23);

foreach (DictionaryEntry item in cities)
{
    Console.WriteLine($" {item.Key,-5}   {item.Value,-20}");
}

Console.ReadKey(); 


