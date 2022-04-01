using System;
using System.Collections.Generic;
using System.Text;

namespace _1042022
{
    class Employee
    {
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                
                int count=0;
                foreach (var item in value)
                {
                    if (!char.IsLetter(value,item))
                    {
                        count++;
                        Console.WriteLine("Ad formati duzgun deyil");
                        return;
                    }
                }            
                     if (char.IsUpper(value[0]))
                    {
                        _name = Name;
                    }
            }

        }
        public string Surname { get; set; }
        public int Salary { get; set; }
        private string _name;
     
    } 
}
