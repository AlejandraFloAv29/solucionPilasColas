using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Pila
    {
        private List<string> _Pila;

        public Pila()
        {
            _Pila = new List<string>();
        }

        public void Agregar(string dato) 
        {
            _Pila.Add(dato);
        }

        private bool EstaVacio()
        {
            return _Pila.Count == 0;
        }

        public void Eliminar()
        {
            if (EstaVacio())
            {
                throw new Exception(" LISTA VACIA ");
            }
            _Pila.RemoveAt(_Pila.Count - 1);
        }

        public string Imprimir()
        {
            string datos = string.Empty;
            if (EstaVacio())
            {
                return " LISTA VACIA ";
            }

            int listacount = _Pila.Count;
            for (int i = 0; i < listacount; i++)
            {
                if (i > 0)
                {
                    datos += "\n";
                }
                datos += _Pila[i];
            }
            return datos;

        }

    }
}
