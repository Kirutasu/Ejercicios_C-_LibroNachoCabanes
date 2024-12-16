// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// pida un caracter y dibuje un cuadrado de 5x5 de ese caracter
/* TODO QUITA ESTE COMENTARIO!! 
char caracter = ' ';
int filas = 5, columnas = 5;
Boolean isCharacterAllowed = false;

Console.Write("Introduce un caracter");
while (!Char.TryParse(Console.ReadLine(), out caracter))
{
    Console.WriteLine("Por favor, introduce un unico caracter");

}
for (int i = 0; i < filas; i++)
{
    if (i == 0 || i == filas - 1)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write(caracter);
        }
    }
    else
    {
        for (int j = 0; j < 5; j++)
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
*/
/* Has recorrido cada una de las filas con el primer for
 * Como solo te interesa escribir en la primera y la ultima
 * un if para seleccionarlas. DENTRO un UNICO bucle for para recorrer las COLUMNAS 
 * y escribir el caracter en cada posicion.
 * 
 * Segunda parte: Has recorrido las filas RESTANTES
 * como tienes que escribir en parte de ellas el caracter y en 
 * la otra parte NADA, haces un IF con DOS secciones, una para las columnas inicial y final
 * y otra para las columnas restantes donde solo escribes '_'
 */

//DIBUJA UN TRIANGULO DE NxN DONDE
// 55555
// 5555
// 555
// 55
// 5


int filasYColumnas;
int contador;

Console.WriteLine("Introduce un numero");
while (!Int32.TryParse(Console.ReadLine(), out filasYColumnas))
{
    Console.WriteLine("Por favor, introduce un único numero");
}
Console.WriteLine($"El valor escogido es {filasYColumnas}, generando la forma triangular correspondiente");
contador = filasYColumnas;
for (int i = contador; i > 1; i--)
{
    for (int j=contador; j > 1; j--)
    {
        Console.Write(filasYColumnas);
    }
    Console.WriteLine();
    contador--;
}
Console.WriteLine("Et voilá! Y lo he hecho sin probar ni una sola gota de ron!");
