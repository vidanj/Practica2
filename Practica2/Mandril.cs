using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Mandril:Simios
    {
        int knowledge;
        string buttColor;

        public override string Caminar()
        {
            return "El Mandril camina";
        }

        public override string Saltar()
        {
            return "El Mandril saltó";
        }
    }
}
