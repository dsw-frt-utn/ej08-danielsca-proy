using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double suma = 0;
            int cantidadNotasValidas = 0;
            if (nota1.HasValue && nota1.Value >= 0 && nota1.Value <= 10) //HasValue devuelve true si hay valor y false si es null, Value devuelve el valor almacenado, esto capitulo 8 del libro, propiedades de los tipos anulables.
            {
                suma += nota1.Value;
                cantidadNotasValidas++;
            }
            if (nota2.HasValue && nota2.Value >= 0 && nota2.Value <= 10)
            {
                suma += nota2.Value;
                cantidadNotasValidas++;
            }
            if (nota3.HasValue && nota3.Value >= 0 && nota3.Value <= 10)
            {
                suma += nota3.Value;
                cantidadNotasValidas++;
            }

            if(cantidadNotasValidas == 0) //Verificar si no hay notas válidas para evitar división por cero
            {
                return 0;
            }

            return suma / cantidadNotasValidas; // Retornar el promedio
        }
    }
}
