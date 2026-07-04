// See https://aka.ms/new-console-template for more information

// Application: Data Deduplication and Sorting using SortedSet

var sayilar = new List<int>();
var r = new Random();
Console.WriteLine();
for (int i = 0; i < 1000; i++)
{
    sayilar.Add(r.Next(0,10)); 
    Console.WriteLine("{0}.Eleman : {1}",i, sayilar[i]);
}
Console.WriteLine();


var benzersizSayiListesi = new SortedSet<int>(sayilar);

Console.WriteLine();
Console.WriteLine("\nBenzersiz sayilarin listesi\n");
foreach (int sayi in benzersizSayiListesi)
{
    Console.WriteLine($" {sayi,-3}");
}

Console.WriteLine("Benzersiz {0} sayi vardir.",benzersizSayiListesi.Count);


Console.ReadKey();



