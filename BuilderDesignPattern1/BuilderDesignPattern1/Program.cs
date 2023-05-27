using BuilderDesignPattern1.Builder;
using BuilderDesignPattern1.Builder.Concrete;
using BuilderDesignPattern1.Director;
using BuilderDesignPattern1.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern1
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonBuilder builder = new PersonBuilder();
            builder.SetIdentityNumber("20428632300");
            builder.SetName("Utku");
            builder.SetSurname("Araal");
            builder.SetAge(40);

            Person person = builder.Build();
            Console.WriteLine($"Name Surname: {person.Name} {person.Surname}        Identity Number: {person.IdentityNumber}        Age: {person.Age}");

            PersonBuilder builder2 = new PersonBuilder();
            PersonDirector director = new PersonDirector();
            director.MakeMaleBot(builder2);
            Person MaleBot = builder2.Build();
            Console.WriteLine($"BOT- Name Surname: {MaleBot.Name} {MaleBot.Surname}        Identity Number: {MaleBot.IdentityNumber}        Age: {MaleBot.Age}");


        }
    }
}
