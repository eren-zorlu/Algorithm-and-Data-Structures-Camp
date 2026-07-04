// See https://aka.ms/new-console-template for more information




int startNumber = Convert.ToInt32(Console.ReadLine());
int endNumber = Convert.ToInt32(Console.ReadLine());


for (int i = startNumber; i <= endNumber; i++)  // Örn : 10--20 arası
{
    Console.WriteLine($"{i,3} ");
}

for (int i = startNumber; i >= endNumber; i--)  // Örn : 15--10 arası 
{
    Console.WriteLine($"{i,3}");
}

