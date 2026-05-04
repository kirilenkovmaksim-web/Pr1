using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    internal class Firm
    {
        string Name { get; set; }
        string Email { get; set; }
        int GotCreate { get; set; }

        public Firm(string name, string email, int age)
        {
            Name = name;
            Email = email;
            GotCreate = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Название фирмы: {Name}");
            Console.WriteLine($"Адрес: {Email}");
            Console.WriteLine($"Год основания: {GotCreate}");
        }

    }
}
