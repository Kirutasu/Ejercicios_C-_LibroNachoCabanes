internal class Program
{
    private static void Main(string[] args)
    {

        /*
         * 
        (3.2.6.4) Crea un programa que pida números binarios al usuario y muestre su
equivalente en sistema hexadecimal y en decimal. Debe repetirse hasta que el
usuario introduzca la palabra "fin".

        */

        // 1. pedir numero binario
        // 1.1 validar que entrada no esté vacia, sea numeros y no letras, ni simbolos etc metodos fuera del main
        // 1.1.1 Que solo sean binarios, es decir, solo 0 o 1). metodo fuera del main
        // 1.1.2 es binario si solo lleva 0,1, si longitud > 0 y que no lleve nada mas aparte de 0,1, fuera del main

        // 2. mostrar equivalente
        // 2.1 en hexadecimal
        // 2.2 en decimal
        // 3 bucle inicio, que se repita hasta que el usuario introduzca "fin"
        // 3.1 do while? siempre mostrar mensaje "para acabar, introduzca "fin"
        // 3.2 verificar fin en mayus minus y quitar puntuaciones
        
        string input;
        long entero;
        bool isBinaryValid;

        Console.WriteLine("Ingresa un numero binario, de máximo 19 digitos (entre el 0 y el 1111111111111111111).\nSi quieres salir, escribe 'fin'");

        /*     Lo que intentaba hacer mi cabeza >>
        while (!isBinaryValid) 
        {
            entero =  Int32.TryParse(Console.ReadLine(), out entero);

        }    Vs lo que habia que hacer >>
        */

        /*
        while (!long.TryParse(Console.ReadLine(), out entero))
        {
            Console.Write("Por favor, introduce un numero entero valido");  
        }


        if (IsBinaryValid(entero))
        {
            Console.WriteLine("Has introducido el siguiente numero binario:" + entero + "!");

        }
        else
        {
            Console.WriteLine($"El numero que has introducido no es un numero binario. (Solo puede contener 0 y 1)");
        }
        */

        do
        {
            input = "";
            entero = 2;
            isBinaryValid = false;
            do
            {
                input = Console.ReadLine().Trim().ToLower();

                if (input == "fin")
                {
                    Console.WriteLine($"Vuelva a ejecutar el código para volver a empezar. Muchas gracias y hasta luego");
                    return; // Saldrá del Main y termina el programa
                }
                 
                if (IsStringNotEmpty(input))
                {
                    if (IsInputADigit(input, ref entero))
                    {
                        if (IsBinary(input))
                        {
                            isBinaryValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Volvemos a empezar... Por favor, introduce un numero binario valido"); // orden?
                        }
                    }
                }

                //Console.WriteLine($"Entero vale: {entero}; input vale: {input}; isBinaryValid es {isBinaryValid} "); // orden?

                // LimitarLongMaxValue(ref entero);

            }
            while (!isBinaryValid); //no entiendo xk no funciona con AND, si sk es este el fallo (con and true/false/false y sale del dowhile... I dont get it)

            Console.WriteLine($"Has introducido el siguiente numero binario: {entero}!");
            Console.WriteLine($"Este numero, expresado en base hexadecimal es: {ConvertHexadecimal(entero)}!");
            Console.WriteLine($"Y por ultimo, este numero, expresado en base decimal es: {ConvertDecimal(input)}!");
            Console.WriteLine($"Introduce otro numero binario para convertir, o escribe 'fin'");

        }
        while (true);


    } // Fin del Main


    static bool IsStringNotEmpty (string input)
    {
        if (!string.IsNullOrEmpty(input))
        {
            return true;
        }
        else
        {
            Console.WriteLine("No has introducido ninguna entrada. Vuelve a intentarlo." + input); //cheking
            return false;
        }
    }

    static bool IsInputADigit(string input, ref long entero)
    {

        if (input.Length <= 19)
        {
            if (long.TryParse(input, out entero))
            {
                //Console.WriteLine("Se ha transformado input en entero >> "+entero); //checking
                return true;
            }
            else
            {
                Console.WriteLine("La entrada que has introducido no es un numero, y por supuesto no es binario."); //checking
                return false;
            }
        }
        Console.WriteLine("La longitud de la entrada supera el máximo permitido de 19 dígitos. Vuelve a intentarlo.");
        // maximo decimal debera salir 524287
        return false;

    }

    static bool IsBinary (string input)
    {

        foreach (char c in input)
        {
            if ( c != '0' && c != '1')
            {
                Console.WriteLine($"El numero que has introducido no es un numero binario. (Solo puede contener 0 y 1)");
                return false;
            }    
        }
        return true;
    }

    static void LimitarLongMaxValue(ref long entero)
    {
        if (entero > long.MaxValue)
        {
            entero = long.MaxValue;
        }
    }

    static string ConvertHexadecimal (long entero)
    {
        string enteroEnHexadecimal = "";

        return enteroEnHexadecimal = Convert.ToString(entero, 16);
    }

    static long ConvertDecimal(string input)
    {
        long enteroEnDecimal;

        return enteroEnDecimal = Convert.ToInt64(input, 2);
    }

}
/*.

>>> Ahora haces los de Structs

(4.4.7.1) Un programa que pida al usuario una frase y muestre sus palabras en
orden inverso.

(4.4.8.2) Un programa que pida al usuario cinco frases, las guarde en un array y
muestre la "mayor" de ellas.

(4.4.9.2) Un programa que pida una cadena al usuario y la modifique, de modo
que las letras de las posiciones impares (primera, tercera, etc.) estén en
minúsculas y las de las posiciones pares estén en mayúsculas, mostrando el
resultado en pantalla. Por ejemplo, a partir de un nombre como "Nacho", la
cadena resultante sería "nAcHo"

(4.5.2) Un programa que pida al usuario una frase y la descomponga en
subcadenas separadas por espacios, usando "Split". Luego debe mostrar cada
subcadena en una línea nueva, usando "foreach".

a por las funciones y clases! pag 156 o Tema 5
*/
