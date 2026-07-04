// See https://aka.ms/new-console-template for more information


// Application: Mapping unique IDs to custom Objects using Generic Dictionary

var personelListesi = new Dictionary<int, Personel>()
{
    {110,new Personel("Mehmet","sonsoz",7500) },
    {120,new Personel("Eren","Zorlu",9000) }
};
personelListesi.Add(100, new Personel("Zeynep", "Coskun", 5000));
foreach (var p in personelListesi)
{
    Console.WriteLine(p);
}





Console.ReadKey();


public class Personel
{
    public Personel(string adi, string soyadi, decimal maas)
    {
        Adi = adi;
        Soyadi = soyadi;
        Maas = maas;
    }

    public int sicilNo { get; set; }
    public string Adi {  get; set; }
    public string Soyadi { get; set; }
    public decimal Maas {  get; set; }

    public override string ToString()
    {
        return $" {Adi,-10} {Soyadi,-15} {Maas ,- 10}";
    }
}


