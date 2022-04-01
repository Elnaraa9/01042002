using System;
using System.Collections.Generic;
using System.Text;

namespace _1042022
{
    class User:IAccount
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool PasswordChecker(string password)
        {
            foreach (var item in password)
            {
                if (password.Length<8)
                {
                    Console.WriteLine("Sifre uzunlugu duzgun deyil");                  
                }
                if (char.IsUpper())
                {

                }
            }
            return;
        }

        public void ShowInfo()
        {
           ();
        }
    }
}
