using _09_ManejoDeConstructores;

internal class PruebaDeTrabajadores
{
    private static void Main (string[] args)
    {
        Analista analista = new Analista();
        Ingeniero ingeniero = new Ingeniero();
        IngenieroInformatico ingenieroInformatico = new IngenieroInformatico();
        Programador programador = new Programador();
        Trabajador trabajador = new Trabajador();

    }

}


/*
 *
 Una clase Trabajador, cuyo constructor escriba en pantalla "Soy un
trabajador".
 Una clase Programador, que derive de Trabajador, cuyo constructor escriba
en pantalla "Soy programador".
 Una clase Analista, que derive de Trabajador, cuyo constructor escriba en
pantalla "Soy analista".
 Una clase Ingeniero, que derive de Trabajador, cuyo constructor escriba en
pantalla "Soy ingeniero".
 Una clase IngenieroInformatico, que derive de Ingeniero, cuyo constructor
escriba en pantalla "Soy ingeniero informático".
 Una clase "PruebaDeTrabajadores", que cree un objeto perteneciente a
cada una de esas clases.
*/