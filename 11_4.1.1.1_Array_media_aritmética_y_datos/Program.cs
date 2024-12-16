namespace _11_4._1._1._1_Array_media_aritmética_y_datos;
class Program
{
    static void Main(string[] args)
    {
        /*
         * 
        (4.1.1.1) Un programa que pida al usuario 4 números, los memorice (utilizando un
        array), calcule su media aritmética y después muestre en pantalla la media y los
        datos tecleados.
        1-pedir 4 numeros, (bucle while que se repite verificando que son numeros enteros, con !Int32.TryParse(entrada, out entero)
        2-calcular media aritmetica (sumar los 4 y dividir /4)
        2.5-mostrar media 
        3-que por consola saque el valor de cada posicion del array (bucle for sacando el dato)
         
         */

        int num;
        int media = 0;
        int[] enteros = new int[4];


        Console.WriteLine($"Dame 4 numeros");

        for (int i=0; i < 4; i++)
        {
            
            while (!Int32.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine($"Esto no es un numero entero. Vuelve a intentarlo");

            }
            enteros[i] = num;
            media += enteros[i];
           // Console.WriteLine($"El numero que queda guardado en la posicion {i} es {enteros[i]}"); //todo checking y estan en el array

        }

        media = media/4; //Se podria crear una variable y pedir al user cuantos datos quiere poner primero, y con ello cambiar el 4 de los bucles for y aqui

        Console.WriteLine($"La media aritmetica de los 4 numeros introducidos es: {media}");

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"El numero en la posicion {i} es {enteros[i]}"); //todo checking y estan en el array
        }

    }
}

