/*
 * Arrays, cajones donde puedo guardar lo que sea
 * matrices de 1xN
 * 
 * Tipo de variable, corchetes y nombre. Al inicianizarlo hay que declarar el tamaño
 * Ej: int[] numeros = new int [5]; array de tamaño 5
 * Se puede inicializar de esta otra manera tambien
 * int [] numeros = {5, 7, 42, 69, 3}; 
 * Para leer el array >> FOR
 * console.readline y nombre del array NO te imprime el contenido
 * For donde nombreDeArray.lenght 
 * 
 * Pueden ser arrays de Strings, arrays de arrays...
 * 
 *int[][] calificaciones = new int [5][];
 *calificaciones[0] = new int[7];
 *calificaciones[1] = new int[10];
 *calificaciones[2] = new int[5];
 *...
 *
 *CREA UN ARRAY de 5 ints, pedir user que lo rellene
 *decir cual es el mayor de los datos introducidos
 *
 *
 *
 * LENGUAJE DE PROGRAMACION CONOCIDO HASTA AHORA: Son palabras que debes utilizar
 * a tu favor para pensar y obtener los procesos/soluciones deseados.
 * 
 * Si (if)
 * Si no (!if)
 * Mientras (while)
 * Para (for...)
 * Y (&&)
 * O (||)
 * NO (!)
 * 
 * 
 * Como pensar:
 * Quiero que mientras (NO) sea un numero, introduce otro valor
 * 
*/
/*TODO quita este comentario
int[] myArray = new int [5];
int numMaximo = Int32.MinValue;

for (int i=0; i < myArray.Length; i++)
{
    Console.WriteLine("Introduce un valor para tu array");

    while (!Int32.TryParse(Console.ReadLine(), out myArray[i]))
    {
    }
    if (myArray[i] >= numMaximo || i==0)
    {
        numMaximo = myArray[i];
    }
}
Console.WriteLine($"El numero maximo de este array es {numMaximo}");
Console.ReadLine();
*///TODO
// UN ARRAY DE ARRAY DE DOS filas
// el primero de 5 columnas y el segundo 3
// pedir que introduzcas todos los numeros
// decir cual es el mayor de cada array por separado
//int[][] calificaciones = new int[5][];

int[][] calificacionesClasesAyB = new int[2][];
calificacionesClasesAyB[0] = new int[5];
calificacionesClasesAyB[1] = new int[3];
int maximoArray1 = int.MinValue;
int maximoArray2 = int.MinValue;

Console.WriteLine("Introduce 5 numeros para el primer array, y 3 mas para el segundo");
for (int i=0; i < calificacionesClasesAyB.Length; i++)
{
    for (int j = 0; j < calificacionesClasesAyB[i].Length; j++)
    {
        while (!Int32.TryParse(Console.ReadLine(), out calificacionesClasesAyB[i][j]))
        {
            Console.WriteLine("Introduce un numero valido");
        }

        /*
        while (j == 0)
        {
            if (calificacionesClasesAyB[i][j] > maximoArray1)
            {
                maximoArray1 = calificacionesClasesAyB[i][j];
                Console.WriteLine("Ahora mismo el valor maximo del array 1 es:" + maximoArray1);
            }
        }
        while (j == 1)
        {
            if (calificacionesClasesAyB[i][j] > maximoArray2)
            {
                maximoArray2 = calificacionesClasesAyB[i][j];
                Console.WriteLine("Ahora mismo el valor maximo del array 2 es:" + maximoArray2);

            }
        }
        */
    }
        if (i == 0)
        {
            for (int j = 0; j < calificacionesClasesAyB[i].Length; j++)
            {
                if (calificacionesClasesAyB[i][j] > maximoArray1)
                {
                    maximoArray1 = calificacionesClasesAyB[i][j];
                }
            }
            Console.WriteLine("Ahora mismo el valor maximo del array 1 es:" + maximoArray1);
        }
        else if (i == 1)
        {
            for (int j = 0; j < calificacionesClasesAyB[i].Length; j++)
            {
                if (calificacionesClasesAyB[i][j] > maximoArray2)
                {
                    maximoArray2 = calificacionesClasesAyB[i][j];
                }
            }
            Console.WriteLine("Ahora mismo el valor maximo del array 2 es:" + maximoArray2);
        }
}
// Console.WriteLine("El primer array es: " + calificacionesClasesAyB[0] + "y el segundo array es" + calificacionesClasesAyB[1]);
// Para mostrar los valores de un array de arrays por consola, habra que recorrer cada posicion de ese array con uon o varios bucles for anidados
Console.WriteLine("Los valores del array son: ");
for (int i = 0; i < calificacionesClasesAyB.Length; i++)
{
    for (int j = 0; j < calificacionesClasesAyB[i].Length; j++)
    {
        Console.WriteLine("Para la posicion [" + i + "][" + j + "] =" + calificacionesClasesAyB[i][j]);
    }
}

Console.WriteLine("El numero maximo del primera array es: " + maximoArray1 + " y el del segundo array es: " + maximoArray2);
// Console.WriteLine("Int minValue es: " + int.MinValue);



// For Each
// parecido al for
//como una variable temporal en cada indice voy a meter el valor del array, no necesitas indices
// no puedes meter una segunda condicion, no se puede jugar tanto
foreach (int numero  int numeros)
 {
    numero++;
 } 