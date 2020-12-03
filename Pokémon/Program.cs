using System;

namespace OrientacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamento

            Pokemon pokemon1 = new Pokemon();
            pokemon1.nome = "Charizard";
            pokemon1.tipo = "Fogo/Voo";
            pokemon1.nivel = 32;

            Pokemon pokemon2 = new Pokemon();
            pokemon2.nome = "Mudkip";
            pokemon2.tipo = "Água/Terra";
            pokemon2.nivel = 50;

            Console.Clear();
            Console.WriteLine($"Partida {pokemon1.nome} VS {pokemon2.nome}");
            Console.WriteLine($"Pokémon 1 'Tipo': {pokemon1.tipo} || Pokémon 2 'Tipo': {pokemon2.tipo}");
            Console.WriteLine($"Pokémon 1 'Nível': {pokemon1.nivel} || Pokémon 2 'Nível': {pokemon2.nivel}");

            //Iniciando Luta
            int vidaDoPokemon1 = pokemon1.Defender(pokemon1.Atacar1());
            if (vidaDoPokemon1<=0)
            {
                Console.WriteLine($"O Pokémon {pokemon1.nome} foi derrotado");
            }
            else
            {
                Console.WriteLine($"Depois do ataque {pokemon1.nome} ficou com {pokemon2.vida}");
            }
        }
    }
}
