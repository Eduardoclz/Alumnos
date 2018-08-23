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
        { List<Alumno> alumnos = new List<Alumno>();

            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "jose";
            alumno1.Materias.Add(new Materia("Historia", "SDGSDF"));
            alumno1.Materias.Add(new Materia("Civismo", "DFS3234"));
            alumno1.Materias.Add(new Materia("Español", "DFSDF2342"));
            alumno1.Materias.Add(new Materia("Matematicas", "FSDFDSF423"));

            alumnos.Add(alumno1);

            Alumno alumno2 = new Alumno();

            alumno2.Nombre = "juan";
            alumno2.Materias.Add(new Materia("Historia", "SDGSDF"));
            alumno2.Materias.Add(new Materia("Civismo", "DFS3234"));
            alumno2.Materias.Add(new Materia("Español", "DFSDF2342"));
            alumno2.Materias.Add(new Materia("Matematicas", "FSDFDSF423"));
            alumnos.Add(alumno2);

            Alumno alumno3 = new Alumno();

            alumno3.Nombre = "Eduardo";
            alumno3.Materias.Add(new Materia("Historia", "SDGSDF"));
            alumno3.Materias.Add(new Materia("Civismo", "DFS3234"));
            alumno3.Materias.Add(new Materia("Español", "DFSDF2342"));
            alumno3.Materias.Add(new Materia("Matematicas", "FSDFDSF423"));
            alumnos.Add(alumno3);
            Alumno alumno4 = new Alumno();

            alumno4.Nombre = "Carlos";
            alumno4.Materias.Add(new Materia("Historia", "SDGSDF"));
            alumno4.Materias.Add(new Materia("Civismo", "DFS3234"));
            alumno4.Materias.Add(new Materia("Español", "DFSDF2342"));
            alumno4.Materias.Add(new Materia("Matematicas", "FSDFDSF423"));
            alumnos.Add(alumno4);


            foreach (Alumno elemento in alumnos)
            {
                Console.WriteLine("Nombre: " + elemento.Nombre);
                foreach (Materia materia in elemento.Materias)
                {
                    Console.WriteLine("Materia: " + materia.Nombre);
                }
            }
            Console.ReadLine();
        }
    }
}
