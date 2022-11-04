using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Builder.Pizzas.Product
{
    public abstract class Salsa
    {
        protected int _codigosalsa;
        protected double _precio;
        protected string _descripcion;
        public int CodigoSalsa { get { return _codigosalsa; } }
        public double Precio { get { return _precio; } }
        public string Descripcion { get { return _descripcion; } }
    }

    public class Tomate : Salsa
    {
        public Tomate()
        {
            _codigosalsa = 1;
            _precio = 3;
            _descripcion = "Salsa de tomate clásica";
        }
    }

    public class Oliva : Salsa
    {
        public Oliva()
        {
            _codigosalsa = 2;
            _precio = 4;
            _descripcion = "Salsa de tomate a la oliva";
        }
    }

    public class Light : Salsa
    {
        public Light()
        {
            _codigosalsa = 3;
            _precio = 5;
            _descripcion = "Salsa sin condimentos ni sal";
        }
    }
}
