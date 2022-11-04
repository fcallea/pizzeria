using Pizzas.Builder.Pizzas.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Builder.Pizzas.Builder
{
    public abstract class PizzaBuilder
    {
        protected int _codigo { get; set; }
        protected string _descripcion { get; set; }
        public abstract Masa BuildMasa();
        public abstract Salsa BuildSalsa();
        public abstract Agregado BuildAgregado();

        public override string ToString()
        {
            return _descripcion;
        }

        public Pizza BuildPizza()
        {
            Masa masa = BuildMasa();
            Salsa salsa = BuildSalsa();
            Agregado agregado = BuildAgregado();

            return new Pizza(masa, salsa, agregado, _codigo, _descripcion);
        }
    }
}
