﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancario.Interfaces
{
    interface ICuentaBancariaActions
    {
        public abstract bool AddSaldo();
        public abstract bool WithdrawSaldo();

    }
}
