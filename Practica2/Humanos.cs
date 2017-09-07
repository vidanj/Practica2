using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Humanos:Simios
    {
        bool social;
        bool alive;

        public override string Caminar()
        {
            return "El Humano caminó";
        }

        public override string Saltar()
        {
            return "El Humano saltó";
        }
    }
}
