// See https://aka.ms/new-console-template for more information



var k = (char)Console.Read();  
if (char.IsDigit(k))            
{
    Console.WriteLine("Rakamdır!");
}
else if (char.IsLower(k))   
{
    Console.WriteLine("Küçük karakter");
}
else if (char.IsUpper(k))   
{
    Console.WriteLine("Buyuk karakter");
}
else
{
    Console.WriteLine("Bilinmeyen karakter");
}

    Console.WriteLine(k);


