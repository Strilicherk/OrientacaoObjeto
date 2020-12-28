using System;
using POO_Static.obj;
namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classes estáticas não podem ser instanciadas

            // Em que momento usamos classes estáticas?
            // Quando precisarmos de uma solução universal


            // Em que momento não usamos classes estáticas?
            // Quando houver objetos ou classes que são especificas de
            // um tipo de aplicação

            Console.WriteLine("Digite um valor em R$: ");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());
            Console.WriteLine("Quanto está valendo a moeda dólar nesse momento?");
            Conversor.cotacaoDolar = float.Parse(Console.ReadLine());

            Console.WriteLine($"R${Conversor.valorUsuario} é igual a: {Conversor.ConverterRealParaDolar()}$");

            // este método tbm em que ser static na sua declaração
            Testar();
        }

        static void Testar(){

        }
    }
}
