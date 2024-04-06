Arreglos.Pila pila = new Arreglos.Pila(5);

try
{
    pila.Agregar("gato0");
    pila.Agregar("gato1");
    pila.Agregar("gato2");
    pila.Agregar("gato3");
    pila.Agregar("gato4");
    pila.Agregar("gato5");
}
 
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

