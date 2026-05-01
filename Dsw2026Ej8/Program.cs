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

            // Problema 5

            // Problema 6
        }
    }
}
