internal class Program
{
    private static void Main(string[] args)
    {
        string saludo = "Hola, nombre ¿Qué tal?";
        string subSaludo = saludo.Substring(3,6); //Funcion que coge el string y sera el valor de la posicion 4 (0, 1, 2, 3) y de LONGITUD 6
        string conejilloDeIndias;
        string nombre = "Kiru ";
        // para dividir string en palabras
        string[] palabras;
        char delimitador = ' ';

        saludo.IndexOf("Hola"); // mayus sensitive, pide el indice (donde empieza) del string indicado exactamente lo que busques
        saludo.IndexOf("Hola", 5); // mayus sensitive, pide exactamente lo que busques PERO añadimos el starindex que será donde empiece a buscar
        saludo.IndexOf("Hola", 5 , 10); // Busca el indice donde empieza, comienza a buscar en el indice 5 y buscara a lo largo de 10 indices/posiciones

        if (saludo.Contains("Hola")) // es un buleano, te dice si lo que le pides está. NO donde, no cuantas veces, solo si está.
        { }

        conejilloDeIndias = saludo.ToUpper(); // convierte a mayusculas
        Console.WriteLine(conejilloDeIndias);
        conejilloDeIndias = saludo.ToLower(); // a minusculas
        Console.WriteLine(conejilloDeIndias);
        conejilloDeIndias = saludo.ToLowerInvariant(); // aparentemente mismo resultado
        Console.WriteLine(conejilloDeIndias);

        conejilloDeIndias = saludo.Remove(4, 5); //Remueve desde el cuatro, 5 casillas/indices/posiciones
        Console.WriteLine(conejilloDeIndias);

        conejilloDeIndias = saludo.Insert(5, nombre); // inserta a partir del indice indicado, lo que le indiques. 
        conejilloDeIndias = saludo.Replace("nombre", nombre); // reemplaza allá donde encuentre lo que buscas, reemplaza TODOS, los q tengas
        
        palabras = saludo.Split(delimitador); // CUIDADO SPLIT puede dejar strings vacios, 
        for (int i=0; i < palabras.Length; i++)
        {
            Console.WriteLine(palabras[i]);
                }


        Console.WriteLine(conejilloDeIndias);
        Console.WriteLine(subSaludo);

        // sigue en el repositorio

        // el .CompareTo compara (prioridad: alfabeticamente (A<Z), cantidad de letras, mayusculas > minusculas) y devuelve un numero
        // negativo si el original es menor que el que entras, positivo si es mayor el nuevo, 0 si son iguales
        // hacer el juego del ahorcado:
        // jugador 1 que meta 1 palabra
        // jugador 2 tiene que adivinarla metiendo letras
        /* cada vez que acierte una letra, debe aparecer la palabra actualizada, tantas veces como letras haya
         * que haya limite de fallos
         * dibujito del ahorcado? buscar modelos en csharp para 7 fallos
         * 
         // ejemplo: jugador mete "Hola"
        // ____
        // jugador 2 mete 'a'
        // ___a
        // 
         */
       // evitar putadas
       // chequear si ha acertado todo
    }
}