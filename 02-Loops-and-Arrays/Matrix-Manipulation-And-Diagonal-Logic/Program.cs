// See https://aka.ms/new-console-template for more information




// Multi-Dimensional Array (Matrix) Practice
// No matter how much we scale this matrix, the underlying logic will work perfectly.

double[,] matris = new double[,] {
    { 1, 2, 3 },
    { 2, 3, 4 } ,
    { 3, 4, 5 } };

double toplam = 0;

for (int i = 0;i<matris.GetLength(0);i++)
{
    for (int j = 0;j<matris.GetLength(1);j++)
    {
        if(i==j)
        {
            matris[i, j] = -1;  //Burada diyagonal eleman dediğimiz elemanları belli etmek için -1'e eşitledik.
        }
        if (matris[i,j]%2 == 0)
        {
            matris[i, j] = 0;    //Burada da 2 ile bölümünden kalan sıfır olan elemanları , yani çift sayıları 0'a eşitledik.
        }
        toplam += matris[i, j];   //Bu da dizideki sayıların toplamını bulmak için yazdığımız koddur.
        Console.Write($"{matris[i, j],5}");
    }
    Console.WriteLine();  // Bir satır boşluk için kullanıldı.
}
Console.WriteLine();  //Bir satır boşluk için kullanıldı.
Console.WriteLine($"Toplam : {toplam}");

Console.ReadKey();




