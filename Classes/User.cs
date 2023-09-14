using HomeTask4_Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4_Classes.Classes
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int _age { get; set; }
        public bool IsBaby
        {
            get
            {
                return _age < 10;
            }
        }
        public GenderType Gender { get; set; }
        public User()
        {
        }
        public User(int age)
        {
            _age = age;
        }
        public override string ToString()
        {
            if (IsBaby)
            {
                return $"Hi, my name is {FirstName} and last name {LastName}. I am a baby. I am {Gender}.";
            }
            else
            {
                return $"Hi, my name is {FirstName} and last name {LastName}. I am {_age} years old. I am {Gender}.";
            }
        }
    }
}
