using System;

namespace Capitulos123
{
    class Program
    {
        static void Main(string[] args) 
        {
            Tareas();
        }
        static void Tareas()
        {                        
            // Mostramos el menú
            Console.WriteLine("1. Capitulo I");
            Console.WriteLine("2. Capitulo II");
            Console.WriteLine("3. Capitulo III");             
            Console.Write("Que operación deseas hacer: ");            

            int opcion;
            opcion = int.Parse(Console.ReadLine());            
            switch (opcion)
            {                
                case 1: //Aqui verificamos el capitulo 1 
                    Console.Clear(); //para limpiar pantalla
                    Console.WriteLine("\nMi nombre es: Anderson Rodriguez Molina"); //Ejercicio 1 CAP1 Cree un proyecto nuevo que imprima su nombre en la ventana de la consola
                    Console.Write("Mi matricula es: 2017-0035."); //Ejercicio 5 CAP1 Agregue más mensajes a la aplicación que ha creado.
                    Console.ReadKey();//system pause
                    break;
                 
                case 2:// Aqui verificamos el capitulo 2  
                    Console.Clear(); //para limpiar pantalla
                    Console.WriteLine("\n1. Calcular el perimetro de un poligono");
                    Console.WriteLine("2. Tranformar de grados a radianes");
                    Console.WriteLine("3. Tansformar de centigrados a grados Fahrenheit");
                    Console.WriteLine("4. Calcular dolares y euros");
                    Console.Write("Digite la opcion ");
                    int capitulo2;
                    capitulo2 = int.Parse(Console.ReadLine());
                    switch (capitulo2)
                    {
                        case 1://Ejercicio 1 CAP2 Hacer un programa que calcule el perímetro de cualquier polígono regular.
                            Console.Clear(); //para limpiar pantalla
                            int NumeroLadoPoligono;
                            int LongitudLadoPoligono;
                            int perimetro;

                            Console.WriteLine("Digite el numero de lado del poligono: ");
                            NumeroLadoPoligono = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite la longitud de lado del poligono: ");
                            LongitudLadoPoligono = int.Parse(Console.ReadLine());

                            perimetro = NumeroLadoPoligono * LongitudLadoPoligono;
                            Console.WriteLine($"El perimetro es: {perimetro}");
                            Console.ReadKey();//system pause
                            break;

                        case 2://Ejercicio 3 CAP2 Hacer un programa que transforme de grados a radianes.
                            Console.Clear(); //para limpiar pantalla
                            int grados;
                            double radianes;

                            Console.WriteLine("Digite el numero de grados: ");
                            grados = int.Parse(Console.ReadLine());

                            radianes = (grados * Math.PI / 180);
                            Console.WriteLine($"El resultado es: {radianes}");
                            Console.ReadKey();//system pause
                            break;

                        case 3://Ejercicio 4 CAP2 Hacer un programa que transforme de grados centígrados a grados Fahrenheit.
                            Console.Clear(); //para limpiar pantalla
                            double centigrados;
                            double fahrenheit;

                            Console.WriteLine("Digite el numero de grados centigrados: ");
                            centigrados = double.Parse(Console.ReadLine());

                            fahrenheit = (centigrados * 9 / 5)+32;
                            Console.WriteLine($"El resultado es: {fahrenheit}");
                            Console.ReadKey();//system pause
                            break;

                        case 4://Ejercicio 5 CAP2 Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.
                            Console.Clear(); //para limpiar pantalla
                            double dolares;
                            double cambio;
                            double euros;                            

                            Console.WriteLine("Digite el numero de dolar: ");
                            dolares = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite la tasa de cambio de euros del dia: ");
                            cambio = double.Parse(Console.ReadLine());

                            euros = (dolares * cambio);
                            Console.WriteLine($"El resultado es: {euros}");
                            Console.ReadKey();//system pause
                            break;
                    }
                    break;

                case 3://Aqui verificamos el capitulo 3
                    Console.Clear(); //para limpiar pantalla
                    Console.WriteLine("\n1. Decir si es par o impar");
                    Console.WriteLine("2. Decir el nombre del dia segun el numero correspondiente");                    
                    Console.Write("Digite la opcion ");
                    int capitulo3;
                    capitulo3 = int.Parse(Console.ReadLine());
                    switch (capitulo3)
                    {
                        case 1://Ejercicio 1 CAP3 Hacer un programa que le pida al usuario un número y la computadora responda si es par o impar.
                            Console.Clear(); //para limpiar 
                            int numero;
                            Console.WriteLine("Digite un numero: ");
                            numero = int.Parse(Console.ReadLine());

                            if(numero %2 == 0)
                            {
                                Console.WriteLine("El numero es par");
                            }
                            else
                            { 
                                Console.WriteLine("El numero es impar");                                
                            }

                            Console.ReadKey();//system pause
                            break;

                        case 2://Ejercicio 4 CAP3 Hacer un programa que le pida al usuario un número del 1 al 7 y escriba el nombre del día que corresponde ese número en la semana.
                            Console.Clear(); //para limpiar 
                            int dia;
                            Console.WriteLine("Digite un numero de 1 al 7 para saber el sia a que corresponde: ");
                            dia = int.Parse(Console.ReadLine());

                            switch (dia)
                            {
                                case 1:
                                    Console.WriteLine("Domingo");
                                    break;

                                case 2:
                                    Console.WriteLine("Lunes");
                                    break;

                                case 3:
                                    Console.WriteLine("Martes");
                                    break;

                                case 4:
                                    Console.WriteLine("Miercoles");
                                    break;

                                case 5:
                                    Console.WriteLine("Jueves");
                                    break;

                                case 6:
                                    Console.WriteLine("Viernes");
                                    break;

                                case 7:
                                    Console.WriteLine("Sabado");
                                    break;
                                default:
                                    Console.WriteLine("opcion no encontrada");
                                    break;
                            }
                            Console.ReadKey();//system pause
                            break;
                    }
                    break;

            }
            Console.Clear();
            Tareas();
        }
    }
}
