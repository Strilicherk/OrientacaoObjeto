namespace POO_Abstracao.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;

        public string SalvarCartao(){
            return "";
        }
        protected abstract void Pagar();
    }
}