using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPrograma
{
    class Autobus : IVehiculable
    {
        public string Matricula { get; set; }
        public int Marcha { get; set; }

        public Autobus()
        {
            Marcha = 0;
        }
        public Autobus(string matricula)
        {
            Matricula = matricula;
            Marcha = 0;
        }
        public void SpeedDown()
        {
            if (Marcha > 0)
            {
                Marcha -= 1;
            }

        }

        public void SpeedUp()
        {
            if (Marcha < 6)
            {
                Marcha += 1;
            }

        }
        public string MostrarDatos() 
        {
            return $"Matricula: {Matricula} \n" +
                    $"Marcha: {Marcha}   ";
        }
    }

}
