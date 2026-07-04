// See https://aka.ms/new-console-template for more information


// Scenario 1: Initializing a struct and setting individual properties

student ogr = new student();
ogr.numara = 10;
ogr.Adi = "Eren";
ogr.Soyadi = "Zorlu";
ogr.Cinsiyet = true;


// Scenario 2: Alternative initialization using object initializer syntax
var ogr2 = new student
{
    numara = 20,
    Adi = "Fatma",
    Soyadi = "Dag",
    Cinsiyet = false
};

// Scenario 3: Alternative initialization using custom Constructors
var ogr3 = new student(30, "Mehmet", "Avşar", true);
var ogr4 = new student(40, "Asaf", "karlıdağ");

Console.WriteLine(ogr);
Console.WriteLine(ogr2);
Console.WriteLine(ogr3);
Console.WriteLine(ogr4);
Console.ReadKey();


// Struct declaration at the bottom of the file (Top-level statements structure)
struct student
{

    // Custom constructor with an optional parameter for gender
    public student(int Numara, string adi, string soyadi, bool cinsiyet = true)
    {
        numara = Numara;
        Adi = adi;
        Soyadi = soyadi;
        Cinsiyet = cinsiyet;
    }

    public int numara { get; set; } // İlk property(Özellik) tanımı
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public bool Cinsiyet { get; set; }

    // Overriding ToString() to format the console output neatly
    public override string ToString()
    {
        return $"{numara,-5}" +
            $" {Adi,-10}" +
            $" {Soyadi,-10}" +
            string.Format("{0,-8}", Cinsiyet == true ? "Bay" : "Bayan");
    }

}






