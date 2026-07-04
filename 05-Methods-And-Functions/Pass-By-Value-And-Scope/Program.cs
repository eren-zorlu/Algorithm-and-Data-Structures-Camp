// See https://aka.ms/new-console-template for more information


// Variable swapping and scope logic (Pass by Value)

int x = 10;
int y = 20;
Console.WriteLine($"{x},{y}");
degistir(x, y);

// It still prints 10,20 because integers are value types.
// The method received a copy of the values, so the original variables remain unchanged.

Console.WriteLine($"{x},{y}"); 

Console.ReadKey();


void degistir(int a, int b)
{
    int gecici = a;
    a = b;
    b = gecici;
    Console.WriteLine($"{a},{b}");
}
Console.ReadKey();




// (Pass by Reference)

int Number1 = 50;
int Number2 = 90;
Console.WriteLine($"Before: {Number1},{Number2}"); // 10,20

// 'ref' keyword passes the actual memory addresses
SwapNumbersWithRef(ref Number1, ref Number2);

Console.WriteLine($"After: {Number1},{Number2}"); // 20,10 -> Artık orijinal değerler kalıcı olarak yer değiştirdi!

void SwapNumbersWithRef(ref int a, ref int b)
{
    int temporary = a;
    a = b;
    b = temporary;
}
