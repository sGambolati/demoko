using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoKo.Controllers
{
    public class PokemonController : Controller
    {
        //
        // GET: /Pokemon/

        // TODO: Agregar descricion.
        // TODO: Usar el viewmodel Pokemon.cs
        // TODO: Propiedad calculada con el numero, traer el asset.

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}
