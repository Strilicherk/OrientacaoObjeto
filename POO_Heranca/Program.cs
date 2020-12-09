using System;
using POO_Heranca.Classes;
namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciando a subclasse PessoaFisica
            PessoaFisica pf = new PessoaFisica();
    

            // atribuimos um cpf ao objeto
            pf.cpf = "000.000.000-00";
            pf.nome = "Paulo";

            //Chamando método
            Console.WriteLine(pf.DarBoasVindas(pf.nome));

            //Método de validação da subclasse
            Console.WriteLine(pf.ValidarCPF(pf.cpf));
            Console.Write($"{pf.cpf}");
        }
    }
}
