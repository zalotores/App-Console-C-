/*
Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

a. El mayor de los números pares.
b. La cantidad de números impares.
c. El menor de los números primos.

Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

Entregar carpeta comprimida del proyecto con el TP resuelto.
Poner nombre tanto al proyecto como al zip: TPFinal_Apellido >> por ejemplo: TPFinal_SarFernandez
*/

namespace TPFinal_Torres;
using System;       //para inicializar el valor minimo
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:\n");
        Console.WriteLine("a. El mayor de los números pares.");
        Console.WriteLine("b. La cantidad de números impares.");
        Console.WriteLine("c. El menor de los números primos.\n");

        Console.WriteLine("--------------------");

        int n, mayorPar = Int32.MinValue, cantImpar = 0, menorPrimo = Int32.MaxValue;

        n = leerInt();      //inicializo con el primer valor

        while (n != 0)
        {
            if ((n % 2) == 0)
            {
                if (n > mayorPar)
                {
                    mayorPar = n;
                }
            } else {
                cantImpar++;
            }

            if (esPrimo(n) && n < menorPrimo)
            {
                menorPrimo = n;
            }

            n = leerInt();

        }  

        Console.WriteLine("\n--------------------"); 
        Console.WriteLine("Resultados del lote\n");

        if (mayorPar == Int32.MinValue)
        {
            Console.WriteLine("No se ingresaron numeros pares.");
        } else {
            Console.WriteLine("El mayor de los números pares: " + mayorPar + ".");
        }
        
        Console.WriteLine("La cantidad de números impares: " + cantImpar + "."); 

        if (menorPrimo == Int32.MaxValue)
        {
            Console.WriteLine("No se ingresaron numeros primos.");
        } else {
            Console.WriteLine("El menor de los números primos: " + menorPrimo + ".");
        }

        //para ejecutar desde .exe
        Console.WriteLine("\n--------------------");
        Console.WriteLine("Programa terminado. Presione Enter para salir.");
        Console.Read();

    }

    //saco la lectura y validacion de numeros para hacer mas legible el programa
    static int leerInt()
    {
        int resultado = 0;
        bool flag = true;

        while (flag)
        {
            Console.Write("\nIngrese un numero: ");
            try
            {
                resultado = int.Parse(Console.ReadLine());
                flag = false;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Solo admite numeros!");
            }
        }

        return resultado;
    }

    static bool esPrimo(int n) {
        if (n < 0) { n = n * (-1);}
        if ((n == 0) || (n == 1)) { return false;}
        if(n == 2) { return true;}
        for (int i = 2; i < n; i++)
        {
            if ((n % i) == 0) { return false;}
        }
        return true;
    }

}
