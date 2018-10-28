using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos una lista para agregar los elementos de la 3 listas musicales creadas
            List<Letra> ListCancion = new List<Letra>();

            /*Llamamos a la clase funcion e instanciamos llamando a la primera funcion que es de llenar
            la lista, como recibe un parametro de lista, ingresamos la lista creada(ListCancion)*/
            Funciones.llenado1(ListCancion);
            /*Llamamos a la clase funcion e instanciamos llamando a la segunda funcion que es de llenar
            la lista, como recibe un parametro de lista, ingresamos la lista creada(ListCancion)*/
            Funciones.llenado2(ListCancion);
            /*Llamamos a la clase funcion e instanciamos llamando a la tercera funcion que es de llenar
            la lista, como recibe un parametro de lista, ingresamos la lista creada(ListCancion)*/
            Funciones.llenado3(ListCancion);


            //Pedimos palabra por teclado
            Console.WriteLine("Ingresar palabra musical");
            string palabra;
            //Ingresamos palabra por teclados
            palabra = Console.ReadLine();

            /*Creamos un array de string, para llamar a la funcion de buscar, el cual recibe 2 
             parametros, que es un string que es la palabra que se ingresa y el segundo 
             que es la lista llenada*/
            string[] x = Funciones.Buscar(palabra, ListCancion);


            /*Usamos un bucle for para recorrer los elementos del arreglo de string,
             el cual recibe la funcion buscar*/
            for (int i=0; i<=2; i++)
            {
                /*Validamos que el array "x" sea diferente de vacio para poder mostrar
                 los datos por pantalla*/
                if(x[i] != string.Empty)
                {
                    Console.WriteLine(x[i]); //Mostramos los elementos recorridos por pantalla
                }
            }
            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }
    }
}
