using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Simios:Cuadrupedo
    {
        string changes;
        string weirdenss;

        public override string Caminar()
        {
            return "El simio caminó";
        }

        public override string Saltar()
        {
            return "El simio saltó";
        }
    }
}
