using Pizzas.Builder.Pizzas.Builder;
using Pizzas.Builder.Pizzas.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Builder.Pizzas.ConcreteBuilder
{
    public class PizzaLightBuilder : PizzaBuilder
    {
        public PizzaLightBuilder()
        {
            _codigo = 3;
            _descripcion = "Pizza Light";
        }

        public override Agregado BuildAgregado()
        {
            return new Berenjenas();
        }

        public override Masa BuildMasa()
        {
            return new Integral();
        }

        public override Salsa BuildSalsa()
        {
            return new Light();
        }
    }
}
