namespace _11_4._1._4._5_Menú_Añadirdato_InsertarDesplazar_BorrarDesplazar_Salir;
class Program
{
    static void Main(string[] args)
    {
        /*
         * 
        (4.1.4.5) Crea un programa que prepare espacio para un máximo de 10 nombres.
        Deberá mostrar al usuario un menú que le permita realizar las siguientes
        operaciones:
         Añadir un dato al final de los ya existentes.
         Insertar un dato en una cierta posición (como ya se ha comentado, los que
        quedén detrás deberán desplazarse "a la derecha" para dejarle hueco; por
        ejemplo, si el array contiene "hola", "adios" y se pide insertar "bien" en la
        segunda posición, el array pasará a contener "hola", "bien", "adios".
         Borrar el dato que hay en una cierta posición (como se ha visto, lo que
        estaban detrás deberán desplazarse "a la izquierda" para que no haya
        huecos; por ejemplo, si el array contiene "hola", "bien", "adios" y se pide
        borrar el dato de la segunda posición, el array pasará a contener "hola",
        "adios"
         Mostrar los datos que contiene el array.
         Salir del programa.

            1-Array 10 huecos
            2-Mostrar menu
            2.1 Elegir 1 Añadir, 2 Insertar 3 Borrar 4 Mostrar 5 Salir
            2.1.1 Validar eleccion
            3-Añadir final
            4-Insertar desplazando
            5.Borrar retrocediendo
            6.Mostrar array
            7 Salir con despedida

        */
        string[] cadena = new string[10];
        string nombre = "";
        int cantidadDatos = 0;
        int limiteDatos = 10;
        int accionElegida = 0;
        bool finJuego = false;

        do
        {
            Console.WriteLine($"Presiona la tecla numerica correspondiente a la acción que quieres realizar entre las siguientes: \n1. Añadir nombre a la lista \n" +
                          $"2. Insertar dato en posicion X\n3. Borrar dato en posicion X\n4. Mostrar listado\n5. Salir del programa");
            IniciarMenu(ref finJuego, ref cadena, ref nombre, ref cantidadDatos, ref limiteDatos, ref accionElegida);

        } // fin del do principal

        while (!finJuego);
        {
            Console.WriteLine("¡Hasta luego!");
        } // fin del do-while

    }

    static void IniciarMenu (ref bool finJuego, ref string[] cadena, ref string nombre, ref int cantidadDatos, ref int limiteDatos, ref int accionElegida)
    {
       

        while (!Int32.TryParse(Console.ReadLine(), out accionElegida))
        {
            Console.WriteLine("Por favor, introduce una tecla entre el 1 y el 5 para solicitar la accion que quieres realizar");
        }

        switch (accionElegida)
        {
            case 1:
                Console.WriteLine($"Has elegido añadir un nombre a la lista. ¿Qué nombre quieres añadir?");

                nombre = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(nombre))
                {
                    Console.WriteLine($"El nombre no puede estar vacío ni contener espacios. Introduce un nombre valido");
                }

                if (EsNombreValido(nombre))
                {
                    cadena[cantidadDatos] = nombre;
                    Console.WriteLine($"El nombre almacenado ahora es {cadena[cantidadDatos]}");
                    cantidadDatos++;
                }
                break;

            case 2:
                int posicionInsertar = 0;
                string datoInsertado = "";

                Console.WriteLine($"Has elegido insertar un dato. ¿En qué posicion quieres insertarlo?");
                while (!Int32.TryParse(Console.ReadLine(), out posicionInsertar))
                {
                    Console.WriteLine($"No te he entendido. Introduce un numero equivalente a la posicion donde lo quieres insertar");
                }

                if (posicionInsertar-1 < cantidadDatos)
                {
                    Console.WriteLine($"Introduce el nombre que quieres insertar");
                    datoInsertado = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(datoInsertado))
                    {
                        Console.WriteLine($"El nuevo nombre no puede estar vacío ni contener espacios. Introduce un nombre valido");
                    }

                    if (EsNombreValido(datoInsertado))
                    {
                        if (posicionInsertar == 1) // Si se inserta en la primera posición
                        {
                            for (int i = cantidadDatos; i > 0; i--)
                            {
                                cadena[i] = cadena[i - 1];
                            }
                            cadena[0] = datoInsertado; // Insertar el nuevo dato en la primera posición
                            cantidadDatos++;
                        }
                        else
                        {
                            for (int i = cantidadDatos; i >= posicionInsertar - 1; i--)
                            {
                                cadena[i+1] = cadena[i];
                            }
                            cadena[posicionInsertar - 1] = datoInsertado;
                            cantidadDatos++;
                        }
                        Console.WriteLine($"El nombre almacenado ahora es {cadena[posicionInsertar-1]}");
                    }
                }

                else
                {
                    Console.WriteLine($"Esa posicion está vacia en la lista y no puede insertarse, debe ser añadida primero.");
                }
                break;

            case 3:
                int posicionBorrar = 0;

                Console.WriteLine($"Has elegido borrar un dato. ¿Qué posicion quieres borrar?");
                while (!Int32.TryParse(Console.ReadLine(), out posicionBorrar))
                {
                    Console.WriteLine($"No te he entendido. Introduce un numero equivalente a la posicion del dato que quieres borrar");
                }

                if (posicionBorrar - 1 < cantidadDatos)
                {
                       /* if (posicionBorrar == 1) // Si se inserta en la primera posición
                        {
                            for (int i = cantidadDatos; i > 0; i--)
                            {
                                cadena[i] = cadena[i - 1];
                            }
                            cadena[0] = datoInsertado; // Insertar el nuevo dato en la primera posición
                            cantidadDatos++;
                        }
                        else
                        {*/
                            for (int i = posicionBorrar; i <= cantidadDatos - 1; i++)
                            {
                                cadena[posicionBorrar-1] = cadena[posicionBorrar];
                            }
                            cadena[cantidadDatos-1] = null;
                            cantidadDatos--;
                        //}
                        Console.WriteLine($"El nombre que ocupa la posicion {posicionBorrar} ahora es {cadena[posicionBorrar -1]}");
                               }

                else
                {
                    Console.WriteLine($"Esa posicion está vacia en la lista y no puede borrarse, debe ser añadida primero.");
                }
                break;
            
            case 4:
                for (int i = 0; i < cantidadDatos; i++)
                {
                    Console.WriteLine(cadena[i]);
                }

                break;

            case 5:
                finJuego = true;
                break;

            default:
                Console.WriteLine("¡No he entendido esta acción! Se saldra del programa por defecto.");
                break;
        }
    }

    static bool EsNombreValido(string nombre)
    {
        foreach (char c in nombre)
        {
            if (!char.IsLetter(c))
            {
                Console.WriteLine($"El nombre solo puede contener letras. Si es un nombre compuesto, escribe el segundo nombre junto con la primera letra mayuscula (Ejemplo 'JoseAntonio')");
                return false;
            }
        }
        return true;
    }
}


