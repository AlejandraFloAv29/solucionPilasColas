using Arreglos;
using Listas;
using System.Xml.Linq;



namespace PilasColas
{
    class Program
    {
        public static void Main(string[] args) 
        {
            arregloPila();
            arregloColas();
            ListasPila();
            ListasColas(); 
        }
        static void arregloPila() 
        {
            Arreglos.Pila pila = new Arreglos.Pila(5);
              Console.WriteLine("ARREEGLO PILAS");
              
         void Imprimir(string[] Elementos)   
          {         
              Console.WriteLine();
              foreach (string Elemento in Elementos) 
          {   
              Console.WriteLine(Elemento);
          }
    }
        
    try
    {
    pila.Agregar(" GATO 0 ");
    pila.Agregar(" GATO 1 ");
    pila.Agregar(" GATO 2 ");
    pila.Agregar(" GATO 3 ");
    pila.Agregar(" GATO 4 ");

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
    
    }
    catch(Exception ex)
    {
              Console.WriteLine(ex.Message);
     }
              Console.WriteLine(">>>>>>>>>><<<<<<<<<<");
     }

    static void arregloColas() 
        {
              Console.WriteLine("ARREGLO COLAS");
              Arreglos.Colas Cola = new Arreglos.Colas(5);
              void Imprimir(string[] Elementos)
        {
              
               Console.WriteLine();
               foreach (string Elemento in Elementos) 
          {   
               Console.WriteLine(Elemento);
         }
      }
    try
    {
    Cola.Agregar(" PERRO 0 ");
    Cola.Agregar(" PERRO 1 ");
    Cola.Agregar(" PERRO 2 ");
    Cola.Agregar(" PERRO 3 ");
    Cola.Agregar(" PERRO 4 ");

    Imprimir(Cola.ObtenerArreglo());

    Cola.Eliminar();
    Imprimir(Cola.ObtenerArreglo());
    Cola.Eliminar();
    Imprimir(Cola.ObtenerArreglo());
    Cola.Eliminar();
    Imprimir(Cola.ObtenerArreglo());
    Cola.Eliminar();
    Imprimir(Cola.ObtenerArreglo());
    Cola.Eliminar();
    Imprimir(Cola.ObtenerArreglo());    
    }
    
    catch (Exception ex)
    {
             Console.WriteLine(ex.Message);
     }
             Console.WriteLine(">>>>>>>>>><<<<<<<<<<");

     }

     static void ListasPila()
        {
              Console.WriteLine("LISTAS PILAS");
            try
            {
              Listas.Pila pila = new Listas.Pila();
                
     pila.Agregar(" TORTUGA O ");
     pila.Imprimir();
     pila.Agregar(" TORTUGA 1 ");
     pila.Imprimir();
     pila.Agregar(" TORTUGA 2 ");
     pila.Imprimir();
     pila.Agregar(" TORTUGA 3 ");
     pila.Imprimir();
     pila.Agregar(" TORTUGA 4 ");
     pila.Imprimir();

              Console.WriteLine(pila.Imprimir());

     Console.WriteLine();
     pila.Eliminar();
     Console.WriteLine(pila.Imprimir());

     Console.WriteLine();
     pila.Eliminar();
     Console.WriteLine(pila.Imprimir());

     Console.WriteLine();
     pila.Eliminar();
     Console.WriteLine(pila.Imprimir());

     Console.WriteLine();
     pila.Eliminar();
     Console.WriteLine(pila.Imprimir());

     Console.WriteLine();
     pila.Eliminar();
     Console.WriteLine(pila.Imprimir());

   }
        catch (Exception ex)
         {
              Console.WriteLine(ex.Message);
        }
              Console.WriteLine(">>>>>>>>>><<<<<<<<<<");
    }
    
            static void ListasColas()
            {
            Console.WriteLine("LISTAS COLAS");
         try
           {
            Listas.Colas cola = new Listas.Colas();          
      
     cola.Agregar(" CONEJO O ");
     cola.Imprimir();
     cola.Agregar(" CONEJO 1 ");
     cola.Imprimir();
     cola.Agregar(" CONEJO 2 ");
     cola.Imprimir();
     cola.Agregar(" CONEJO 3 ");
     cola.Imprimir();
     cola.Agregar(" CONEJO 4 ");
     cola.Imprimir();
            
     Console.WriteLine(cola.Imprimir());

     Console.WriteLine();
     cola.Eliminar();
     Console.WriteLine(cola.Imprimir());

     Console.WriteLine();
     cola.Eliminar();
     Console.WriteLine(cola.Imprimir());

     Console.WriteLine();
     cola.Eliminar();
     Console.WriteLine(cola.Imprimir());

     Console.WriteLine();
     cola.Eliminar();
     Console.WriteLine(cola.Imprimir());

     Console.WriteLine();
     cola.Eliminar();
     Console.WriteLine(cola.Imprimir());

    }
       catch (Exception ex)
           {
               Console.WriteLine(ex.Message);
           }

     }
   }   
 }













