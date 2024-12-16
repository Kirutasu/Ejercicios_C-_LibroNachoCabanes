//Arrays N dimensionales

int filas = 3, columnas = 2;
int[,] numeros = new int[filas, columnas];
// de manera literal se puede declarar asi
// int[,] numeros =
// {
// {1,2},
// {4,5},
// {7,8}
// }

// hay que recorrerlos con for anidados, solo es una coleccion de datos, no es que tengan arrays dentro. Puede ser tridimensional, cuadrimensional

for (int i=0; i<filas; i++)
{
    for (int j=0; j<columnas; j++)
    {
        numeros[i, j] = i + j;
        Console.Write(numeros[i, j]);
    }
    Console.WriteLine();
}

// libro pagina 123 ejercicios propuestos