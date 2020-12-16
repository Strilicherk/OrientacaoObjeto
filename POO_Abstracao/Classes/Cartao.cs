namespace POO_Abstracao.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;

        public string SalvarCaratao(){
            return "";
        }
        public override string Desconto(int valor)
        {
            return "";
        }

        public override string Juros(int parcelas)
        {
            return "";
        }
    }
}