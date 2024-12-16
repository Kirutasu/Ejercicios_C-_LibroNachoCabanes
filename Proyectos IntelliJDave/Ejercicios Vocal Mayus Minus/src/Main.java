import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        // Haz un programa que compruebe si un caracter es una vocal y otro que compruebe si es una letra, y si es mayus o minus;
        char character = ' ';
        boolean isInputAllowed = false;
        Scanner writeKeyboard = new Scanner(System.in);

        System.out.println("Introduce un caracter");
        while (!isInputAllowed) {
            String input = writeKeyboard.next();
            if (input.length() == 1) {
                character = input.charAt(0);
                isInputAllowed = true;
            } else {
                System.out.println("Por favor, introduce un único caracter");
            }
        }

        if (character >= 65 && character <= 90 || character >= 97 && character <= 122
                || character == 209 || character == 241) { //TODO conflicto Ñ: en ASCII es 164 o 165, pero por codigo HTML es &#209 o &#241
            System.out.println("Para empezar: El caracter introducido es una letra!");
            if (character >= 65 && character <= 90 || character == 209) {
                System.out.println("Siguiente: La letra introducida, además, está en Mayúscula");
            } else {
                System.out.println("Siguiente: La letra introducida, ademas, está en minúscula");
            }
            switch (character) {
                case 65:
                case 69:
                case 73:
                case 79:
                case 85:
                case 97:
                case 101:
                case 105:
                case 111:
                case 117:
                    System.out.println("Por último: El caracter introducido es, además, es una vocal");
                    break;
                default:
                    System.out.println("Por último: El caracter introducido, NO es una vocal");
                    break;

            }
        } else {
            System.out.println("Para empezar: El caracter introducido NO es una letra");
        }

        System.out.println("Et voilá! Hasta aquí el proyecto piticlín, realizado y ejecutado. " + '\n' + "Gracias por su tiempo Master Dave");
    }
}