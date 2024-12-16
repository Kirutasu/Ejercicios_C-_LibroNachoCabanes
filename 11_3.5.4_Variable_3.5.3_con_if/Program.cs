class Program
{
    static void Main(string[] args)
    {
        int num1, num2;
        bool ambosPares = false;
        string mensaje = "";


        Console.WriteLine($"Introduce dos numeros a comparar si son pares");

        while (!Int32.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Por favor, introduce un numero entero valido \n");
        }

        while (!Int32.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("Por favor, introduce un numero entero valido \n");
        }

        if ((num1 % 2 == 0) && (num2 % 2 == 0))
        {
            ambosPares = true;
            mensaje = "¿Los dos numeros enteros son pares entre sí? " + ambosPares;
             
        }
        else
        {
            mensaje = "¿Los dos numeros enteros son pares entre si? " + ambosPares;
        }

        Console.WriteLine(mensaje);

    }
}
