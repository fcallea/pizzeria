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
            _pizzas.Add(new PizzaDto(pItaliana._codigo, pItaliana._tipo));
            _pizzas.Add(new PizzaDto(pLight._codigo, pLight._tipo));
            _pizzas.Add(new PizzaDto(pMozzarella._codigo, pMozzarella._tipo));
            _pizzas.Add(new PizzaDto(pPersonal._codigo, pPersonal._tipo));

            return Ok(pItaliana);
        }

        [HttpPost]
        [Route("BuscarPizza/{id}")]
        public ActionResult Buscar(int id)
        {
            Pizza pizza;
            switch (id)
            {
                case 1:
                    pizza = new PizzaPersonalizadaBuilder().BuildPizza();
                    break;
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
            Masa masa;
            switch (ppersonal.masa.codigo)
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

            Salsa salsa;
            switch (ppersonal.salsa.codigo)
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

            Agregado agregado;
            switch (ppersonal.agregado.codigo)
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

            if (masa is null || salsa is null || agregado is null)
            {
                return NotFound();
            }

            Pizza pizza = new PizzaPersonalizadaBuilder(masa, salsa, agregado).BuildPizza();
            MasaDto masad = new MasaDto() { codigo = pizza._masa.CodigoMasa, descripcion = pizza._masa.Descripcion };
            SalsaDto salsad = new SalsaDto() { codigo = pizza._salsa.CodigoSalsa, descripcion = pizza._salsa.Descripcion };
            AgregadoDto agregadod = new AgregadoDto() { codigo = pizza._agregado.CodigoAgregado, descripcion = pizza._agregado.Descripcion };
            PizzaDto pizzadto = new PizzaDto(pizza._codigo, pizza._tipo, pizza._precio, masad, salsad, agregadod);

            return Ok(pizzadto);
        }
    }
}
