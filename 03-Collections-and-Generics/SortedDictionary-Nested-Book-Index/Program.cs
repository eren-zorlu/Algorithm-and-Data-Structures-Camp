// See https://aka.ms/new-console-template for more information



// Application: Modeling a book's back-of-the-book keyword index using a SortedDictionary holding a nested List


var kitapİndeks = new SortedDictionary<string,List<int>>()
{
    {"HTML", new List<int>(){8,10,12} },
    {"CSS",new List<int>(){70,80,90} },
    {"jQuery", new List<int>(){3,5,15} },
    {"SQL", new List<int>(){70,80} }
};
kitapİndeks.Add("FTP", new List<int>() { 3, 5, 7 });
kitapİndeks.Add("ASP.NET", new List<int>() { 50, 60 }); 

foreach (var kavram in kitapİndeks)
{
    Console.WriteLine(kavram.Key);
    foreach (int s in kavram.Value)
    {
        Console.WriteLine($"\t > {s,-5} pp");
    }

}

Console.ReadKey();

