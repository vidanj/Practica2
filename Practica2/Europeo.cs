using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Europeo:Humanos
    {
        bool freshness;
        int whiteLevel;

        public override string Caminar()
        {
            return "El Europeo camina";
        }

        public override string Saltar()
        {
            return "El Europeo saltó";
        }
    }
}
