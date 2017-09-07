using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Asiatico:Humanos
    {
        int StarCraftLevel;
        string ojos;

        public override string Caminar()
        {
            return "El Asiatico camina";
        }

        public override string Saltar()
        {
            return "El Asiatico saltó";
        }
    }
}
