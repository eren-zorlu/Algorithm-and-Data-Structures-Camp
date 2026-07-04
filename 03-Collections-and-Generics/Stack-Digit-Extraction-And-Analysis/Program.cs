// See https://aka.ms/new-console-template for more information



Console.WriteLine("Lütfen bir sayi giriniz : ");
int sayi = Convert.ToInt32(Console.ReadLine());

//Doğrudan kullanıcının sayı girdiğini varsayarsak
var sayiYigini = new Stack<int>();

//Kullanıcının girdiği sayi ile ilgili işlem yapalım
while (sayi>0)
{
    int k = sayi % 10; //Burda sayinin 10 ile bölümünden kalanı bularak son rakamını bulduk ve hemen aşağıda yığınımıza ekledik.
    sayiYigini.Push(k);
    sayi = sayi / 10; //Bu işlemden sonra yeni sayimiz kaç olucak en son rakami silicek ve baştakiler kalıcak
}

int i = 0;
int n = sayiYigini.Count-1;
foreach (var s in sayiYigini)
{
    Console.WriteLine($"\t{s,7} x {Math.Pow(10,n-i),7}\t  = {s*Math.Pow(10,n-i),7}");
    i++;
}

  //Programın amacı : Kullanıcının girdiği bir integer değerin sonundan 
  //başlayarak başa gelene kadar ekrana yazdırma işlemidir.

Console.ReadKey();


