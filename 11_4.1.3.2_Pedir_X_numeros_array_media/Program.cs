namespace _11_4._1._3._2_Pedir_X_numeros_array_media;
class Program
{
    static void Main(string[] args)
    {
        /*
         * 
        (4.1.3.2) Crea un programa que pregunte al usuario cuántos números enteros va a
        introducir (por ejemplo, 10), le pida todos esos números, los guarde en un array y
        finalmente calcule y muestre la media de esos números.

                1-preguntar cuantos enteros quiere calcular media
                2-pedir todos esos numeros
                3-guardarlos en array
                4-calcular media de esos X numeros
        */

        int num, cuantos;
        int media = 0;
        int[] enteros;


        Console.WriteLine($"¿Cuantos numeros vas a introducir para calcular su media?");
        while (!Int32.TryParse(Console.ReadLine(), out cuantos))
        {
            Console.WriteLine($"Esto no es un numero entero. Vuelve a intentarlo");

        }
        enteros = new int[cuantos];

        Console.WriteLine($"Escribe los {cuantos} numeros ahora, de 1 en 1");

        for (int i = 0; i < cuantos; i++)
        {

            while (!Int32.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine($"Esto no es un numero entero. Vuelve a intentarlo");

            }
            enteros[i] = num;
            media += enteros[i];
            // Console.WriteLine($"El numero que queda guardado en la posicion {i} es {enteros[i]}"); //todo checking y estan en el array

        } 

        media = media / cuantos; //Se podria crear una variable y pedir al user cuantos datos quiere poner primero, y con ello cambiar el 4 de los bucles for y aqui

        Console.WriteLine($"La media aritmetica de los {cuantos} numeros introducidos es: {media}");

        for (int i = 0; i < cuantos; i++)
        {
            Console.WriteLine($"El numero en la posicion {i} es {enteros[i]}"); //todo checking y estan en el array
        }
    }
}

