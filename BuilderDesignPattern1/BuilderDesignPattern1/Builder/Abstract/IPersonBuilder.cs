using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern1.Builder.Abstract
{
    public interface IPersonBuilder
    {
        void SetIdentityNumber(string identity);
        void SetName(string name);
        void SetSurname(string surname);
        void SetAge(int age);
    }
}
