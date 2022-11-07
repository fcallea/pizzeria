using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizzas.Builder.Pizzas.Builder;
using Pizzas.Builder.Pizzas.ConcreteBuilder;
using Pizzas.Builder.Pizzas.Product;
using Pizzas.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzas.WebApi.Controllers
{
    [ApiController]
    [Route("api/Pizza")]
    public class PizzaController : Controller
    {
        [HttpGet]
        [Route("Listado")]
        public ActionResult ListarPizzas()
        {
            Pizza pItaliana = new PizzaItalianaBuilder().BuildPizza();
            Pizza pLight = new PizzaLightBuilder().BuildPizza();
            Pizza pMozzarella = new PizzaMozzarellaBuilder().BuildPizza();
            Pizza pPersonal = new PizzaPersonalizadaBuilder().BuildPizza();
     
            List<PizzaDto> _pizzas = new List<PizzaDto>();
            _pizzas.Add(new PizzaDto(pItaliana._codigo, pItaliana._tipo, pItaliana._precio));
            _pizzas.Add(new PizzaDto(pLight._codigo, pLight._tipo, pLight._precio));
            _pizzas.Add(new PizzaDto(pMozzarella._codigo, pMozzarella._tipo, pMozzarella._precio));
            _pizzas.Add(new PizzaDto(pPersonal._codigo, pPersonal._tipo, pPersonal._precio));

            return Ok(_pizzas);
        }

        [HttpPost]
        [Route("BuscarPizza/{id}")]
        public ActionResult Buscar(int id)
        {
            Pizza pizza;
            switch (id)
            {
                //case 1:
                //    pizza = new PizzaPersonalizadaBuilder().BuildPizza();
                //    break;
                case 2:
                    pizza = new PizzaItalianaBuilder().BuildPizza();
                    break;
                case 3:
                    pizza = new PizzaLightBuilder().BuildPizza();
                    break;
                case 4:
                    pizza = new PizzaMozzarellaBuilder().BuildPizza();
                    break;
                default:
                    pizza = null;
                    break;
            }

            if (pizza is null)
            {
                return NotFound();
            }

            PizzaDto pizzadto;
            MasaDto masa = new MasaDto() { codigo = pizza._masa.CodigoMasa, descripcion = pizza._masa.Descripcion };
            SalsaDto salsa = new SalsaDto() { codigo = pizza._salsa.CodigoSalsa, descripcion = pizza._salsa.Descripcion };
            AgregadoDto agregado = new AgregadoDto() { codigo = pizza._agregado.CodigoAgregado, descripcion = pizza._agregado.Descripcion };
            pizzadto = new PizzaDto(pizza._codigo, pizza._tipo, pizza._precio, masa, salsa, agregado);

            return Ok(pizzadto);
        }

        [HttpPost]
        [Route("GenerarPizzaPersonal")]
        public ActionResult GenerarPizzaPersonal([FromBody] PizzaPersonalDto ppersonal)
        {
            PizzaPersonalDto p = new PizzaPersonalDto(ppersonal.CodMasa, ppersonal.CodSalsa, ppersonal.CodAgregado);

            if (p is null)
            {
                return NotFound();
            }

            Pizza pizza = new PizzaPersonalizadaBuilder(p.getMasa(), p.getSalsa(), p.getAgregado()).BuildPizza();
            MasaDto masad = new MasaDto() { codigo = pizza._masa.CodigoMasa, descripcion = pizza._masa.Descripcion };
            SalsaDto salsad = new SalsaDto() { codigo = pizza._salsa.CodigoSalsa, descripcion = pizza._salsa.Descripcion };
            AgregadoDto agregadod = new AgregadoDto() { codigo = pizza._agregado.CodigoAgregado, descripcion = pizza._agregado.Descripcion };
            PizzaDto pizzadto = new PizzaDto(pizza._codigo, pizza._tipo, pizza._precio, masad, salsad, agregadod);

            return Ok(pizzadto);
        }

        [HttpPost]
        [Route("AgregarPedido/{id}")]
        public ActionResult Buscar(int id)
        {
            Pizza pizza;
            switch (id)
            {
                //case 1:
                //    pizza = new PizzaPersonalizadaBuilder().BuildPizza();
                //    break;
                case 2:
                    pizza = new PizzaItalianaBuilder().BuildPizza();
                    break;
                case 3:
                    pizza = new PizzaLightBuilder().BuildPizza();
                    break;
                case 4:
                    pizza = new PizzaMozzarellaBuilder().BuildPizza();
                    break;
                default:
                    pizza = null;
                    break;
            }

            if (pizza is null)
            {
                return NotFound();
            }

            PizzaDto pizzadto;
            MasaDto masa = new MasaDto() { codigo = pizza._masa.CodigoMasa, descripcion = pizza._masa.Descripcion };
            SalsaDto salsa = new SalsaDto() { codigo = pizza._salsa.CodigoSalsa, descripcion = pizza._salsa.Descripcion };
            AgregadoDto agregado = new AgregadoDto() { codigo = pizza._agregado.CodigoAgregado, descripcion = pizza._agregado.Descripcion };
            pizzadto = new PizzaDto(pizza._codigo, pizza._tipo, pizza._precio, masa, salsa, agregado);

            return Ok(pizzadto);
        }
    }
}
