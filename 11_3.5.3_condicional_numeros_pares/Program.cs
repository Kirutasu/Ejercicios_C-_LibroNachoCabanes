class Program
{
    static void Main(string[] args)
    {
        /*
         * 
        (3.5.3) Crea un programa que use el operador condicional para dar a una variable
        llamada "ambosPares" (booleana) el valor "true" si dos números introducidos por
        el usuario son pares, o "false" si alguno es impar.

        */
        int num1, num2;
        bool ambosPares;


        Console.WriteLine($"Introduce dos numeros a comparar si son pares");

        while (!Int32.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Por favor, introduce un numero entero valido");
        }

        while (!Int32.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Por favor, introduce un numero entero valido");
        }

        ambosPares = ((num1 % 2 == 0) && (num2 %2 == 0) ) ? true : false;

        string mensaje = "¿Los dos numeros enteros son pares? " + ambosPares;
        Console.WriteLine(mensaje);
    }
}

