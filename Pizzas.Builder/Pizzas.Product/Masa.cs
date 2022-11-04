using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas.Builder.Pizzas.Product
{
    public abstract class Masa
    {
        protected int _codigomasa;
        protected double _precio;
        protected string _descripcion;
        public int CodigoMasa { get { return _codigomasa; } }
        public double Precio { get { return _precio; } }
        public string Descripcion { get { return _descripcion; } }
    }

    public class AlMolde : Masa
    {
        public AlMolde()
        {
            _codigomasa = 1;
            _precio = 15;
            _descripcion = "Masa al molde";
        }
    }

    public class ALaPiedra : Masa
    {
        public ALaPiedra()
        {
            _codigomasa = 2;
            _precio = 17;
            _descripcion = "Masa a la piedra del horno a leña";
        }
    }

    public class Integral : Masa
    {
        public Integral()
        {
            _codigomasa = 3;
            _precio = 15;
            _descripcion = "Masa de harina integral";
        }
    }
}
