using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancario.Models
{
    public class Cliente : Usuario
    {
        List<CuentaBancaria> ListaCuentasBancarias = new List<CuentaBancaria>();
        public Cliente(string nombre, string user, string pass)
        {
            Name = nombre;
            User = user;
            Password = new NetworkCredential("", pass).SecurePassword;
        }

    }
}
