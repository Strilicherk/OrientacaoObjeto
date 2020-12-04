using System;
using aulaPOOcelular;
namespace aulaPOOcelular.classes
{
    public class celular
    {
        public string info;
        public string menu;
        public bool ligado;
        public bool desligado;
        public bool mensagens;
        public bool ligacoes;

         public void mensagem(bool mensagem){
                Console.WriteLine("Para quem você deseja enviar uma mensagem?");
                string quem = Console.ReadLine();
                Console.WriteLine("Escreva a mensagem: ");
                string mensagens = Console.ReadLine();
                Console.WriteLine($"Sua mensagem foi enviada para {quem}!"); 
        }
        public void fazerLigacao(bool ligacao){
            Console.WriteLine("Para quem?");
            string quem2 = Console.ReadLine();
            Console.Write("Ligando");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"Ligação não atendida");
        }
        public void informaçõesCelular(string info){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----Infos do aparelho-----");
            Console.ResetColor();
            Console.WriteLine("Modelo: iPhone 11 (iOS 14)");
            Console.WriteLine("Cor: Preto");
            Console.WriteLine("Tamanho: 6,5 polegadas");
        }
        public void celularLigado(bool ligado){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Inicializando");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("*O celular está ligado*");
            Console.ResetColor();
        }
        public void celularDesligado(bool desligado){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Desligando");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".\n");
            System.Threading.Thread.Sleep(1000);
            Console.ResetColor();
        }
        public void menuPrincipal(string menu){
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--------Menu--------");
            Console.WriteLine("[1] Desligar");
            Console.WriteLine("[2] Enviar Mensagem");
            Console.WriteLine("[3] Fazer Ligação");      
            Console.WriteLine("[4] Informações Sobre o Celular");
            Console.Write("Selecione uma Opção: ");
            Console.ResetColor();
        }
    }
}
       