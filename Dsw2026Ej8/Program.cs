namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problema 1
            string resultado = ProductHelper.ObtenerEtiquetaProducto(123, "Teclado", 15000m);
            Console.WriteLine(resultado);
            Console.WriteLine(); 
            
            // Problema 2
            Problema2 p2 = new(); 
            string resumen = p2.CrearResumenVenta(101, "Papel", 10, 1500);
            Console.WriteLine(resumen);
            Console.WriteLine();

            // Problema 3
            Problema3 p3 = new();
            string comparacion = p3.CompararCopias(60554, new Problema3.Product("Descripción original"));
            Console.WriteLine(comparacion);
            Console.WriteLine();

            // Problema 4
            Problema4 p4 = new();
            double promedio = p4.CalcularPromedio(10, 6, null);
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine();

            // Problema 5
            Problema5 p5 = new();
            decimal total = p5.ObtenerImporteFinal(new Sale());
            decimal total1 = p5.ObtenerImporteFinal(new RetailSale());
            decimal total2 = p5.ObtenerImporteFinal(new WholesaleSale());
            Console.WriteLine("Sale base " + total);
            Console.WriteLine("Sin descuento " + total1);
            Console.WriteLine("Con descuento " + total2);
            Console.WriteLine();

            // Problema 6
            Problema6 p6 = new();
            string normalizado = p6.NormalizarCodigoProducto("ab 123 x");
            Console.WriteLine(normalizado);
        }
    }
}
