using Pizzas.Builder.Pizzas.Builder;
using Pizzas.Builder.Pizzas.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Builder.Pizzas.Director
{
    public class PizzaDirector
    {
        public static int NroPedido { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public double PrecioTotal { get; set; }
        public double PrecioPizza { get; set; }
        public double PrecioDelivery { get; set; }
        public DateTime FechaPedido { get; set; }

        public PizzaDirector(DateTime fechaPedido)
        {
            NroPedido = NroPedido + 1;
            FechaPedido = fechaPedido;
            Pizzas = new List<Pizza>();
            PrecioDelivery = 10;
        }

        public void Agregar (Pizza pizza)
        {
            Pizzas.Add(pizza);
            PrecioPizza = PrecioPizza+pizza._precio;
            AplicarPromocion();
            CalcularPrecioTotal();
        }

        public void AplicarPromocion()
        {
            switch ((int)FechaPedido.DayOfWeek)
            {
                case 2:
                    PrecioPizza = PrecioPizza / 2;
                    break;

                case 3:
                    PrecioPizza = PrecioPizza / 2;
                    break;

                case 4:
                    PrecioDelivery = 0;
                    break;
            }
        }
        public double CalcularPrecioTotal()
        {
            PrecioTotal = PrecioPizza + PrecioDelivery;
            return PrecioTotal;
        }
    }
}
