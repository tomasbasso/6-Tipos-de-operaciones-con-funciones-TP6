using System;

namespace Tipos_de_operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, opcion;
            string num1, num2;
            Console.Clear();
            Console.WriteLine("Seleccione operacion a realizar");
            Console.WriteLine("1=Suma ");
            Console.WriteLine("2=Resta ");
            Console.WriteLine("3=Multiplicacion ");
            Console.WriteLine("4=Division ");

            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4)
            {

                Console.WriteLine("Ingrese un numero");
                num1 = Console.ReadLine();
                numero1 = Convert.ToInt32(num1);
                Console.WriteLine("Ingrese otro numero");
                num2 = Console.ReadLine();
                numero2 = Convert.ToInt32(num2);
                Console.Clear();


                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("El resultado de su suma es {0}", suma(numero1, numero2));
                        break;
                    case 2:
                        Console.WriteLine("El resultado de su resta es {0}", resta(numero1, numero2));
                        break;
                    case 3:
                        Console.WriteLine("El resultado de su multiplicacion es {0}", multiplicacion(numero1, numero2));
                        break;
                    case 4:
                        if (numero2 == 0)
                        {
                            Console.WriteLine("Error su divisor es 0");
                        }
                        else
                        {
                            Console.WriteLine("El resultado de su division es {0}", division(numero1, numero2));
                        }

                        break;


                }
            }
            else Console.WriteLine("Numero invalido");


        }
        static int suma(int numero1, int numero2)
        {
            int resultado = 0;
            resultado = numero1 + numero2;
            return resultado;
        }
        static int resta(int numero1, int numero2)
        {
            int resultado = 0;
            resultado = numero1 - numero2;
            return resultado;
        }
        static int multiplicacion(int numero1, int numero2)
        {
            int resultado = 0;
            resultado = numero1 * numero2;
            return resultado;
        }
        static int division(int numero1, int numero2)
        {
            int resultado = 0;
            resultado = numero1 / numero2;
            return resultado;
        }
    }
}
