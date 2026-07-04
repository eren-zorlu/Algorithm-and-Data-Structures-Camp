// See https://aka.ms/new-console-template for more information


// Application: Exploring HashSet mechanics for O(1) complexity and implementing DRY principles

var sesliHarfler = new HashSet<char>()
{
    'e','ı','i','u','ü','o','ö','b'
};
KoleksiyonYazdir(sesliHarfler);

//Ekleme
sesliHarfler.Add('a');
KoleksiyonYazdir(sesliHarfler);

//Çıkarma
sesliHarfler.Remove('b');
KoleksiyonYazdir(sesliHarfler);
Console.WriteLine();

Console.ReadKey();

Console.WriteLine("Alfabe Çıktısı!!!");
var alfabe = new List<char>();
for (int i = 97; i < 123; i++)
{
    alfabe.Add((char)i);
}
alfabe.ForEach(k => Console.Write(k));


Console.ReadKey();

static void KoleksiyonYazdir(HashSet<char> koleksiyon)
{
    Console.WriteLine();
    foreach (char k in koleksiyon)
    {
        Console.Write($"{k,5}");
    }
    Console.WriteLine();
    Console.WriteLine("Eleman sayısı : {0}",koleksiyon.Count);
   
}


