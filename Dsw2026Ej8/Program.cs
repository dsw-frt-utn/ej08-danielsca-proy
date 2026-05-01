namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resultado = ProductHelper.ObtenerEtiquetaProducto(123, "Teclado", 15000m);

            Console.WriteLine(resultado);
        }
    }
}
