using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           







            Alumno alumno = new Alumno();

           // alumno.Nombre = "Juan Perez";
           // alumno.Matricula = "149240";
            Materia matematicas = new Materia();
            matematicas.Nombre = "Matematicas";
            matematicas.Identificador = "MT329DSS";
            alumno.Materias.Add(new Materia());
            alumno.Materias.Add(matematicas);
            
            alumno.Materias.Add(new Materia());
            alumno.Materias[0].Nombre = "Historia";
            alumno.Materias[0].Identificador = "H32312312";

            alumno.Materias[2].Nombre = "Español";
            alumno.Materias[2].Identificador = "H123123";
            alumno.Class1s.Add(new Class1());
            alumno.Class1s[0].Nombre = "juan";
           // alumno.Materias.RemoveAt(1);
          //  Console.WriteLine("Alumno " + alumno.Nombre);
            Console.WriteLine("NUMERO DE MATERIAS " + alumno.Materias.Count);
           /* Console.WriteLine("Materia " + alumno.Materias[0].Nombre);
            Console.WriteLine("Materia " + alumno.Materias[1].Nombre);*/

         foreach(Materia materia in alumno.Materias)
            {
                Console.WriteLine("Materia " + materia.Nombre);
            }

            Console.ReadLine();

            
        
        }
    }
}
