using Pizzas.Builder.Pizzas.Builder;
using Pizzas.Builder.Pizzas.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Builder.Pizzas.ConcreteBuilder
{
    public class PizzaMozzarellaBuilder : PizzaBuilder
    {
        public PizzaMozzarellaBuilder()
        {
            _codigo = 4;
            _descripcion = "Pizza Mozzarella";
        }
        public override Agregado BuildAgregado()
        {
            return new Oregano();
        }

        public override Masa BuildMasa()
        {
            return new AlMolde();
        }

        public override Salsa BuildSalsa()
        {
            return new Tomate();
        }
    }
}
