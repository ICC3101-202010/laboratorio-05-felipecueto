using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Lab5
{
    public class Emailsent
    {

        public  void OnEmailsented(object source, EventArgs args)
        {
            Thread.Sleep(2000);
            Console.WriteLine("El correo fue enviado correctamente al usuario");
            Thread.Sleep(2000);
        }

    }

}