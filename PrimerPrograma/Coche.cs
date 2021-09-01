using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPrograma
{
    public class Coche : IVehiculable
    {
        public string Matricula { get; set; }
        public int Marcha { get; set; }

        public Coche()
        {
            Marcha = 0;
        }
        public Coche(string matricula) 
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
