using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokedex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomePokemon =
            {
                "pikachu",
                "bulbasaur",
                "charmander",
                "squirtle",
                "zubat",
                "meowth",
                "psyduck",
                "poliwag",
                "machop",
                "poliwhirl",


            };

            string[] tipoPokemon = {
                "elétrico",
            "planta",
                "fogo",
                "água",
                "venenoso",
                "normal",
                "água",
                "água",
                "lutador",
                "água"
            };
            string[] pesoPokemon = {
                "6kg",
                "6,9kg",
                "8,5kg",
                "9kg",
                "7,5kg",
                "4kg",
                "19,6kg",
                "12,4kg",
                "19,5kg",
                "20kg"
            };
            string[] alturaPokemon = {
                "0,4m",
                "0,7m",
                "0,6m",
                "0,5m",
                "0,8m",
                "0,4m",
                "0,8m",
                "1m",
                "0,8m",
                "1,3m"
            };
            int[] numeroPokemon = {
                25,
                1,
                4,
                7,
                41,
                52,
                54,
                60,
                56,
                61,
            };
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n listagem de pokemons");
            Console.ResetColor();
            for (int i = 0; i < nomePokemon.Length; i++)
            {
                Console.WriteLine($"\nNome: {nomePokemon[i]}");
                Console.WriteLine($"Tipo: {tipoPokemon[i]}");
                Console.WriteLine($"Peso: {pesoPokemon[i]}");
                Console.WriteLine($"Altura: {alturaPokemon[i]}");
                Console.WriteLine($"Número: {numeroPokemon[i]}");
            }
        }
    }
}
