using ProyectoBancario.Interfaces;
using ProyectoBancario.Models;
using System;

namespace ProyectoBancario.Services
{
    public class UserService : IWireable
    {
        private readonly NotificationService serviceNotification = new NotificationService();

        public void AskSaldo(Account accSender, Account accReciver, decimal quantity)
        {
            string msgOk = $"Saldo recivido: {quantity}, Nuevo saldo {accReciver.Saldo} " +
                    $"del User: {accReciver.Iban}";
            string msgNotOk = $"El usuario {accSender.Iban} no posee suficiente saldo," +
                    $"\n Saldo actual: {accSender.Saldo}" +
                    $"\n Saldo requerido: {quantity}";

            if (accSender.Saldo > quantity)
            {
                Console.WriteLine($"Deseas mandar {quantity} de la cuenta {accSender.Iban} a {accReciver.Iban}");
                Console.WriteLine("yes/no");
                if (serviceNotification.AskSendSaldo(Console.ReadLine()))
                {
                    accReciver.Saldo += quantity;
                    accSender.Saldo += quantity;
                    serviceNotification.Notification(msgOk);
                }
                else
                {
                    msgOk = $"El envio ha sido rechazado por {accSender.Iban}";
                    serviceNotification.Notification(msgOk);
                }
            }
            else
            {
                serviceNotification.Notification(msgNotOk);
            }
        }

        public void SendSaldo(Account accSender, Account accReciver, decimal quantity)
        {
            string msgOk = $"Saldo recivido: {quantity}, Nuevo saldo {accReciver.Saldo} " +
                    $"del User: {accReciver.Iban}";
            string msgNotOk = $"El usuario {accSender.Iban} no posee suficiente saldo," +
                    $"\n Saldo actual: {accSender.Saldo}" +
                    $"\n Saldo requerido: {quantity}";

            if (accSender.Saldo > quantity)
            {
                accReciver.Saldo += quantity;
                accSender.Saldo += quantity;
                serviceNotification.Notification(msgOk);
            }
            else
            {
                serviceNotification.Notification(msgNotOk);
            }
        }
    }
}