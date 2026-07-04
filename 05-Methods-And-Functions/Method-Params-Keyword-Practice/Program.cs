// See https://aka.ms/new-console-template for more information



// Advanced method example using 'params'
double toplam = SeriToplami(5.54, 15.0, 25.5,5);
Console.WriteLine($"{toplam,5}");
Console.ReadKey();

// 'params' keyword allows passing a variable number of double arguments into a single array
double SeriToplami(params double[] seri) // params : Dışardan fonksiyona gelecek tüm sayıları seri adlı diziye eklemek için kullandık.
{
    double toplam = 0;
    foreach (double s in seri)
    {
        toplam += s;
    }
    return toplam;
}

