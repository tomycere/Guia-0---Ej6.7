using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_0___Ej6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool esdia = false;
            bool esmes = false;
            bool esaño = false;
            string ingresodia;
            string ingresomes;
            string ingresoaño;
            var dia = 0;
            var año = 0;
            var mes = 0;
            var edad = 0;


            while (!esdia)
            {
                Console.Write("Ingrese su día de nacimiento:");
                ingresodia = Console.ReadLine();
                if ((int.TryParse(ingresodia, out dia)) && (dia > 0 && dia < 31))
                {
                    esdia = true;
                }
                else
                {
                    Console.WriteLine("El día ingresado no es válido");
                }

            }


            while (!esmes)
            {
                Console.Write("Ingrese su mes de nacimiento:");
                ingresomes = Console.ReadLine();
                if ((int.TryParse(ingresomes, out mes)) && (mes > 0 && mes <= 12))
                {
                    esmes = true;
                }
                else
                {
                    Console.WriteLine("El mes ingresado no es válido");
                }

            }


            while (!esaño)
            {
                Console.Write("Ingrese su año de nacimiento:");
                ingresoaño = Console.ReadLine();
                if ((int.TryParse(ingresoaño, out año)) && (año > 0))
                {
                    esaño = true;
                }
                else
                {
                    Console.WriteLine("El año ingresado no es válido");
                }

            }



            DateTime fecha = new DateTime(año, mes, dia);
            edad = (DateTime.Now.Subtract(fecha).Days)/360;
            Console.WriteLine($"Su edad es {edad}");
            Console.ReadKey();
        }
    }
}
