// See https://aka.ms/new-console-template for more information


// Reference Type Logic and Lambda Expressions Practice

var cities = new List<string>() {"Ankara","İstanbul","Van","Samsun","Ordu" };

// Iterating and printing list elements using Lambda Expressions

cities.ForEach(s => Console.WriteLine(s));

Console.WriteLine(new string('-',50));  // Creates a separator line with 50 dashes

// IMPORTANT: We are NOT creating a new list here. 
// 'provinces' just references (points to) the exact same memory address as 'cities'.
var provinces = cities;
provinces.ForEach(i => Console.WriteLine(i));

Console.WriteLine();

cities.Add("Sinop");
cities.ForEach(s => Console.WriteLine(s));
Console.WriteLine();
provinces.ForEach(i => Console.WriteLine(i));
Console.WriteLine();

//İller listesinden bir eleman silindiğinde o elemanın sehirler listesinden de silinmesi olayı

provinces.Remove("Ankara");
provinces.ForEach(i => Console.WriteLine(i));

Console.WriteLine();
cities.ForEach(s => Console.WriteLine(s));

Console.ReadKey();

