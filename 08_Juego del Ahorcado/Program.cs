internal class Program
{
    private static void Main(string[] args)
    {

        char repetir = ' '; // char que sirve para repetir el juego completo o no en funcion de lo que introduzca por consola el usuario

        do
        {
            Console.WriteLine("Bienvenid@ al juego del ahorcado.");
            IniciarJuego();
            Console.WriteLine($"¿Quieres jugar otra vez? Sin ti, el próximo pirata no tendrá nadie que lo salve de la horca (Y/N)");         // Preguntar al jugador si quiere jugar otra vez
            // iba a hacer un switch pero me lo acabé cargando, siempre se guardaba 'y' y x tanto se repetia en bucle

            do
            {
                repetir = Console.ReadKey().KeyChar;
            }
            while (repetir != 'Y' && repetir != 'y' && repetir != 'N' && repetir != 'n');
            Console.WriteLine(); // Salto de línea para mejorar el formato

            if (repetir == 'N' || repetir == 'n')
            {
                Console.WriteLine("¡Hasta luego! Gracias por jugar con Kirultrón.");
            }

        } // fin del do principal

        while (repetir == 'y' || repetir == 'Y');
        {

        } // fin del do-while

    } // fin del Main

    static void IniciarJuego()
    {
        string cadena = "";
        string letra = "";
        bool isValidPlayer1 = false, isValidPlayer2 = false;
        bool fallo;
        int intentosP2 = 0; // contador para ver el numero de fallos que lleva el jugador 2
        bool juegoTerminado = false; // variable para checkear que el juego termina


        while (!isValidPlayer1) // variable o condicion para encontrar el break de manera factible, por cuestion de legibilidad del codigo para compañeros
        {
            Console.WriteLine("Player1, si eres tan amable, introduce la cadena para que Player2 pueda adivinarla.\nSolo puede contener letras. Los digitos deben ser escritos en forma numeral ");
            cadena = Console.ReadLine();

            if (!string.IsNullOrEmpty(cadena) && EsCadenaValida(cadena))
            {
                cadena = NoQueremosTildes(cadena);
                isValidPlayer1 = true; // mil veces mejor que un break (o 700)
            }
            else
            {
                Console.WriteLine("La cadena puede que esté vacia o que contenga digitos (los numeros deben ir por escrito).\nPor favor, introduce una cadena valida.");
                // Agrego mensajes de depuración
                // Console.WriteLine($"Valor actual de cadena: '{cadena}'");
                // Console.WriteLine($"Resultado de EsCadenaValida: {EsCadenaValida(cadena)}");
            }
        }

        string guionesForPlayer2 = CadenaAGuionesBajos(cadena);
        Console.WriteLine("La cadena para adivinar es la siguiente: " + guionesForPlayer2);

        Console.WriteLine("Player2, te toca jugar e introducir una letra. Recuerda que dispones de un máximo de 6 fallos.\n" +
            "Si te pasas, tu muñequito se habrá ahorcado a si mismo, no pudiendo continuar el juego por patoso.");


        while (intentosP2 < 6 && !juegoTerminado) // siempre que no se supere el limite de intentos y que el juego no termine, se ejecutará
        {
            letra = Console.ReadLine(); // se le pide al J2 que introduzca una letra
            fallo = true; //asumo que el jugador va a introducir una letra erronea

            if (!string.IsNullOrEmpty(letra) && EsCaracterValido(letra)) // se comprueba que la letra no esté vacia y sea valida (con la funcion EsCaracterValido)
            {
                for (int i = 0; i < cadena.Length; i++) // recorremos la cadena original
                {
                    if (!char.IsPunctuation(cadena[i]) && !char.IsWhiteSpace(cadena[i])) // chequeamos que el caracter de cadena no sea ni puntuacion ni un espacio en blanco)
                    {

                        if (char.ToLower(cadena[i]) == char.ToLower(letra[0])) // tras verificar, comprobamos la letra de cadena (esquivando problemas de mayus/minus) con la letra introducida, viendo si coinciden
                        {
                            //  Console.WriteLine($"Aqui la letra coincide y ahora, antes de pasar a false, fallo vale {fallo}"); Funciona bien, no se queda anclado ^^
                            fallo = false;
                            guionesForPlayer2 = guionesForPlayer2.Remove(i, 1); // procedemos a eliminar el guion bajo correspondiente, en la salida x consola 
                            guionesForPlayer2 = guionesForPlayer2.Insert(i, letra[0].ToString()); // insertamos la letra adivinada para que el jugador vea su progreso
                        }
                    }
                } 
                
                if (fallo) // solo si el jugador 2 ha fallado entonces
                {
                    intentosP2++; // sumamos uno al contador de fallos, llevará X intentos
                    Console.WriteLine($"Esa letra no aparece... Has perdido un intento y llevas {intentosP2} fallo/s..."); // intentos + 1 porque empieza a contar en 0
                    fallo = !fallo;
                    PirataAhorcado(intentosP2);
                    //  Console.WriteLine($"ahora fallo vale {fallo}"); No necesito seguir comprobandolo, funciona bien ^^
                }
                else
                {
                    Console.WriteLine($"¡Has encontrado una letra!\nLa cadena ahora queda como sigue: \n'{guionesForPlayer2.ToLower()}' \nIntroduce un nuevo caracter, ¡lo vas a lograr!"); // mostramos al Jugador2 la evolucion de su juego
                }

                if (guionesForPlayer2.ToLower() == cadena.ToLower())
                {
                    Console.WriteLine("\n¡¡¡FELICIDADES!!! ¡¡Has rellenado todos los huecos y has completado el juego!!\n");
                    Console.WriteLine($"Has acumulado un total de: {intentosP2} fallos \nLa ultima letra adivinada ha sido '{letra}'... \n...y la cadena por adivinar efectivamente era: '{cadena.ToLower()}'");
                    // Console.WriteLine($"La cadena actualizada de guiones bajos coincide, ya que ahora es: '{guionesForPlayer2.ToLower()}'");
                    juegoTerminado = true; // se corta el while principal, al cumplirse una de las condiciones.
                }
            }
            else // Cuando se introduce un espacio en blanco o algo que no es una letra
            {
                Console.WriteLine("El caracter introducido está vacio o no es una letra. Por favor, introduce un caracter valido.");
            }
        } // fin while intentos < 6 o juego no ha terminado

        if (!juegoTerminado) // llegamos aqui cuando se han alcanzado 6 fallos
        {
            Console.WriteLine("¡¡STOP THIS MASSACRE!! \nOh... Has alcanzado el máximo de 6 fallos y has perdido... \nHa perecido otro muñequito y esta ejecución ha terminado.");
        }
        return;
    }
    


    static bool EsCadenaValida(string cadena) // metodo para validar la cadena introducida por P1
    {
        foreach (char caracter in cadena)
        {
            if (!char.IsLetter(caracter) && !char.IsPunctuation(caracter) && !char.IsWhiteSpace(caracter))
            {
                return false;
            }
        }
        return true;
    }



    static string CadenaAGuionesBajos(string cadena) // metodo para mostrar por consola la cadena a adivinar por P2, en guiones
    {
        string resultado = "";

        foreach (char caracter in cadena)
        {
            if (char.IsLetter(caracter))
            {
                resultado += "_";
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                resultado += caracter;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        return resultado;
    }



    static bool EsCaracterValido(string letra) //metodo para verificar que P2 ha introducido unicamente una letra 
    {
        if (letra.Length == 1 && char.IsLetter(letra[0]))
        {
            char letraValidada = letra[0];
            // Console.WriteLine(letra[0]); ya no necesito comprobar, y me estaba sacando la letra duplicada todo el rato xD
            return true;
        }
        else
        {
            return false;
        }
    }

    static string NoQueremosTildes(string input)
    {
        string resultado = "";

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                // elimino las tildes
                char sinTilde = QuitarTilde(c);
                resultado += sinTilde;
            }
            else
            {
                resultado += c;
            }
        }
        return resultado;
    }

    static char QuitarTilde(char c)
    {
        string conAcento = "áéíóúÁÉÍÓÚ";
        string sinAcento = "aeiouAEIOU";
        int indice = conAcento.IndexOf(c);

        if (indice >= 0)
        {
            return sinAcento[indice];
        }
        return c;
    }

    static void PirataAhorcado(int input)
    {
        switch (input)
        {
            case 1:
                Console.WriteLine("   ____________");
                Console.WriteLine("   |          |");
                Console.WriteLine("   |          O");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                break;
            case 2:
                Console.WriteLine("   ____________");
                Console.WriteLine("   |          |");
                Console.WriteLine("   |          O");
                Console.WriteLine("   |          |");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                break;
            case 3:
                Console.WriteLine("   ____________");
                Console.WriteLine("   |          |");
                Console.WriteLine("   |          O");
                Console.WriteLine("   |         /|");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                break;
            case 4:
                Console.WriteLine("   ____________");
                Console.WriteLine("   |          |");
                Console.WriteLine("   |          O");
                Console.WriteLine("   |         /|\\");
                Console.WriteLine("   |");
                Console.WriteLine("   |");
                break;
            case 5:
                Console.WriteLine("   ____________");
                Console.WriteLine("   |          |");
                Console.WriteLine("   |          O");
                Console.WriteLine("   |         /|\\");
                Console.WriteLine("   |         / ");
                Console.WriteLine("   |");
                break;
            case 6:
                Console.WriteLine("   ____________");
                Console.WriteLine("   |          |");
                Console.WriteLine("   |          O");
                Console.WriteLine("   |         /|\\");
                Console.WriteLine("   |         / \\");
                Console.WriteLine("   |");
                break;
            default:
                Console.WriteLine("¡El Pirata ha dejado de respirar!");
                break;
        }
    }

} // fin del internal class Program

