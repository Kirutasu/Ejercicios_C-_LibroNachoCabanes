using System;

namespace _11_4._2._1_Bloques_enteros_array2D_mostrar_mayor_cada;
class Program
{
    static void Main(string[] args)
    {
        /*
        (4.2.1) Un programa que pida al usuario dos bloques de 10 números enteros
        (usando un array de dos dimensiones). Después deberá mostrar el mayor dato
        que se ha introducido en cada uno de ellos.
        -1 Pedir rellenar 20 numeros (2 bloques de 10 enteros)
        -1.1 verificar entero
        -3 Ir guardando el mayor de cada?
        -4 Mostrar mayor de cada

         */
      //  int[,]datos = new int[2,10]; TODO no entiendo xk no me deja inicializar asi el array
        int[][] datos = new int[2][]; // TODO y por qué solo me deja asi para 2 bloques de 10
        datos[0] = new int[10];
        datos[1] = new int[10];
        int num = 0;
        int maximogrupo1 = int.MinValue;
        int maximogrupo2 = int.MinValue;

        Console.WriteLine($"Introduce dos grupos de 10 valores enteros (20 datos) y te mostraré el maximo para cada grupo");

        for (int i = 0; i < datos.Length; i++)
        {
            for (int j=0; j < datos[i].Length; j++)
            {
                while (!Int32.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine($"Esto no es un numero entero. Vuelve a intentarlo");
                }

                datos[i][j] = num;

                switch (i)
                {
                    case 0:
                        if (datos[i][j] > maximogrupo1)
                        {
                            maximogrupo1 = datos[i][j];
                        }
                        break;

                    case 1:
                        if (datos[i][j] > maximogrupo2)
                        {
                            maximogrupo2 = datos[i][j];
                        }
                        break;
                }

                Console.WriteLine ($"El dato en el grupo {i+1} y la posicion {j+1} es {num}");
            }
        }
        Console.WriteLine($"El numero maximo en el grupo 1 es {maximogrupo1}");
        Console.WriteLine($"El numero maximo en el grupo 2 es {maximogrupo2}");
    }
}

 