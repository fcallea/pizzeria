using Pizzas.Builder.Pizzas.Builder;
using Pizzas.Builder.Pizzas.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Builder.Pizzas.ConcreteBuilder
{
    public class PizzaPersonalizadaBuilder: PizzaBuilder
    {
        public Masa _masa { get; set; }
        public Salsa _salsa { get; set; }
        public Agregado _agregado { get; set; }
        public PizzaPersonalizadaBuilder()
        {
            _codigo = 1;
            _descripcion = "Pizza Personalizada";
        }

        public PizzaPersonalizadaBuilder(Masa masa, Salsa salsa, Agregado agregado)
        {
            _masa = masa;
            _salsa = salsa;
            _agregado = agregado;
            _codigo = 1;
            _descripcion = "Pizza Personalizada";
        }
        public override Agregado BuildAgregado()
        {
            return _agregado;
        }

        public override Masa BuildMasa()
        {
            return _masa;
        }

        public override Salsa BuildSalsa()
        {
            return _salsa;
        }
    }
}
