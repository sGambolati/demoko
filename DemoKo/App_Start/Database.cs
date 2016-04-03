using DemoKo.Models;
using DemoKo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DemoKo
{
    public static class DatabaseSetup
    {
        public static void SetUp()
        {
            SetUpPokemons();
        }

        private static void SetUpPokemons()
        { 
            var pokemons = new Repository<Pokemon>();

            pokemons.Add(new Pokemon() { 
                Name = "Bulbasaur",
                Type = "Planta",
                Number = 1,
                Descripcion = "Bulbasaur can be seen napping in bright sunlight. There is a seed on its back. By soaking up the sun's rays, the seed grows progressively larger.",
                Moves = new List<string>() { "Razor Leaf", "Solar Beam" },
            });

            pokemons.Add(new Pokemon()
            {
                Name = "Charmander",
                Type = "Fuego",
                Number = 4,
                Descripcion = "The flame that burns at the tip of its tail is an indication of its emotions. The flame wavers when Charmander is enjoying itself. If the Pokémon becomes enraged, the flame burns fiercely.",
                Moves = new List<string>() { "Ember", "Growl" },
            });

            pokemons.Add(new Pokemon()
            {
                Name = "Squirtle",
                Type = "Agua",
                Number = 7,
                Descripcion = "Squirtle's shell is not merely used for protection. The shell's rounded shape and the grooves on its surface help minimize resistance in water, enabling this Pokémon to swim at high speeds.",
                Moves = new List<string>() { "Bubbles", "Scratch" },
            });

            pokemons.Add(new Pokemon()
            {
                Name = "Pikachu",
                Type = "Electrico",
                Number = 25,
                Descripcion = "Whenever Pikachu comes across something new, it blasts it with a jolt of electricity. If you come across a blackened berry, it's evidence that this Pokémon mistook the intensity of its charge.",
                Moves = new List<string>() { "Thunderbolt", "Quick Attack" },
            });

            pokemons.Add(new Pokemon()
            {
                Name = "Nintales",
                Type = "Fuego",
                Number = 38,
                Descripcion = "Ninetales casts a sinister light from its bright red eyes to gain total control over its foe's mind. This Pokémon is said to live for a thousand years.",
                Moves = new List<string>() { "Ember", "Fire Blast" },
            });

            pokemons.Add(new Pokemon()
            {
                Name = "Kyogre",
                Type = "Agua",
                Number = 382,
                Descripcion = "Through Primal Reversion and with nature's full power, it will take back its true form. It can summon storms that cause the sea levels to rise.",
                Moves = new List<string>() { "Water Pump", "Surf" },
            });

            pokemons.Add(new Pokemon()
            {
                Name = "Gardevoir",
                Type = "Hada",
                Number = 282,
                Descripcion = "Gardevoir has the ability to read the future. If it senses impending danger to its Trainer, this Pokémon is said to unleash its psychokinetic energy at full power.",
                Moves = new List<string>() { "Charm", "Confusion" },
            });
        }
    }
}
