using System.Net;

namespace ProyectoBancario.Models
{
    public class Empleado : User
    {
        public Empleado(string nombre, string user, string pass)
        {
            Name = nombre;
            UserID = user;
            Password = new NetworkCredential("", pass).SecurePassword;
        }
    }
}