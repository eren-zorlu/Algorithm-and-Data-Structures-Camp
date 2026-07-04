// See https://aka.ms/new-console-template for more information



using System.Collections;
using System.Text;

Console.WriteLine("Enter a title: ");
string title = Console.ReadLine();

// Convert the entire string to lowercase to prevent casing mismatches
title = title.ToLower();

// Initializing a Hashtable mapping non-URL-friendly characters to safe alternatives
var characterMap = new Hashtable()
{
    {'ç','c' },
    {'ı','i' },
    {'ö','o' },
    {'ü','u' },
    {' ','-' },
    {'\'','-'},
    {'ğ','g' },
    {'.','-' },
    {'?','-' },

};
// Iterating through the map and replacing each invalid key character with its safe value
foreach (DictionaryEntry item in characterMap)
{
    title = title.Replace((char)item.Key, (char)item.Value);
}


Console.WriteLine(title);

var stringBuilder = new StringBuilder(title);

foreach (DictionaryEntry entry in characterMap)
{
    stringBuilder.Replace((char)entry.Key, (char)entry.Value);
}

string optimizedTitle = stringBuilder.ToString();

Console.ReadKey();


