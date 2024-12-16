namespace _11__4._4._3._5_Multiplicar_enteros_30_cifras_input_cadena;
class Program
{
    static void Main(string[] args)
    {
        /*

        (4.4.3.5) Un programa capaz de multiplicar dos números enteros muy grandes
        (por ejemplo, de 30 cifras), que se deberán pedir como cadena de texto y analizar
        letra a letra.

        -1 pedir dos numeros enteros de la longitud que quieras
        -2 verificar que tienen la misma longitud añadiendo 0s a la izq para poder sumar (todo o usar math.max, max.lenght, padleft...)
        -2.1 lo paso a digitos restando el valor de 0 en codigo ASCII
        -3 con carry, un bucle que recorra la longitud maxima (o en sencillo, 1a longitud de 1 de los array q ya es la misma)
        -4 con carry = 0, ir sumando cada digito y dividiendo entre 10 para que carry sea el entero sobrante.
        -5 en el bucle, ir iterando resultados para que sea resultado = suma + resultado
        -6 añadir el carry sobrante
        -7 pasar a y mostrar el string resultante

        */

        string numeroEntero1;
        string numeroEntero2;
        string resultado;

        Console.WriteLine("Ingrese el primer número entero muy grande:");
        numeroEntero1 = Console.ReadLine();

        Console.WriteLine("Ingrese el segundo número entero muy grande:");
        numeroEntero2 = Console.ReadLine();

        resultado = Sumar2StringsEnterosLargos(numeroEntero1, numeroEntero2);

        Console.WriteLine($"El resultado de sumar esos dos numeros largos es {resultado}");


    }

    static string Sumar2StringsEnterosLargos (string numeroEntero1, string numeroEntero2)
    {
        while (numeroEntero1.Length != numeroEntero2.Length)
        {
            if (numeroEntero1.Length < numeroEntero2.Length)
            {
                numeroEntero1 = '0' + numeroEntero1;
            }

            if (numeroEntero1.Length > numeroEntero2.Length)
            {
                numeroEntero2 = '0' + numeroEntero1;
            }
        }
      

        int acarreo = 0;
        string resultado = "";
        int suma; 

        for (int i = numeroEntero1.Length; i < 0; i--)
        {
            int digito1 = numeroEntero1[i] - '0';
            int digito2 = numeroEntero2[i] - '0';

            suma = digito1 + digito2 + acarreo; // sumo numeros con acarreo pendiente de haberlo

            acarreo = suma / 10; // solo se queda la parte entera sin decimal, q es lo que me interesa
            int digitoResultado = suma % 10; // solo se queda el resto, que es el digito de la suma sin el acarreo 

            resultado = digitoResultado.ToString() + resultado; // paso a string el digito, itero resultado actual con siguiente de bucle for

        }

        if (acarreo > 0)
        {
            resultado = acarreo.ToString() + resultado;
        }

        return resultado;
    }
}

