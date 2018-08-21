using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Alumno
    {
       
        public List<Class1> Class1s { get; set; }
        public List<Materia> Materias { get; set; }

        public Alumno()
        {
            Class1s = new List<Class1>();
            Materias = new List<Materia>();
        }
     

    }
}
