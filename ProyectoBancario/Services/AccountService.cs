using ProyectoBancario.Interfaces;
using ProyectoBancario.Models;

namespace ProyectoBancario.Services
{
    public class AccountService : IAccountable
    {
        private readonly NotificationService serviceNotification = new NotificationService();

        public void AddSaldo(Account account, decimal saldo)
        {
            account.Saldo += saldo;
            string msg = $"Se ha añadido: {saldo} a tu cuenta tu saldo es de {account.Saldo}";
            serviceNotification.Notification(msg);
        }

        public void WithdrawSaldo(Account account, decimal saldo)
        {
            if (account.Saldo - saldo > 0)
            {
                account.Saldo -= saldo;
                string msg = $"Se ha añadido: {saldo} a tu cuenta tu saldo es de {account.Saldo}";
                serviceNotification.Notification(msg);
            }
            else
            {
                string msg = $"No se ha retirado no dispones de suficiente saldo " +
                            $" \n Dispones de {account.Saldo} y quieres retirar {saldo}";
                serviceNotification.Notification(msg);
            }
        }

        public void NewAccount(Client client)
        {
            client.ListaCuentasBancarias.Add(new Account());
        }
    }
}