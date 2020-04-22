using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Lab5
{
    public class EmailVerifed
    {
        public void OnEmailVerified(object source, EventArgs args)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Su Correo a sido verificado");
            Thread.Sleep(2000);
        }
    }
}
