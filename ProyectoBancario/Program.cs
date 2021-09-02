using ProyectoBancario.Models;
using System;
using System.Collections.Generic;

namespace ProyectoBancario
{
    public class Program
    {
        public static List<User> listaUsers = new();

        public static void Main(string[] args)
        {
            Programa();
        }

        public static void Programa()
        {
            CreateUsers();
            CreateAccounts();
            AddSaldoRandom();
            SendSaldoRandom();
            AskSaldoRandom();
        }

        public static void CreateUsers()
        {
            listaUsers.Add(new Client("Alberto Vicente", "altitus", "pass1"));
            listaUsers.Add(new Client("Pablo Viturro", "pablo", "pass2"));
            listaUsers.Add(new Client("Javier Sañudo", "javi", "pass3"));
        }
        public static void CreateAccounts()
        {
            foreach(Client cliente in listaUsers)
            {
                cliente.CreateAccount();
            }
        }

        public static void AddSaldoRandom()
        {
            Random r = new Random();
            foreach (Client user in listaUsers)
            {
                user.AddSaldo(r.Next(50, 200));
            }
        }

        public static void SendSaldoRandom()
        {
            Random r = new Random();
            foreach (Client user in listaUsers)
            {
                int randomUser = r.Next(0, listaUsers.Count);
                user.SendSaldo((Client) listaUsers[randomUser], r.Next(50, 200));
            }
        }

        public static void AskSaldoRandom()
        {
            Random r = new Random();
            foreach (Client user in listaUsers)
            {
                int randomUser = r.Next(0, listaUsers.Count);
                user.AskSaldo((Client)listaUsers[randomUser], r.Next(50,200));
            }
        }
    }
}