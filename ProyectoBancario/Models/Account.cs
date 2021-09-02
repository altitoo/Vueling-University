using ProyectoBancario.Services;
using System;

namespace ProyectoBancario.Models
{
    public class Account
    {
        private AccountService service = new AccountService();
        public int Iban { get; set; }

        public decimal Saldo { get; set; }

        public Account()
        {
            Iban = new Random().Next(1000000, 9999999);
            Saldo = 0;
        }

        public void AddSaldo(int saldoAñadido)
        {
            service.AddSaldo(this, saldoAñadido);
        }

        public void WithdrawSaldo(int saldoRetirado)
        {
            service.WithdrawSaldo(this, saldoRetirado);
        }
    }
}