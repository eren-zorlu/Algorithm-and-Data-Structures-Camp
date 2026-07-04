// See https://aka.ms/new-console-template for more information


Console.WriteLine("Başlangıç sayisini giriniz : ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bitiş sayisini giriniz : ");
int endNumber = Convert.ToInt32(Console.ReadLine());

if (startNumber > endNumber)
{
    int temp = startNumber;
    startNumber = endNumber;
    endNumber = temp;
}

for (int i = startNumber; i <= endNumber ; i++)
{
    if (i % 3 == 0)  
    {
        continue;
    }
    Console.Write($"{i,3}");
}
Console.WriteLine();

 


