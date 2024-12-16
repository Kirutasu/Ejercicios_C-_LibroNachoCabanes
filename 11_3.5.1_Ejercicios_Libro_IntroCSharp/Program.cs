internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2;
        bool iguales;


        Console.WriteLine($"Introduce dos numeros a comparar");

        while (!Int32.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Por favor, introduce un numero entero valido");
        }

        while (!Int32.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Por favor, introduce un numero entero valido");
        }

        iguales = (num1 == num2) ? true : false;

        string mensaje = "¿Los dos numeros enteros son iguales? " + iguales;
        Console.WriteLine(mensaje);

    } // Fin del Main

}

/*
(3.5.1) Crea un programa que use el operador condicional para dar a una variable
llamada "iguales" (booleana) el valor "true" si los dos números que ha tecleado el
usuario son iguales, o "false" si son distintos.

1. pedir dos numeros al usuario
1.1 verificar esos 2 numeros
2. compararlos con ? :
2.1  (condicion) ? expresion_si_verdadera : expresion_si_falsa
3 mostrar x consola con variable true o false
 */
