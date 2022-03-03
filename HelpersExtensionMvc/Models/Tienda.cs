using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpersExtensionMvc.Models
{
    public class Tienda
    {

        public String NombreTienda { get; set; }

        public int StockDisponible { get; set; }

        public bool Abierta { get; set; }

        public void AbrirTienda()
        {
            this.Abierta = true;
        }

        public void CerrarTienda()
        {
            this.Abierta = false;
        }
    }
}
