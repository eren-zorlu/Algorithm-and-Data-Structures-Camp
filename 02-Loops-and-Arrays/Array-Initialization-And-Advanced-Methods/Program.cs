// See https://aka.ms/new-console-template for more information


using System.Collections;

int[] sayilar = new int[] {12,23,13,4,53,18,23,44,55,6,34,19};
var numbers = Array.CreateInstance(typeof(int), sayilar.Length);
var arr = new ArrayList(sayilar);

sayilar.CopyTo(numbers,0);

Array.Sort(sayilar);
Array.Sort(numbers);
Array.Clear(sayilar,2,2);

Console.WriteLine(Array.IndexOf(sayilar, 44));
arr.Sort();



for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Sayilar[{i}] = {sayilar[i],3}     numbers[{i}] = {numbers.GetValue(i),3}    arr[{i}] = {arr[i],3}");
}

Console.ReadKey();


