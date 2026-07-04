// See https://aka.ms/new-console-template for more information



// Application: Exploring SortedSet mechanics - ensuring uniqueness and automatic sorting

var list = new SortedSet<string>();

if(list.Add("Mehmet"))
{
    Console.WriteLine("Mehmet eklendi.");
}
else
{
    Console.WriteLine("Ekleme başarısız");
}

Console.WriteLine("{0}", list.Add("Ahmet") == true ? "Ahmet eklendi" : "Ekleme başarısız");

list.Add("Şule");
list.Add("Neslihan");
list.Add("Fahrettin");
list.Add("Fatih");

Console.WriteLine("\nİsimler listesi");
foreach(string i in list)
{
    Console.WriteLine(i);
}
Console.WriteLine("Eleman Sayısı : {0,3}\n",list.Count);


list.Remove("Şule");
Console.WriteLine("\nŞuleyi siliyoruz....");
foreach (var a in list)
{
    Console.WriteLine(a);
}
Console.WriteLine("Yeni Eleman Sayısı : {0,3}",list.Count);


list.RemoveWhere(deger => deger.Contains("a")); 
Console.WriteLine("\nİçinde a bulunan elemanları siliyoruz....");
foreach(var a in list)
{
    Console.WriteLine(a);
}
Console.WriteLine("En yeni eleman sayımız : {0,3}",list.Count);

Console.WriteLine("Program bitti ..... Hayırlı olsun.");
Console.ReadKey();


