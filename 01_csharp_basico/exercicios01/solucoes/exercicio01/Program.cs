using System;

Console.Write("Digite número 1: ");
var a = int.Parse(Console.ReadLine());

Console.Write("Digite número 2: ");
var b = int.Parse(Console.ReadLine());

int greater;

if (a > b)
    greater = a;
else
    greater = b;

Console.WriteLine($"O maior número é {greater}");