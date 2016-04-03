using DemoKo.Models;
using DemoKo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoKo.Controllers
{
    public class DataController : Controller
    {
        private Repository<Pokemon> PokemonRepository { get; set; }

        public DataController()
        {
            this.PokemonRepository = new Repository<Pokemon>();
        }

        [HttpGet]
        public JsonResult ListAllPokemon()
        {
            var result = this.PokemonRepository.List();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetPokemon(int id)
        {
            var result = this.PokemonRepository.Get(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
