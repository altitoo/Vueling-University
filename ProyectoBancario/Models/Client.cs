using ProyectoBancario.Services;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ProyectoBancario.Models
{
    public class Client : User
    {
        public List<Account> ListaCuentasBancarias = new List<Account>();
        private AccountService serviceAccount = new AccountService();
        private UserService serviceUser = new UserService();

        public Client(string nombre, string user, string pass)
        {
            Name = nombre;
            UserID = user;
            Password = new NetworkCredential("", pass).SecurePassword;
        }

        public void CreateAccount()
        {
            serviceAccount.NewAccount(this);
        }
        public void AskSaldo(Client client, decimal qty)
        {
            serviceUser.AskSaldo(client.ListaCuentasBancarias.FirstOrDefault(), this.ListaCuentasBancarias.FirstOrDefault(), qty);
        }

        public void SendSaldo(Client client, decimal qty)
        {
            serviceUser.SendSaldo(this.ListaCuentasBancarias.FirstOrDefault(), client.ListaCuentasBancarias.FirstOrDefault(), qty);
        }

        public void AddSaldo(decimal qty)
        {
            serviceAccount.AddSaldo(this.ListaCuentasBancarias.FirstOrDefault(), qty);
        }

        public void WithdrawSaldo(decimal qty)
        {
            serviceAccount.WithdrawSaldo(this.ListaCuentasBancarias.FirstOrDefault(), qty);
        }
    }
}