/*

01 Secuencias de escape C#

\a Emite un pitido
\b Retroceso (permite borrar el último carácter)
\f Avance de página (expulsa una hoja en la impresora)
\n Avanza de línea (salta a la línea siguiente)
\r Retorno de carro (va al principio de la línea)
\t Salto de tabulación horizontal
\v Salto de tabulación vertical
\' Muestra una comilla simple
\" Muestra una comilla doble
\\ Muestra una barra invertida
\0 Carácter nulo (NULL)

02 Metodos interesantes:
-Convertir un string de una letra a char
letra = Convert.ToChar(Console.ReadLine());

-Convertir un numero a base diferente (en este caso hexadecimal
Console.WriteLine( Convert.ToString(numero, 16) );

-Convertir un hexadecimal o binario, a decimal
Convert.ToInt32 (ojo diferencias c, c++ y csharp)

-Para manejar Strings podemos recurrir a un "StringBuilder", que sí permiten modificar cadena letra a letra pero
son algo más complejos de manejar: hay de reservarles espacio con "new" (igual que hacíamos en ciertas ocasiones con los Arrays),
y se pueden convertir a una cadena "convencional" usando "ToString":
Recuerda al inicio del codigo colocar
using System;
using System.Text; // Usaremos un System.Text.StringBuilder

-
 */