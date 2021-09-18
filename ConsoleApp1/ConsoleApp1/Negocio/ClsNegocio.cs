using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Negocio
{
    class ClsNegocio
    {
        public int Log (Persona persona)
        {
            if (persona.Usuario == "Jose" && persona.Pass == "123")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
