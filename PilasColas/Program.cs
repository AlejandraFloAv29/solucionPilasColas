using System.Xml.Linq;

Arreglos.Pila pila = new Arreglos.Pila(5);
void Imprimir(string[] Elementos)
{
    //Console.Clear();
    Console.WriteLine();
    foreach (string Elemento in Elementos) 
    {
    Console.WriteLine(Elemento);
    }
}

try
{
    pila.Agregar("gato0");
    pila.Agregar("gato1");
    pila.Agregar("gato2");
    pila.Agregar("gato3");
    pila.Agregar("gato4");

    Imprimir (pila.ObtenerArreglo());

    pila.Eliminar();
    Imprimir(pila.ObtenerArreglo());
    pila.Eliminar();
    Imprimir(pila.ObtenerArreglo());
    pila.Eliminar();
    Imprimir(pila.ObtenerArreglo());
    pila.Eliminar();
    Imprimir(pila.ObtenerArreglo());
    pila.Eliminar();
    Imprimir(pila.ObtenerArreglo());
    pila.Eliminar();
    Imprimir(pila.ObtenerArreglo());
    pila.Eliminar();
    Imprimir(pila.ObtenerArreglo());
}

catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

