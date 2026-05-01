using System;
using System.Collections.Generic;
using System.Text;

/*Extensions
● El método de extensión debe:
○ eliminar espacios al inicio y al final,
○ convertir el texto a mayúsculas,
○ reemplazar espacios internos por guiones.
● Si el código es null, debe retornar "SIN-CODIGO".
Ejemplo:
" ab 123 x " => "AB-123-X"
 */

namespace Dsw2026Ej8
{
    static class Extensions
    {
            public static string ToProductCode(this string code)
            {
            return code.Trim().ToUpper().Replace(" ", "-"); //Trim borra espacios accidentales,ToUpper lo hace mayúscula y Replace reemplaza los espacios internos por guiones medios...
            }
    
    }
}
