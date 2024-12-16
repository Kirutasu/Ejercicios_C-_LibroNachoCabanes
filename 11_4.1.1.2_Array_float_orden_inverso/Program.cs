using System;

namespace _11_4._1._1._2_Array_float_orden_inverso;
class Program
{
    static void Main(string[] args)
    {
        /*
         * 
        (4.1.1.2) Un programa que pida al usuario 5 números reales (pista: necesitarás un
        array de "float") y luego los muestre en el orden contrario al que se introdujeron.

        1-pedir 5 float y verificar (while sigue siendo posible? int32?
        2-recorrer array y
        2.1-guardar en array auxiliar el orden inverso
        2.1-guardar en posiciones inversas el dato introducido
        2.2-guardar array normal y volver a recorrer al reves mostrando datos

        */
        float num;
        float [] enteros = new float [5];

        Console.WriteLine($"Introduce 5 numeros reales");

        for (int i = 0; i < 5; i++)
        { 
            string input = Console.ReadLine();
            // Reemplazar las comas por puntos

            input = input.Replace(',', '.');
            // Intentar convertir a float

            if (!Single.TryParse(input, out float numero))
            {
                Console.WriteLine("Por favor, introduce un número real válido:");
                i--; // Volver a intentar con el mismo índice
            }
            else
            {
                enteros[i] = numero;
            }
        }
        for (int i = 4; i >= 0; i--)
        {
            Console.WriteLine($"El numero en la posicion {i+1} es {enteros[i]}"); //todo checking y estan en el array
        }

    }
}

