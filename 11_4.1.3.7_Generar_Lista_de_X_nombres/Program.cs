namespace _11_4._1._3._7_Generar_Lista_de_X_nombres;
class Program
{
    static void Main(string[] args)
    {
        /*
         * 
        (4.1.3.7) Un programa que prepare espacio para guardar un máximo de 100
        nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se
        pulse Intro sin teclear nada, momento en el que dejarán de pedirse más nombres
        y se mostrará en pantalla la lista de los nombres que se han introducido.

        1-inicializar un array de 100 posis
        2-pedir usuario nombre + intro o para acabar solo intro.
        3-verificar nombres
        4-ir guardando en array
        5-cuando solo intro, cerrar y recorrer/mostrar array

        */

        string[] enteros = new string[100];
        int totalLista = 0;
        bool continuarInsercion = true;
        string nombre = "";

        Console.WriteLine($"Introduce nombres para la lista. Cuando acabes, presiona simplemente intro.");



        while (continuarInsercion && totalLista < enteros.Length)
        {
            nombre = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                continuarInsercion = false;
            }

            else if (EsNombreValido(nombre))
            {
                enteros[totalLista] = nombre;
                Console.WriteLine($"El nombre almacenado ahora es {enteros[totalLista]}");
                totalLista++;
            }

            else
            {
                Console.WriteLine("Introduce otro");
            }
        }

        Console.WriteLine($"Has terminado de crear la lista, que tiene {totalLista} elementos. A continuacion se muestra la lista generada.");

        for (int i = 0; i < totalLista; i++)
        {
            Console.WriteLine(enteros[i]);
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