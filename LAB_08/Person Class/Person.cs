using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_08
{
    [Serializable]
    abstract class Person
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int Age;

        protected Person() : this("Nope", "Nope", -1)
        {

        }

        protected Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}\nLast Name: {this.LastName}\nAge: {this.Age}";
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() + LastName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;
            Person person = (Person)obj;
            return (this.FirstName == person.FirstName && this.LastName == person.LastName);
        }
        public abstract void Sleep();
        public abstract void GetMoney();


    }
}
