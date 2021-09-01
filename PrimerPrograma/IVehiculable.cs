using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPrograma
{
    interface IVehiculable
    {
        string Matricula { get; set; }
        int Marcha { get; set; }

        public void SpeedDown();
        public void SpeedUp();

        public string MostrarDatos();
    }
}
