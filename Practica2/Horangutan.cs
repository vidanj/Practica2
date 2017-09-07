using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Horangutan:Simios
    {
        int ugliness;
        int wierdnessLevel;

        public override string Caminar()
        {
            return "El Horangutan caminó";
        }

        public override string Saltar()
        {
            return "El Horangutan saltó";
        }
    }
}
