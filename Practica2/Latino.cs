using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Latino:Humanos
    {
        int MalincheLevel;
        string socialClass;

        public override string Caminar()
        {
            return "El Latino camina";
        }

        public override string Saltar()
        {
            return "El Latino saltó";
        }
    }
}
