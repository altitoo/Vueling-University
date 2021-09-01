using System;
using System.Collections.Generic;

namespace PrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehiculable> listaVehiculos = new();
            Random r = new Random();

            listaVehiculos.Add(new Autobus("7589CBZ"));
            listaVehiculos.Add(new Autobus());
            listaVehiculos.Add(new Coche("7112CSV"));
            listaVehiculos.Add(new Coche());

            for(int i = 0; i < 10; i++)
            {
                listaVehiculos[r.Next(0, listaVehiculos.Count)].SpeedUp();
                listaVehiculos[r.Next(0, listaVehiculos.Count)].SpeedDown();
            }

            foreach (IVehiculable vehiculo in listaVehiculos)
            {
                Console.WriteLine(vehiculo.MostrarDatos());
            }

        }
    }

    
}
