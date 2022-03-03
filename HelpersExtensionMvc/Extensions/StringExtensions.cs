using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpersExtensionMvc.Extensions
{
    public static class StringExtensions
    {

        public static String TransformarTexto
            (this String texto)
        {
            string textoformateado = texto.Replace(" ", "").ToUpper();
            return textoformateado;
        }

    }
}
