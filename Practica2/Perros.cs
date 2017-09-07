using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Perros:Cuadrupedo
    {
        string famila;
        string fuerza;

        public override string Caminar()
        {
            return "El perro camina.";
        }

        public override string Saltar()
        {
            return "El perro saltó";
        }
    }
}
