using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_08
{
    [Serializable]
    abstract class Working : Person
    {
        protected string PlaceOfWork;

        public Working() : base()
        {

        }

        public Working(string firstName, string lastName, int age, string placeOfWork) : base(firstName, lastName, age)
        {
            this.PlaceOfWork = placeOfWork;
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}\nLast Name: {this.LastName}\nAge: {this.Age}\nPlace of Work: {this.PlaceOfWork}";
        }

        public override void GetMoney()
        {
            Console.WriteLine("Получаю зарплату");
        }
    }
}
