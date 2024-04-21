using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Colas
    {
 
     private List<string> _Colas;
     public Colas()
        {
            _Colas = new List<string>();
        }

        public void Agregar(string dato)
    {
        _Colas.Add(dato);
    }
    private bool EstaVacio()
    {
        return (_Colas.Count == 0);
    }
    
    public void Eliminar()
    {
        if (EstaVacio()) 
        {
            throw new Exception(" LISTA VACIA "); 
        }

        _Colas.RemoveAt(0);

    }

    public string Imprimir()
    {
        string datos = string.Empty;

        if (EstaVacio())
        {
            return (" LISTA VACIA ");
        }


        int listacount = _Colas.Count;
        for (int i = 0; i < listacount; i++) 
            {
            if (i > 0)
            {
                datos += "\n";
            }

            datos += _Colas[i];
        }
        return datos;
       }
     }

}

