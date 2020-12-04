using System;
using aulaPOOcelular.classes;

namespace aulaPOOcelular
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Variáveis
            celular celular1 = new celular();
            string escolha; 
            string escolhaMenu;
                //Início do Código            
                Console.WriteLine("Deseja ligar o celular? Sim/Não");
                escolha = Console.ReadLine();

                if(escolha.ToLower() == "sim" ){
                    celular1.celularLigado(celular1.ligado);
                    do{
                        celular1.menuPrincipal(celular1.menu);
                        escolhaMenu = Console.ReadLine();
                        switch (escolhaMenu)
                        {
                            case "1":
                                default:
                                break;
                            case "2":
                                    celular1.mensagem(celular1.mensagens);
                                break;
                            case "3":
                                    celular1.fazerLigacao(celular1.ligacoes);
                                break;
                            case "4":
                                    celular1.informaçõesCelular(celular1.info);
                                break;
                        }
                    }while (!(escolhaMenu == "1"));
                celular1.celularDesligado(celular1.desligado);
            }
        }
    }
}