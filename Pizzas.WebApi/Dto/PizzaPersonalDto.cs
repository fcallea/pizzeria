using Pizzas.Builder.Pizzas.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzas.WebApi.Dto
{
    public class PizzaPersonalDto
    {
        public int CodMasa { get; set; }
        public int CodSalsa { get; set; }
        public int CodAgregado { get; set; }
        private Masa masa;
        private Salsa salsa;
        private Agregado agregado;

        public PizzaPersonalDto(int codMasa, int codSalsa, int codAgregado)
        {
            CodMasa = codMasa;
            CodSalsa = codSalsa;
            CodAgregado = codAgregado;
            switch (CodMasa)
            {
                case 1:
                    masa = new AlMolde();
                    break;
                case 2:
                    masa = new ALaPiedra();
                    break;
                case 3:
                    masa = new Integral();
                    break;
                default:
                    masa = null;
                    break;
            }

            switch (CodSalsa)
            {
                case 1:
                    salsa = new Tomate();
                    break;
                case 2:
                    salsa = new Oliva();
                    break;
                case 3:
                    salsa = new Light();
                    break;
                default:
                    salsa = null;
                    break;
            }

            switch (CodAgregado)
            {
                case 1:
                    agregado = new Oregano();
                    break;
                case 2:
                    agregado = new Anchoas();
                    break;
                case 3:
                    agregado = new Berenjenas();
                    break;
                default:
                    agregado = null;
                    break;
            }
        }
        public Masa getMasa()
        {
            return masa;
        }
        public Salsa getSalsa()
        {
            return salsa;
        }

        public Agregado getAgregado()
        {
            return agregado;
        }
    }
}
