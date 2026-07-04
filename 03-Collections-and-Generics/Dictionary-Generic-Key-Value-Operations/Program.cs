// See https://aka.ms/new-console-template for more information



// Initializing a Generic Dictionary (Key-Value structure with full type safety)

var telefonkodlari = new Dictionary<int, string>()
{    
    {332,"Konya" },
    {424,"Elazığ" },
    {466,"Art"}
};

telefonkodlari.Add(322, "Adana");
telefonkodlari.Add(212, "İstanbul");
telefonkodlari.Add(216, "İstanbul");

telefonkodlari[466] = "Artvin"; 

foreach (var t in telefonkodlari)
{
    Console.WriteLine(t);
}

Console.ReadKey();
Console.WriteLine();


if (!telefonkodlari.ContainsKey(312))
{
    Console.WriteLine("\nAnkara'nın kod bilgisi tanımlı değil");
    telefonkodlari.Add(312, "Ankara");
    Console.WriteLine("Yeni kod eklendi ve aşağıdadır\n.");
}

foreach (var a in telefonkodlari)
{
    Console.WriteLine(a);
}

Console.WriteLine();
Console.ReadKey();


if(!telefonkodlari.ContainsValue("Malatya"))
{
    Console.WriteLine("\nMalatyanın kod bilgisi tanımlı değil.");
    telefonkodlari.Add(422, "Malatya");
    Console.WriteLine("Yeni kod eklendi ve aşağıdadır.");
}

foreach (var s in telefonkodlari)
{
    Console.WriteLine(s);
}

Console.WriteLine();
Console.ReadKey();



telefonkodlari.Remove(322);
telefonkodlari.Remove(312);
Console.WriteLine("\nAnkara ve Adana'yı Sözlükten siliyoruz....!!!!!");
foreach (var y in telefonkodlari)
{
    Console.WriteLine(y);
}

Console.ReadKey();

