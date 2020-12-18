using System;
using POO_Abstracao.Classes;

namespace POO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamento
            Console.WriteLine("Digite o valor da compra:");
            float valorDaCompra = float.Parse(Console.ReadLine());

            Console.WriteLine("Selecione um método de pagamento: ");
            Console.WriteLine("1- Boleto");
            Console.WriteLine("2 - Cartão");
            // Console.WriteLine("0 - Sair ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    //boleto
                    Boleto boleto = new Boleto();
                    boleto.Registrar();
                    boleto.Valor = valorDaCompra;
                    boleto.Data = DateTime.Now;

                    boleto.GerarBoleto();
                    break;
                case 2:
                    //Cartão
                    Console.WriteLine("Selecione uma opção");
                    Console.WriteLine("1 - Crédito");
                    Console.WriteLine("2 - Débito");
                    int tipo = int.Parse(Console.ReadLine());
                    switch (tipo)
                    {
                        case 1:
                            //Crédito
                            break;
                        case 2:
                            //Débito
                            break;
                        default:
                            break;
                    }
                    
                    break;
                default:
                    break;
            }
                
        }
    }
}
