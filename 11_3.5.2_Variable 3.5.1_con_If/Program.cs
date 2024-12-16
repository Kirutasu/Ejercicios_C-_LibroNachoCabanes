class Program
{
    static void Main(string[] args)
    {
        /*
         * 
(3.5.2) Crea una versión alternativa del ejercicio 3.5.1, que use "if" en vez del
operador condicional.
        */

        int num1, num2;
        bool iguales = false;
        string mensaje = "";


        Console.WriteLine($"Introduce dos numeros a comparar");

        while (!Int32.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Por favor, introduce un numero entero valido \n" );
        }

        while (!Int32.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("Por favor, introduce un numero entero valido \n");
        }

        if (num1 == num2)
        {
            iguales = true;
            mensaje = "¿Los dos numeros enteros son iguales? " + iguales;

        }
        else
        {
            mensaje = "¿Los dos numeros enteros son iguales? " + iguales;
        }

        Console.WriteLine(mensaje);

    }
}

