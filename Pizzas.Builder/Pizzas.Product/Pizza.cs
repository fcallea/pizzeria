using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Builder.Pizzas.Product
{
    public class Pizza
    {
        public int _codigo { get; protected set; }
        public string _tipo { get; protected set; }
        public double _precio { get; protected set; }
        public Masa _masa { get; protected set; }
        public Salsa _salsa { get; protected set; }
        public Agregado _agregado { get; protected set; }

        public override string ToString()
        {
            return $"{_tipo}, Masa: {_masa.Descripcion}, Salsa: {_salsa.Descripcion}, Agregado: {_agregado.Descripcion}";
        }


        public Pizza(Masa masa, Salsa salsa, Agregado agregado, int cod, string tipo)
        {
            _masa = masa;
            _salsa = salsa;
            _agregado = agregado;
            _codigo = cod;
            _tipo = tipo;
            if(masa is null || salsa is null || agregado is null)
            {
                _precio = 0;
            }
            else
            {
                _precio = masa.Precio + salsa.Precio + agregado.Precio;
            }            
        }
    }
}
