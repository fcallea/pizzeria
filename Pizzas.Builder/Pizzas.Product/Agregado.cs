using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Builder.Pizzas.Product
{
    public abstract class Agregado
    {
        protected int _codigoagregado;
        protected int _precio;
        protected string _descripcion;
        public int CodigoAgregado { get { return _codigoagregado; } }
        public double Precio { get { return _precio; } }
        public string Descripcion { get { return _descripcion; } }
    }


    public class Oregano : Agregado
    {
        public Oregano()
        {
            _codigoagregado = 1;
            _precio = 1;
            _descripcion = "Oregano fresco";
        }
    }

    public class Anchoas : Agregado
    {
        public Anchoas()
        {
            _codigoagregado = 2;
            _precio = 2;
            _descripcion = "Anchoas en aceite";
        }
    }


    public class Berenjenas : Agregado
    {
        public Berenjenas()
        {
            _codigoagregado = 3;
            _precio = 1;
            _descripcion = "Berenjenas sin calorías";
        }
    }
}
