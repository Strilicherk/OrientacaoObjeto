namespace Encapsulamento.Classes
{
    public class Cartao
    {
        private string numero;
        public string Numero{
            get{return numero;}
            set{numero = value;}
        }
        public string NomeTitular{
            get{return nomeTitular;}
            set{nomeTitular = value;}
        }
        private string nomeTitular;
        private string bandeira;
        public string Bandeira{
            get{return bandeira;}
            set{bandeira=value;}
        }
        protected string token = "qwertyui";

        public string Token{
            get{return token;}
        }
        private string cvv{get;set;}
        protected float limite = 5000;
        public float Limite{get;set;}

        //Métodos
        public string RegistrarCompra(bool validado){
            return "";
        }
    }
}