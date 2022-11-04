using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzas.WebApi.Dto
{
    public class PizzaPersonalDto
    {
        public MasaDto masa { get; set; }
        public SalsaDto salsa { get; set; }
        public AgregadoDto agregado { get; set; }

        public PizzaPersonalDto(MasaDto _masa, SalsaDto _salsa, AgregadoDto _agregado)
        {
            masa = _masa;
            salsa = _salsa;
            agregado = _agregado;
        }
    }
}
