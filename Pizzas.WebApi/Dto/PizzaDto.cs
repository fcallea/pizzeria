using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzas.WebApi.Dto
{
    public class PizzaDto
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public MasaDto masa { get; set; }
        public SalsaDto salsa { get; set; }
        public AgregadoDto agregado { get; set; }

        public PizzaDto(int cod, string desc, double prec)
        {
            codigo = cod;
            descripcion = desc;
            precio = prec;
        }
        public PizzaDto (int cod, string desc, double _precio, MasaDto _masa, SalsaDto _salsa, AgregadoDto _agregado)
        {
            codigo = cod;
            descripcion = desc;
            precio = _precio;
            masa = _masa;
            salsa = _salsa;
            agregado = _agregado;
        }
    }
}
