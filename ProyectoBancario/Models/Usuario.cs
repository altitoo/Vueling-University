using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancario.Models
{
    public abstract class Usuario
    {
        protected string Name { get; set; }
        protected string User { get; set; }
        protected SecureString Password { get; set; }

        
    }
}
