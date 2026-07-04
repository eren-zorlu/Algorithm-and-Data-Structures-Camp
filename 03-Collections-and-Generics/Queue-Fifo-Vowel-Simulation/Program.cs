// See https://aka.ms/new-console-template for more information



var sesliHarfler = new List<char>()
{
    'a', 'e', 'ı','i','o','ö','u','ü'
};


ConsoleKeyInfo secim;
var kuyruk = new Queue<char>();

foreach (char k in sesliHarfler)
{
    Console.WriteLine($" {k,-5} kuyruğa eklensin mi ? [e/h] ");
     secim = Console.ReadKey();
    Console.WriteLine();
    if(secim.Key == ConsoleKey.E)
    {
        kuyruk.Enqueue(k);
        Console.WriteLine($"\n{k,-5} kuyruğe eklendi.");
        Console.WriteLine($"Kuyruktaki eleman sayısı : {kuyruk.Count}");
        Console.WriteLine();
    }
      
}
Console.WriteLine();
Console.WriteLine("Kuyrukta elemanları kaldırılması işlemi için ESC tuşuna basın.");
secim = Console.ReadKey();
Console.WriteLine();

if (secim.Key == ConsoleKey.Escape)
{
    Console.WriteLine();

    while (kuyruk.Count > 0)
    {
        Console.WriteLine();
        Console.WriteLine($"{kuyruk.Peek(),5} kuyruktan çıkartılıyor.");
        Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıkartıldı.");
        Console.WriteLine($"Kuyruktaki eleman sayisi : {kuyruk.Count}");
    }

    Console.WriteLine("\nKuyruktan çıkarma işlemi tamamlandı..");
}

Console.WriteLine("Program bitti.😊");
Console.ReadKey();


