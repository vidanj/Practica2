using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Corgi : Perros
    {
        string cuteness;
        string memeStatus;

        public override string Caminar()
        {
            return "El corgi camina";
        }

        public override string Saltar()
        {
            return "El corgi saltó";
        }
    }
}
