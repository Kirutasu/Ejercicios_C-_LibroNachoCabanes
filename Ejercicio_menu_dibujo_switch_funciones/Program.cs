/*
    * En el main, hacer un menú para elegir el tipo de dibnujo a realizar (pista: usa un switch)
Convertir en funcionees cada uno de los ejercicios y en función de la opción que elija el usuario,
pintar dicho dibujo.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        // switch para que elija
        // opcion 1 cuadrado vacio
        // opcion 2 triangulo
        // funcion para cada uno, que lo pinte

        int valor, filas, columnas, filasYColumnas;
        char caracter = ' ';
        
        
        Console.Write("Si quieres dibujar un cuadrado vacio, presiona 1. Si quieres un triangulo, presiona 2");
        do
        {
            while (!Int32.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Escribelo en formato entero");
            }
            if (!(valor == 1 || valor == 2))
            {
                Console.WriteLine("Las opciones solo pueden ser 1(cuadrado) o 2(triangulo)");
            }
        } while (!(valor == 1 || valor == 2));


        switch (valor)
        {
            case 1:
                Console.Write("Introduce un caracter para el dibujo");
                while (!Char.TryParse(Console.ReadLine(), out caracter))
                {
                    Console.WriteLine("Por favor, introduce un unico caracter");

                }
                Console.Write("Introduce el numero de filas y columnas que quieres para el cuadrado");
                while (!Int32.TryParse(Console.ReadLine(), out filas))
                {
                    Console.WriteLine("Por favor, introduce un numero entero");
                }
                columnas = filas;
                DibujaUnCuadrado(caracter, filas, columnas);
                break;
            case 2:
                Console.WriteLine("Introduce un numero");
                while (!Int32.TryParse(Console.ReadLine(), out filasYColumnas))
                {
                    Console.WriteLine("Por favor, introduce un único numero");
                }
                Console.WriteLine($"El valor escogido es {filasYColumnas}, generando la forma triangular correspondiente");
                DibujaUnTriangulo(filasYColumnas);
                break;
        }
        //TODO cuadrado 5x5
        // TODO triangulo n filascolumnas
    }

    static void DibujaUnCuadrado(char caracter, int filas, int columnas)
    {

        for (int i = 0; i < filas; i++)
        {
            if (i == 0 || i == filas - 1)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(caracter);
                }
            }
            else
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (j == 0 || j == columnas - 1)
                    {
                        Console.Write(caracter);
                    }
                    else
                    {
                        Console.Write(' ');
                    }

                }
            }
            Console.WriteLine();
        }
    }

    static void DibujaUnTriangulo(int filasYColumnas)
    {
        int contador;
        contador = filasYColumnas;
        for (int i = contador; i > 1; i--)
        {
            for (int j = contador; j > 1; j--)
            {
                Console.Write(filasYColumnas);
            }
            Console.WriteLine();
            contador--;
        }
        Console.WriteLine("Et voilá! Y lo he hecho sin probar ni una sola gota de ron!");

    }
}

