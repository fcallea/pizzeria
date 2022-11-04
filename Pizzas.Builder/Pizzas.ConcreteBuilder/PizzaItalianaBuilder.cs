using Pizzas.Builder.Pizzas.Builder;
using Pizzas.Builder.Pizzas.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Builder.Pizzas.ConcreteBuilder
{
    public class PizzaItalianaBuilder : PizzaBuilder
    {

        public PizzaItalianaBuilder()
        {
            this._codigo = 2;
            this._descripcion = "Pizza Italiana";
        }
        public override Agregado BuildAgregado()
        {
            return new Anchoas();
        }

        public override Masa BuildMasa()
        {
            return new ALaPiedra();
        }

        public override Salsa BuildSalsa()
        {
            return new Oliva();
        }
    }
}
