using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Funciones
    {
        /*Esta clase se ha creado para crear las funciones de llenar la lista y
        tambien se ha creado una funcion para recorrer y buscar la lista de sonidos*/


        /*Esta Función llena la primera lista de sonidos llamando a la clase creada
         anteriormente llamada Letra*/
        public static void llenado1(List<Letra> Cancion1)//Recibe una lista de la clase llamada letras para llenarse
        {
            Letra C1 = new Letra();//Creación de nuevo objeto de la clase letra, para llenar la primera lista musical
            C1.letra1 = "brr";
            C1.letra2 = "fiu";
            C1.letra3 = "cric-cric";
            C1.letra4 = "brrah";
            Cancion1.Add(C1);
        }

        /*Esta Función llena la segunda lista de sonidos llamando a la clase creada
         anteriormente llamada Letra*/
        public static void llenado2(List<Letra> Cancion1)//Recibe una lista de la clase llamada letras para llenarse
        {
            Letra C3 = new Letra();//Creación de nuevo objeto de la clase letra, para llenar la segunda lista musical
            C3.letra1 = "pep";
            C3.letra2 = "birip";
            C3.letra3 = "trri-trri";
            C3.letra4 = "croac";
            Cancion1.Add(C3);
        }

        /*Esta Función llena la tercera lista de sonidos llamando a la clase creada
         anteriormente llamada Letra*/
        public static void llenado3(List<Letra> Cancion1)//Recibe una lista de la clase llamada letras para llenarse
        {
            Letra C2 = new Letra();//Creación de nuevo objeto de la clase letras, para llenar la tercera lista musical
            C2.letra1 = "bri-bri";
            C2.letra2 = "plop";
            C2.letra3 = "cric-cric";
            C2.letra4 = "brrah";
            Cancion1.Add(C2);
        }

        /*Creamos un arreglo de string, el cual llamaremos "Buscar", recibe un parametro que va a ser ingresado
         por pantalla, y recibe una lista*/
        public static string[] Buscar(string valor,List<Letra> letras)
        {
            /*Creamos un array de string, que va a tener la longitud de 3
             el cual va a retornar en la funcion los valores de la lista recorrida*/ 
            string[] resultado = new string[3];

            //Recorremos la clase letra en la lista letras
            /*Por medio de este Foreach vamos a recorrer todos los elementos de la clase Letra,
             y vamos a compararlo con la lista letra*/
            foreach(Letra items in letras)
            {
                //Validamos que el valor ingresado sea igual a 
                if(items.letra1 == valor)
                {
                    /*Si el valor ingresado cae en la primera posicion de las listas,
                     recorremos a partir del elemento 2 hasta el elemento 4 de la lista*/
                    resultado[0] = items.letra2;//Elemento 2 de la lista 
                    resultado[1] = items.letra3;//Elemento 3 de la lista 
                    resultado[2] = items.letra4;//Elemento 4 de la lista 
                }

                if (items.letra2 == valor)
                {
                    /*Si el valor ingresado cae en la segunda posicion de las listas,
                    recorremos a partir del elemento 3 hasta el elemento 4 de la lista*/
                    resultado[0] = items.letra3;//Elemento 3 de la lista 
                    resultado[1] = items.letra4;//Elemento 4 de la lista
                }

                if (items.letra3 == valor)
                {
                    /*Si el valor ingresado cae en la tercera posicion de las listas,
                     recorremos solo el elemento 4 de la lista*/
                    resultado[0] = items.letra4;//Elemento 4 de la lista 
                }
            }
            //Retornamos el resultado de los valores obtenidos, segun cada posicion
            return resultado;
        }
    }
}
