namespace ProyectoBancario.Interfaces
{
    internal interface INotificable
    {
        public void Notification(string msg);
        public abstract bool AskSendSaldo(string msg);
    }
}