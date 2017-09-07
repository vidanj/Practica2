using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Chihuaha:Perros
    {
        bool MexicanStatus;
        string size;

        public override string Caminar()
        {
            return "El Chihuaha camina";
        }

        public override string Saltar()
        {
            return "El Chihuaha saltó";
        }
    }
}