/*
 "Te presentamos el juego del ahorcado. Player1, escribe la palabra para que Player2 la averigue

V 1. Mensaje de bienvenida al juego

V 2. Solicitar que Player1 introduzca una palabra para que Player2 la adivine
V -2.1 Verificar que la palabra es valida (sea efectivamente una o varias palabras, no numeros ni simbolos.
    Puede tener signos de puntuacion, pero eso el player2 no tendrá que adivinarlo y se mostrarán en pantalla)
V -2.2 Convertir la cadena de player1 en guiones bajos suficientes ____, ______ (por ejemplo)
    para que el player2 visualice el numero de caracteres y cada vez que intente una nueva letra, se actualice

V 3. Solicitar una letra a player2
V  -3.1 verificar que la letra es valida, no un numero o simbolo ni nada que no sea una letra
V todo 4/12/2023 -3.2 adaptar el problema de mayusculas y minusculas, mostrando la primera letra en mayuscula en el juego pero que no haya diferencia entre adivinar por ejemplo "A" o "a".

todo 4. que por cada fallo que tenga player2, se vaya dibujando la figurita del ahorcado, hasta un maximo de 7 fallos. Al septimo, perderá la partida.
V -4.1 mensaje de "has perdido EL JUEGO"
V -4.2 preguntar si quiere volver a jugar, en cuyo caso pueda reiniciar la partida:
V --4.2.1 si quiere volver a jugar, que se reinicie la partida
V --4.2.2 si no, mensaje de despedida

V 5. por cada acierto que tenga player2, colocar la letra introducida TANTAS VECES como aparezca en la cadena. Si la cadena es "Hola, qué tal?" y player2 escribe "A" que aparezca "___a, ___ _a_?"

V 6. que por cada acierto de player2, el juego compruebe si ha acertado la cadena al completo

V 7. Una vez player2 adivina la cadena, mostrar por pantalla la cadena que originalmente escribió player1 y felicitar + pulse cualquier tecla para salir del juego. 
 
 
 
 */




/* TODO CODIGO ANTIGUO While para ver si letra introducida es valida, viejo
while (!isValidPlayer2) // variable o condicion para encontrar el break de manera factible, por cuestion de legibilidad del codigo para compañeros
{
    letra = Console.ReadLine();

    if (!string.IsNullOrEmpty(letra) && EsCaracterValido(letra))
    {
        isValidPlayer2 = true; // mil veces mejor que un break (o 700)
    }
    else
    {
        isValidPlayer2 = false;
        Console.WriteLine("El caracter introducido está vacio o no es una letra. Por favor, introduce un caracter valido.");
        // Agrego mensajes de depuración
        // Console.WriteLine($"Valor actual de cadena: '{cadena}'");
        // Console.WriteLine($"Resultado de EsCadenaValida: {EsCadenaValida(cadena)}");
    }
}


string cadenaAdivinada = "";

;
foreach (char caracter in cadena)

{
    if (caracter.Equals(letra))
    {
        cadenaAdivinada += letra;
    }
    else
    {
        cadenaAdivinada += caracter;
    }
}
*/
