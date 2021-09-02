﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancario.Models
{
    public class Empleado : Usuario
    {
        public Empleado(string nombre, string user, string pass)
        {
            Name = nombre;
            User = user;
            Password = new NetworkCredential("", pass).SecurePassword;
        }
    }
}