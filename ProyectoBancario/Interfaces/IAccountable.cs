using ProyectoBancario.Models;

namespace ProyectoBancario.Interfaces
{
    internal interface IAccountable
    {
        public void NewAccount(Client client);

        public void AddSaldo(Account account, decimal saldo);

        public void WithdrawSaldo(Account account, decimal saldo);
    }
}