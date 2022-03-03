﻿using System;

namespace Exercicio._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em R$: ");
            string valorDigitado = Console.ReadLine();
            decimal valorConvertido = 0.0m;
            decimal valorCambio = 0.1932m;

            decimal.TryParse(valorDigitado, out valorConvertido);

            decimal valorCambioConvertido = valorConvertido * valorCambio;

            Console.WriteLine($"valor em U${valorCambioConvertido}");
            Console.ReadLine();
        }
    }
}
