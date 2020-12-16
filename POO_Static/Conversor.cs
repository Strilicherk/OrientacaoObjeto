namespace POO_Static.obj
{
    public class Conversor
    {
        private static float cotacaoDolar = 5.10f;
        private static float valorUsuario;

        public static float ConverterDolarParaReal(){
            return valorUsuario * cotacaoDolar;
        }
        public static float ConverterRealParaDolar(){
            return valorUsuario / cotacaoDolar;
        }
    }
}