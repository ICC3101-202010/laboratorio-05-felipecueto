using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Lab5
{   //Parte Tarea
    public class User
    {
        private short opcion;

        public delegate void EmailVerifyEventHandler(object source, RegisterEventArgs args);
        public event EmailVerifyEventHandler EmailVerified;
        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, new RegisterEventArgs() { });
            }
        }

        public void OnEmailSent(object source, EventArgs args)
        {
            Console.WriteLine("El correo a sido enviado correctamente al usuario");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Quiere verificar su correo?\n");
            Console.WriteLine("1-Si");
            Console.WriteLine("2-No\n");
            opcion = Convert.ToInt16(Console.ReadLine());
            if (opcion == 1)
            {
                OnEmailVerified();
            }    
                
        }


    }
}
