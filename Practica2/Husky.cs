using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Husky:Perros
    {
        bool SiberianStatus;
        string color;

        public override string Caminar()
        {
            return "El Husky camina";
        }

        public override string Saltar()
        {
            return "El Husky saltó";
        }
    }
}
