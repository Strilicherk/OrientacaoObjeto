using System;
using POO_Abstracao.Classes;

namespace POO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamento

            Boleto boleto = new Boleto();

            boleto.Cancelar();
        }
    }
}
