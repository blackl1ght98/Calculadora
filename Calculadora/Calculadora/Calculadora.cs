using System;

namespace MisPracticasConC_.CalculadoraBasica
{
    public class Calculadora
    {
        public void Ejecutar()
        {
            do
            {
                Console.WriteLine("Calculadora basica");
                double numero1, numero2;
                bool datosCorrectos = false;

                do
                {
                    Console.WriteLine("Ingrese el primer numero: ");
                    if (double.TryParse(Console.ReadLine(), out numero1))
                    {
                        datosCorrectos = true;
                    }
                    else
                    {
                        Console.WriteLine("Datos no validos. Tiene que introducir un numero: ");
                    }
                } while (!datosCorrectos);

                datosCorrectos = false;
                do
                {
                    Console.WriteLine("Ingrese el segundo numero");
                    if (double.TryParse(Console.ReadLine(), out numero2))
                    {
                        datosCorrectos = true;
                    }
                    else
                    {
                        Console.WriteLine("Datos no validos. Tiene que introducir un numero: ");
                    }
                } while (!datosCorrectos);

                Console.WriteLine("Seleccione una operacion: ");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Raiz cuadrada");
                Console.WriteLine("6. Potencia");
                Console.WriteLine("7. Salir de la calculadora");
                Console.WriteLine("¿Que operacion desea realizar seleccione una opcion");
                int opcion;

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    double resultado = 0;

                    switch (opcion)
                    {
                        case 1:
                            resultado = numero1 + numero2;
                            break;
                        case 2:
                            resultado = numero2 - numero1;
                            break;
                        case 3:
                            resultado = numero1 * numero2;
                            break;
                        case 4:
                            if (numero2 != 0 && numero1 != 0)
                            {
                                resultado = numero1 / numero2;
                            }
                            else
                            {
                                Console.WriteLine("No se puede dividir entre 0");
                                continue;  // Salta al inicio del bucle para pedir nuevos datos
                            }
                            break;
                        case 5:
                            resultado = Math.Sqrt(numero1);
                            numero2 = 0;
                            break;

                        case 6:

                            resultado = Math.Pow(numero1, numero2);
                            break;

                        case 7:
                            Console.WriteLine("Saliendo de la calculadora...");
                            return;  // Sale del método Ejecutar
                        default:
                            Console.WriteLine("Opcion no valida");
                            continue;  // Salta al inicio del bucle para pedir nuevos datos
                    }

                    Console.WriteLine("El resultado de la operacion es: " + resultado);
                    Console.WriteLine("Desea realizar otra operacion? (Y/N)");
                    string opcion1 = Console.ReadLine();

                    if (opcion1.ToUpper() != "Y")
                    {
                        Console.WriteLine("Saliendo de la calculadora...");
                        return;  // Sale del método Ejecutar
                    }
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }

            } while (true);  // Bucle infinito, se sale cuando el usuario elige salir
        }
    }
}
