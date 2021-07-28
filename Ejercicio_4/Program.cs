using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variable. 

            double gradosc, gradosf, divi, resul;

            // Capturacion de datos. 

            Console.WriteLine("INGRESE LOS GRADOS CENTIGRADOS: ");
            gradosc = Convert.ToInt32(Console.ReadLine());

            // Operaciones. 

            resul = gradosc * 9;
            divi = resul / 5;

            gradosf = divi + 32; 
            Console.WriteLine(" ");
            Console.WriteLine("LOS GRADOS FAHRENHEIT SON: {0}", gradosf);
         
            Console.ReadKey(); 
        }
    }
}
