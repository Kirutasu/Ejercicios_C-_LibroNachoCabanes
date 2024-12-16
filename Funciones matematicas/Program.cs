internal class Program
{
    private static void Main(string[] args)
    {
        /* 5.7.1 en el libro. Crea una función "Intercambiar", que intercambie el valor de los dos 
             números enteros que se le indiquen como parámetro. Crea también un programa 
             que la pruebe (pida 2 numeros y ejecute la funcion). 
        */

        //Main:
        //Declarar 2 int
        //Pedir 2 enteros:
        //Escribir la petición
        //Comprobar que el primero es válido
        //Guardar el primero
        //Comprobar que el segundo es válido
        //Guardar el segundo
        //Intercambiar:
        //In: 2 int
        //Out: 2 int
        //Asignar el parámetro de entrada al out contrario.

        /* (Solucion ejercicio 5.7.1)
         
        int num1 = 0, num2 = 0, a = 0, b= 0;

        Console.WriteLine("Escribe dos numeros");
        while (!Int32.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Por favor, introduce un numero entero valido");
        }                                                         

        while (!Int32.TryParse(Console.ReadLine(), out num2))   
        {                                                        
            Console.Write("Por favor, introduce un numero entero valido");
        }

        IntercambiaParametros(num1,num2,out num1,out num2);
        Console.WriteLine($"El resultado de intercambiar los parametros del primer valor: {num2} y el segundo valor: {num1}, resulta en que el primer valor sea {num1} y el segundo {num2}");
        */

        /* (5.7.2) Crea una función "Iniciales", que reciba una cadena como "Nacho Cabanes"
        y devuelva las letras N y C (primera letra, y letra situada tras el primer espacio),
        usando parámetros por referencia. Crea un "Main" que te permita comprobar que
        funciona correctamente

        PASOS:
        Crear funcion "Inciales"
            recibe un String
            devuelve la primera letra
            devuelve tambien la letra despues del primer " "
                bucle que recorra el string buscando " "
            lo hace con parametros por referencia
        Metodo main que compruebe que funciona

         */

        char primeraLetra = ' ', letraTrasEspacio = ' ';
        Iniciales("Nacho Cadenas", ref primeraLetra, ref letraTrasEspacio);
        Console.WriteLine ($"La primera letra de la cadena es {primeraLetra} y la letra despues del primer espacio es {letraTrasEspacio}");
    } // fin del main

    private static void IntercambiaParametros(int x, int y, out int a, out int b) //metodo ejercicio 5.7.1
    {
        b = x;
        a = y;
    }

    private static void Iniciales(string cadena, ref char char1, ref char char2)
    {
        char1 = cadena[0];
        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i] == ' ')
            {
                char2 = cadena[i + 1];
                break;

            }
        }
    }
}