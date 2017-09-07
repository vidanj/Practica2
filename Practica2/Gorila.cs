using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Gorila:Simios
    {
        int strenght;
        int intelligence;

        public override string Caminar()
        {
            return "El Gorila caminó";
        }

        public override string Saltar()
        {
            return "El Gorila saltó";
        }

        public void status()
        {

        }
    }
}
