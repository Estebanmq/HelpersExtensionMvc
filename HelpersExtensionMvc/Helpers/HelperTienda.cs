using HelpersExtensionMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpersExtensionMvc.Helpers
{
    public class HelperTienda
    {

        public static String GetInfoTienda(Tienda tienda)
        {
            String textoAbiertaCerrada = "";
            if (tienda.Abierta)
                textoAbiertaCerrada = "Tienda abierta";
            else
                textoAbiertaCerrada = "Tienda cerrada";

            String infotienda = "Nombre de la tienda: " + tienda.NombreTienda + " # Stock Disponible: " + tienda.StockDisponible + " # Estado: " + textoAbiertaCerrada;

            return infotienda;
        }

    }
}
