using System;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classes estáticas não podem ser instanciadas

            // Em que momento usamos classes estáticas?
            // Quando precisarmos de uma solução que pode servir
            // para qualquer tipo de aplicação

            // Em que momento não usamos classes estáticas?
            // Quando houver objetos ou classes que são especificas de
            // um tipo de aplicação
            Console.WriteLine(Math.Pow(2,5) );

            Console.WriteLine("Digite um valor :");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());

            Console.WriteLine(Conversor.ConverterDolarParaReal());

            Console.WriteLine(Conversor.ConverterRealParaDolar());

            // este método tbm em que ser static na sua declaração
            Testar();
        }

        static void Testar(){

        }
    }
}
