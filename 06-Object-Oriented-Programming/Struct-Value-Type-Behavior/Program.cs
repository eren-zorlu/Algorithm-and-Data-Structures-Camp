// See https://aka.ms/new-console-template for more information

// Struct Application: Value Type Behavior Verification

var n1 = new Nokta(3,4);
Console.WriteLine($"n1 : {n1}");
n1.Degistir();
Console.WriteLine($"n1 : {n1}");
// Value type assignment: creates a completely independent copy in Stack memory
var n2 = n1;
Console.WriteLine($"n2 : {n2}");
// Modifying point2 does NOT affect point1
n2.X = -1 * n2.X ;
n2.Y = -1 * n2.Y ;
// Modifying point1 does NOT affect point2
n1.X = 10 * n1.X;
n1.Y = 10 * n1.Y;
Console.WriteLine($"n1 : {n1}");
Console.WriteLine($"n2 : {n2}");

// As verified above, changes to value types are isolated to their respective variables.
Console.ReadKey();

struct Nokta
{
    public int X { get; set; }
    public int Y { get; set; }

   
    public override string ToString()
    {
        return $"{X},{Y}";
    }

    public Nokta(int x,int y)
    {
            X = x;
            Y = y ;
    }


    public void SetOrigin()
    {
        X = 0;
        Y = 0;
    }

    public void Degistir()
    {
        var gecici = X;
        X = Y;
        Y = gecici;
    }
    

}

