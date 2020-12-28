namespace POO_Static.obj
{
    public static class Conversor
    {
        public static float cotacaoDolar;
        public static float valorUsuario;

        public static float ConverterDolarParaReal(){
            return valorUsuario * cotacaoDolar;
        }
        public static float ConverterRealParaDolar(){
            return valorUsuario / cotacaoDolar;
        }
    }
}