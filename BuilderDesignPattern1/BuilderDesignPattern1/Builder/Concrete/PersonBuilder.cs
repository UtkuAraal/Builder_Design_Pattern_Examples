using BuilderDesignPattern1.Builder.Abstract;
using BuilderDesignPattern1.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern1.Builder.Concrete
{
    public class PersonBuilder : IPersonBuilder
    {
        private Person person = new Person();
        public void SetAge(int age)
        {
            person.Age = age;
        }

        public void SetIdentityNumber(string identity)
        {
            person.IdentityNumber = identity;
        }

        public void SetName(string name)
        {
            person.Name = name;
        }

        public void SetSurname(string surname)
        {
            person.Surname = surname;
        }

        public Person Build() 
        {
            return this.person;
        }
    }
}
