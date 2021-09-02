using ProyectoBancario.Interfaces;
using System;

namespace ProyectoBancario.Services
{
    internal class NotificationService : INotificable
    {
        public NotificationService()
        {
        }

        public void Notification(string msg)
        {
            Console.WriteLine(msg);
        }

        public bool AskSendSaldo(string msg)
        {
            return msg.ToLower().Equals("yes");
        }
    }
}