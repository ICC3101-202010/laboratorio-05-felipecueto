using System;
namespace Lab5
{
    public class User
    {
        public delegate void EmailVerifyEventHandler(object source, RegisterEventArgs args);
     
        public event EmailVerifyEventHandler EmailVerified;
        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, new RegisterEventArgs() { });
            }
        }

        public void OnEmailSent()
        {
            OnEmailVerified();
        }

    }
}
