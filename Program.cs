﻿using System;


void Soma()

{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());


    Console.WriteLine("");

    float resultado = v1 + v2;
    Console.WriteLine($"O resultado da soma é {resultado}");
    Console.ReadKey();
}

void Subtracao();
{
    Console.Clear();


    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 - v2;
    Console.WriteLine($"O resultado da subtração é  {resultado}");
    Console.ReadKey();
}

Subtracao();