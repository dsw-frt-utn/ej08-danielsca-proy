using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{

    internal class Sale // Clase padre
    {
        public virtual decimal CalculateTotal()
        {
            return 1000m;
        }
    }

    internal class RetailSale : Sale //Clase derivada
    {
        public override decimal CalculateTotal()
        {
            return base.CalculateTotal(); // Retorna el importe sin descuento
        }
    }

    internal class WholesaleSale : Sale //Clase derivada
    {
        public override decimal CalculateTotal()
        {
            decimal total = base.CalculateTotal();
            return total * 0.9m; // Aplica un descuento del 10%
        }
    }

    internal class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale) 
        {
            return sale.CalculateTotal(); // Llama al método CalculateTotal() del objeto sale
        }
    }
}
