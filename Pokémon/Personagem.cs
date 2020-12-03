namespace OrientacaoObjeto
{
    public class Pokemon
    {
        public string nome;
        public string tipo;
        public int nivel;
        public int vida = 100;

        public int Atacar1(){
            return 100;
        }
        public int Atacar2(){
            return 20;
        }
        public int Defender(int ataque){
            this.vida = this.vida - ataque;
            return this.vida = this.vida - ataque;
        }
    }
}