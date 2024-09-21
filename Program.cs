using System;

namespace EJERCICIO_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROMEDIO DE 3 NOTAS DE UN ALUMNO
            //PASO 0: DECLARA VARIABLES
            float N1, N2, N3, PROM;

            //PASO 1: INGRESAR NOTAS
            Console.WriteLine("INGRESE LA PRIMER NOTA: ");
            N1 = float.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA SEGUNDA NOTA: ");
            N2 = float.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA TERCER NOTA: ");
            N3 = float.Parse(Console.ReadLine());
            //PASO 2: CALCULAR PROMEDIO 
            PROM = (N1 + N2 + N3) / 3;

            //PASO 3: MOSTRAR EN PANTALLA
            Console.WriteLine("EL PROMEDIO DEL ALUMNO ES: " + PROM.ToString("0.00"));
        }
    }
}
