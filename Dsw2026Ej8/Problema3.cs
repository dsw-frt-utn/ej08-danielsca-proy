using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        internal class Product
        {
            private string description;
            public Product(string description)
            {
                this.description = description;
            }
            public void SetDescription(string newDescription)
            {
                description = newDescription;
            }
            public string GetDescription()
            {
                return description;
            }
        }

        public string CompararCopias(int originalValue, Product product)
        {
            int copiaValor = originalValue; //Copia
            copiaValor++; //Incrementa copia


            Product copiaProducto = product; //Copia referencia
            copiaProducto.SetDescription("Descripción modificada"); //Modifica la copia de referencia

            return $"{originalValue}-{copiaValor}-{copiaProducto.GetDescription()}"; //Retorno solicitado
        }
    }
}
