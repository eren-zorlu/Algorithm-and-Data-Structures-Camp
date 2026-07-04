// See https://aka.ms/new-console-template for more information


using System.Collections.Generic;

//Application: Doubly Linked List Mechanics using a Route Navigation Scenario
var sehirler =  new LinkedList<string>();

//Eleman ekleme
sehirler.AddFirst("Ordu");
sehirler.AddFirst("Trabzon"); 
sehirler.AddLast("İstanbul");

sehirler.AddAfter(sehirler.Find("Ordu"), "Samsun"); 
sehirler.AddBefore(sehirler.First.Next.Next, "Giresun"); 

sehirler.AddAfter(sehirler.Last.Previous, "Sinop");

sehirler.AddAfter(sehirler.Find("Sinop"), "Zonguldak");

Console.WriteLine();
Console.WriteLine($"Gidiş Güzergahı ");

var eleman = sehirler.First;
while(eleman != null)
{
    Console.WriteLine(eleman.Value );
    eleman = eleman.Next;
}

Console.WriteLine();
Console.WriteLine("Dönüş güzergahı");
Console.WriteLine();

var gecici = sehirler.Last;
while(gecici != null)
{
    Console.WriteLine(gecici.Value);
    gecici = gecici.Previous;
}

Console.ReadKey();


