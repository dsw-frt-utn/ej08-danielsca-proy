using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{

    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            var resumen = new // Clase anonima
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = quantity > 0 ? quantity * unitPrice : 0m //Si quantity es menor o igual a 0, el total es 0, si no, se calcula como quantity * unitPrice.
            };

            return $"{resumen.Code}-{resumen.Description}-{resumen.Total}"; //Retorno solicitado
        }
    }
}
