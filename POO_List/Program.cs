using System;
using System.Collections.Generic;
using Lista_de_Objetos.Classes;

namespace Lista_de_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Produtos> produtos = new List<Produtos>();
 

            Produtos[] arrayProdutos = {};

            produtos.Add(new Produtos(1, "banana", 58f));
            produtos.Add(new Produtos(2, "maça", 26f));
            produtos.Add(new Produtos(3, "goiaba", 256f));
            
            Produtos p1 = new Produtos();
            p1.Nome = "Abacaxi";
            p1.Codigo = 4022;
            p1.Preco = 2;

            produtos.Add(p1);


        }
    }
}