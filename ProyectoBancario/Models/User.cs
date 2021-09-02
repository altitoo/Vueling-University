using System.Security;

namespace ProyectoBancario.Models
{
    public abstract class User
    {
        protected string Name { get; set; }
        protected string UserID { get; set; }
        protected SecureString Password { get; set; }
    }
}