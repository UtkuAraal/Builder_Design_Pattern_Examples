using BuilderDesignPattern1.Builder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern1.Director
{
    public class PersonDirector
    {
        public void MakeMaleBot(IPersonBuilder builder) 
        {
            builder.SetIdentityNumber("11111111111");
            builder.SetName("John");
            builder.SetSurname("Doe");
            builder.SetAge(1);

        }

        public void MakeFemaleBot(IPersonBuilder builder)
        {
            builder.SetIdentityNumber("11111111111");
            builder.SetName("Jane");
            builder.SetSurname("Doe");
            builder.SetAge(1);

        }
    }
}
