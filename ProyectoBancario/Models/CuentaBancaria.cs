using ProyectoBancario.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancario.Models
{
    public class CuentaBancaria : ICuentaBancariaActions
    {
        private string Iban { get; set; }

    }
}
