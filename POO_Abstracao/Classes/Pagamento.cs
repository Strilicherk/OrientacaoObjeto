using System;

namespace POO_Abstracao.Classes
{
    public abstract class Pagamentos
    {
        private DateTime data;
        protected float valor;

        public string Cancelar(){
            return $"Cancelamento feito em {data}";
        }

        public abstract string Desconto(float valor);


    }
}