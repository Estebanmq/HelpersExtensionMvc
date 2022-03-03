using HelpersExtensionMvc.Extensions;
using HelpersExtensionMvc.Helpers;
using HelpersExtensionMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpersExtensionMvc.Controllers
{
    public class TiendaController : Controller
    {
        public IActionResult TiendaHelperView()
        {
            Tienda tienda = new Tienda 
            { 
                NombreTienda = "Teclamania", 
                StockDisponible = 50, 
                Abierta = true 
            };

            string datostienda = HelperTienda.GetInfoTienda(tienda);
            ViewBag.DatosTienda = datostienda;
            String textoformateado = datostienda.TransformarTexto();
            System.Diagnostics.Debug.WriteLine(textoformateado);
            return View();
        }
    }
}
