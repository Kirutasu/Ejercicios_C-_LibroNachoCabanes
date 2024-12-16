using System;

namespace _11_4._1._2._1_Tabla_mes_número_de_días;
class Program
{
    static void Main(string[] args)
    {
        /*
         * 
        (4.1.2.1) Un programa que almacene en una tabla el número de días que tiene
        cada mes (supondremos que es un año no bisiesto), pida al usuario que le indique
        un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que
        tiene ese mes.

        Yo SI lo hago bisiesto BC 2024
        1-array de los 12 meses
        2-pedir 1-12 al usuario
        3-mostrar esa posicion del array

        */
        int[] mesesDelAño = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int mesElegido;

        Console.WriteLine($"Bienvenido a meses del año 2024:\nPara averiguar cuantos dias tiene el mes elegido, introduce un numero entre 1 para Enero y 12 para Diciembre.");

        while (!Int32.TryParse(Console.ReadLine(), out mesElegido) || mesElegido < 1 || mesElegido > 12) //combinamos y optimizamos aqui 2 whiles en 1
        {
            Console.WriteLine($"Recuerda que debes escribir un numero entero (entre 1 y 12)");
        }

        // Se puede hacer con 2 whiles pero o bien introduces otro console.read y puede traer mas errores (meter 98, y luego un no entero etc... mas a controlar
        //mejor quitar 2 whiles y dejarlo en 1 combinado
        /*
        while (mesElegido > 12 || mesElegido < 1)
        {
            Console.WriteLine($"Elige un numero entre 1 (Enero) y Diciembre (12)");
        }
        Console.WriteLine($"dale, continua");
        */

        switch (mesElegido)
        {
            case 1:
                Console.WriteLine($"El mes seleccionado ({mesElegido}) es ENERO, que en el año 2024 tiene {mesesDelAño[mesElegido - 1]} días");
                break;
            case 2:
                Console.WriteLine($"El mes seleccionado ({mesElegido}) es FEBRERO, que en el año 2024 tiene {mesesDelAño[mesElegido - 1]} días");
                break;
            case 3:
                Console.WriteLine($"El mes seleccionado ({mesElegido}) es MARZO, que en el año 2024 tiene {mesesDelAño[mesElegido - 1]} días");
                break;
            case 4:
                Console.WriteLine($"El mes seleccionado ({mesElegido}) es ABRIL, que en el año 2024 tiene {mesesDelAño[mesElegido - 1]} días");
                break;
            case 5:
                Console.WriteLine($"El mes seleccionado ({mesElegido}) es MAYO, que en el año 2024 tiene {mesesDelAño[mesElegido - 1]} días");
                break;
            case 6:
                Console.WriteLine($"El mes seleccionado ({mesElegido}) es JUNIO, que en el año 2024 tiene {mesesDelAño[mesElegido - 1]} días");
                break;
            case 7:
                Console.WriteLine($"El mes seleccionado ({mesElegido}) es JULIO, que en el año 2024 tiene {mesesDelAño[mesElegido - 1]} días");
                break;
            case 8:
                Console.WriteLine($"El mes seleccionado ({mesElegido}) es AGOSTO, que en el año 2024 tiene {mesesDelAño[mesElegido - 1]} días");
                break;
            case 9:
                Console.WriteLine($"El mes seleccionado ({mesElegido}) es SEPTIEMBRE, que en el año 2024 tiene {mesesDelAño[mesElegido - 1]} días");
                break;
            case 10:
                Console.WriteLine($"El mes seleccionado ({mesElegido}) es OCTUBRE, que en el año 2024 tiene {mesesDelAño[mesElegido - 1]} días");
                break;
            case 11:
                Console.WriteLine($"El mes seleccionado ({mesElegido}) es NOVIEMBRE, que en el año 2024 tiene {mesesDelAño[mesElegido - 1]} días");
                break;
            case 12:
                Console.WriteLine($"El mes seleccionado ({mesElegido}) es DICIEMBRE, que en el año 2024 tiene {mesesDelAño[mesElegido - 1]} días");
                break;
        }
        Console.ReadLine();
    }

}

