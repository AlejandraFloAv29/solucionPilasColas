using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Arreglos
{
    public class Colas
    {
        private string[] _arreglo;
        private int _tope;
        private int _max;
        private int _inicio;
   
    public Colas(int Elementos)

    {
            _arreglo = new string[Elementos];
            _tope = 0;
            _max = _arreglo.Length - 1;
            _inicio = 0;
    }

        private bool EstaVacio() 
        {
            return ((_inicio < 1 && _tope < 1) || _inicio == _tope);
        }

        private bool EstaLleno()
        {
            return (_tope > _max);
        }

        public void Agregar(string dato) 
        { 
          if (EstaLleno())
            {
                throw new Exception("NO HAY ESPACIO");
            }
            _arreglo[_tope] = dato;
            _tope++;
        }

        public void Eliminar()
        {
            if (EstaVacio())
            {
                throw new Exception(" NO HAY ELEMENTOS QUE ELIMINAR ");      
            }
            _arreglo[_inicio] = null;
            _inicio++;
        }

        public string[] ObtenerArreglo()
        {
            return _arreglo;
        }
    }
}



