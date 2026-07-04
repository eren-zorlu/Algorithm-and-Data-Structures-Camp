// See https://aka.ms/new-console-template for more information




using System.Collections;

// Initializing a SortedList to model a book's Table of Contents
// Page numbers are used as Keys so the list automatically sorts the chapters chronologically

var bookContents = new SortedList();
bookContents.Add(1, "Önsöz");
bookContents.Add(50, "Değişkenler");
bookContents.Add(40, "Operatörler");
bookContents.Add(60, "Döngüler");
bookContents.Add(45, "İlişkisel Operatörler");

Console.WriteLine("İçindekiler");
Console.WriteLine(new string('-',25));
Console.WriteLine($"  {"Konular",-30} {"Sayfa Numaraları",8}");

// Thanks to SortedList, chapters are automatically printed in order of their page numbers
foreach (DictionaryEntry item in bookContents)
{
    Console.WriteLine($" {item.Value,-30}  {item.Key,8}  ");
}

Console.ReadKey();

