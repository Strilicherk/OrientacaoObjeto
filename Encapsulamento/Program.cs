using System;
using Encapsulamento.Classes;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();
            m.NomeTitular = "Carlos Eduardo Tsukamoto";
            
            m.Numero = "123456789"; // SET

            Console.WriteLine($"O Titular {m.NomeTitular} - Token {m.Token}"); //GET
        }
    }
}
