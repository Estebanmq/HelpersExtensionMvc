using HelpersExtensionMvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpersExtensionMvc.Controllers
{
    public class ExtensionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(String texto)
        {
            String cadenaFormateada = texto.TransformarTexto();
            ViewBag.TextoFormateado = cadenaFormateada;
            return View(); 
        }

    }
}
