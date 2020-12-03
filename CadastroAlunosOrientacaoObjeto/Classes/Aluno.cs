using System;

namespace CadastroAlunosOrientaçãoObjeto.Classes
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public string rg;
        public int idade;
        public double mediaFinal;
        public double valorDaMensalidade;
        public bool bolsista;

        public void VerMediaFinal(){
            Console.WriteLine($"A média do aluno é: {mediaFinal}");
        }
        public void VerMensalidade(bool temBolsa, double mensalidade){
            if(temBolsa == true){
                Console.WriteLine($"Esse aluno é bolsista?");
                Console.WriteLine($"Mensalidade: {mensalidade}");

                Console.WriteLine($"Mensalidade com desconto: {0.7 * mensalidade}");
            } else {
                Console.WriteLine("Esse aluno NÃO é bolsista");
                Console.WriteLine($"Mensalidade: {mensalidade}");

                Console.WriteLine($"Mensalidade: {mensalidade}");
            }
        }
    }
}