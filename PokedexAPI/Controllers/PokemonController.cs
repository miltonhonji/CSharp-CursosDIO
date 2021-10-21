using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokedexAPI.Classes;

namespace PokedexAPI.Controllers
{   
    [ApiController]
    [Route ("api/pokemons")]
    public class PokemonController : ControllerBase
    {
        private readonly ILogger<PokemonController> _logger;

        public PokemonController(ILogger<PokemonController> logger)
        {
            _logger = logger;
        }

        //GET: api/<PokemonController>
        [HttpGet]
        public List<Pokemon> Get()
        {
            StreamReader r = new StreamReader(@"Dados\dados.json");
            string json = r.ReadToEnd();
            List<Pokemon> pokemons = JsonSerializer.Deserialize<List<Pokemon>>(json);
            return pokemons;
        }

        //GET api/<PokemonControllers>/
        [HttpGet("{id}")]
        public Pokemon Get(int id)
        {
            StreamReader r = new StreamReader(@"Dados\dados.json");
            string json = r.ReadToEnd();
            List<Pokemon> pokemons = JsonSerializer.Deserialize<List<Pokemon>>(json);
            var pokemon = pokemons.Where(p => p.Numero == id).SingleOrDefault();
            return pokemon;
        }

    }
}