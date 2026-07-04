// See https://aka.ms/new-console-template for more information




int rowCount;

// bool.TryParse başarısız olduğu sürece (başına ! koyarak 'değilse' yapıyoruz) bu döngü dönecek
Console.Write("Üçgenin satır sayısını giriniz: ");
while (!int.TryParse(Console.ReadLine(), out rowCount) || rowCount <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red; // Hatayı kırmızı yazdıralım, havalı dursun
    Console.WriteLine("Hatalı giriş! Lütfen pozitif bir tam sayı giriniz.");
    Console.ResetColor(); // Rengi eski haline getirelim

    Console.Write("Tekrar deneyin: ");
}

// Döngüden çıkabildiyse, elimizde kesinlikle doğru ve pozitif bir rowCount var demektir!
Console.WriteLine("\n--- Üçgen Çiziliyor ---\n");

for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(" * ");
    }
    Console.WriteLine();
}

Console.ReadKey();



