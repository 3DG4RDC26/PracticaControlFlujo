using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1.clases
{
        internal class StudentsNames  //Nombre de la clase creada
        {
            private List<string> names = new List<string>();
            private const int MaxStudents = 25;

            public void AddName(string name)   //Funcion para añadir nombres
            {
                if (names.Count < MaxStudents)
                {
                    names.Add(name);
                }
                else
                {
                    throw new InvalidOperationException("Limite de 25 nombres.");
                }
            }

            public List<string> GetLongNames()
            {
                List<string> longNames = new List<string>();
                foreach (var name in names)
                {
                    if (name.Length > 25)
                    {
                        longNames.Add(name);
                    }
                }
                return longNames;
            }
        }

    }

