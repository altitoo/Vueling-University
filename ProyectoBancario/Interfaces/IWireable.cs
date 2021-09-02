using ProyectoBancario.Models;

namespace ProyectoBancario.Interfaces
{
    internal interface IWireable
    {
        public void SendSaldo(Account accSender, Account accReciver, decimal quantity);

        public void AskSaldo(Account accSender, Account accReciver, decimal quantity);
    }
}