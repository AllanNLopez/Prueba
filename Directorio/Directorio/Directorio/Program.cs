using Directorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Directorio
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Persona persona = new Persona();            //Declaracion e instanciacion de la clase Persona
            Marcador marcador = new Marcador();         //Declaracion e instanciacion de la clase Marcador

            //Declaracion de objeto List
            List<string> frutas = new List<string>();

            frutas.Add("Manzana");
            frutas.Add("Pera");

            Console.WriteLine(frutas[0]);
            Console.WriteLine(frutas[1]);

            //Estructura de repeticion for each para recorrer una lista
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            string nombrecompleto = string.Empty;       //Inicia una cadena de texto vacia.

            persona.setNombre("Pedro Antonio");
            persona.setApellidos("Perez Perez");

            nombrecompleto = persona.getNombreCompleto(); 
            Console.WriteLine("Persona 1" + nombrecompleto + "Salario: "+ marcador.getSalario(44*4));

            nombrecompleto = persona.getNombreCompleto("Jose Cecilio", "Del valle"); 
            Console.WriteLine("Persona 2" + nombrecompleto + "Salario: " + marcador.getSalario(35*4));

            Console.ReadLine();
        }
    }
}
