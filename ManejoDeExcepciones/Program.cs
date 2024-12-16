using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
    * Crea una función que calcule el valor de elevar un número entero a otro
número entero (por ejemplo, 5 elevado a 3 = 5^3 = 5 ·5 ·5 = 125). Esta función se debe crear de forma recursiva.
   Piensa cuál será el caso base (qué potencia se puede calcular de forma trivial)
   y cómo pasar del caso "n-1" al caso "n" (por ejemplo, si sabes el valor de 5^4, cómo hallarías el de 5^5 a partir de él).

   declarar 2 numeros
   pedir al usuario que me los de, uno para la base otro para la potencia
   funcion Elevador
       mientras que int2 no sea 1, hacer int1 * int1
   VER SI SE PUEDE HACER MAS EFICIENTEMENTE, en este caso ahorrandonos vueltas
   */
        /* TODO SOLUCION EJERCICIO ELEVAR base a potencia
         * 
         * int int1, int2;

        Console.WriteLine("Introduce un numero entero, para la base");
        while (!Int32.TryParse(Console.ReadLine(), out int1))
        {
            Console.WriteLine("Introduce un numero entero valido");

        }

        Console.WriteLine("Introduce otro numero entero, para la potencia");
        while (!Int32.TryParse(Console.ReadLine(), out int2))
        {
            Console.WriteLine("Introduce un numero entero valido");

        }

        Console.WriteLine(Elevador (int1, int2));

             TODO Fin solucion ejercicio (mas metodo Elevador)
        */
        /*  TODO EJERCICIO FIBONACCI
       (5.10.3) Crea un programa que emplee recursividad para calcular un número de la
  serie Fibonacci (en la que los dos primeros elementos valen 1, y para los restantes,
  cada elemento es la suma de los dos anteriores)

          a, b = 1
          c = a + b
          d = b + c
          e = c + d...
          n = (n-2) + (n-1)
        Fibonacci = 1, 1, 3, 4, 7, 11, 18...

     */
        /* TODO EJERCICIO FIBONACCI
            int n, resultado;
        Console.WriteLine("Introduce un entero, para calcular su numero de la serie fibonacci");
        while (!Int32.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Introduce un numero entero valido");

        }
        resultado = CalcularFibonacci(n);
        Console.WriteLine($"El {n}-esimo numero de Fibonacci es {resultado}");
        // TODO FIN EJERCICIO FIBONACCI

        //TODO EJERCICIO INVERTIR CADENA
        (5.10.6) Crea un programa que emplee recursividad para dar la vuelta a una
cadena de caracteres (por ejemplo, a partir de "Hola" devolvería "aloH"). La función
recursiva se llamará "Invertir(cadena)". Como siempre, analiza cuál será el caso
base (qué longitud debería tener una cadena para que sea trivial darle la vuelta) y
cómo pasar del caso "n-1" al caso "n" (por ejemplo, si ya has invertido las 5
primeras letras, que ocurriría con la de la sexta posición)

        // Introducir cadena,
        // o+1 y cadena.lengt-2
        // hasta n >= cadena.lenght(n-1), en ese caso
        // para > un ultimo intercambio, para = nada xk ya tienes el caracter 
         */
        string cadena;
        cadena = ObtenerCadenaValida();

        Console.WriteLine("La cadena que has introducido es " + cadena);

        Console.WriteLine("La cadena invertida es: " + InvertirCadena(cadena));
         
    } // } del MAIN

    // metodo para verificar que la cadena introducida no está vacia. Ejercicio cadena Invertida
    static string ObtenerCadenaValida()
    {
        string teclado = "";

        while (string.IsNullOrEmpty(teclado))
        {
            Console.WriteLine("Introduce una cadena");
            teclado = Console.ReadLine();

            if (string.IsNullOrEmpty(teclado))
            {
                Console.WriteLine("La cadena no puede estar vacia, por favor, introduce una cadena valida");
            }
        }
        return teclado;
    }

    // metodo ejercicio dar la vuelta cadena caracteres
    public static string InvertirCadena(string cadena)
    {

        if (cadena.Length <= 1)
        {
            return cadena;
        }
        return cadena[cadena.Length-1] + InvertirCadena(cadena.Substring(1, (cadena.Length-2))) + cadena[0];

    }

    // metodo ejercicio fibonacci
    public static int CalcularFibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
        }
    }

    /*TODO Metodo elevador SOLUCION ejercicio ELEVAR base a potencia)
public static long Elevador (int int1, int int2)
{
    if (int2 == 0)
    {
        return 1;
    }

    return int1 * Elevador(int1, int2 - 1);
}
    */


    /* TODO Ejercicio palindromo

(5.10.7) Crea, tanto de forma recursiva como de forma iterativa, una función diga
si una cadena de caracteres es simétrica (un palíndromo). Por ejemplo,
"DABALEARROZALAZORRAELABAD" es un palíndromo.

    */


    










}

