using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] users = {
        new string[] { "Peter", "Smith", "1111" },
        new string[] { "Sally", "Simmons", "2222" },
        new string[] { "Ross", "Richards", "3333" }
        };

            string[] names = new string[users.Length];
            for (int i = 0; i < users.Length; i++)
                names[i] = users[i][0];
            foreach (string name in names)
                Console.WriteLine(name);
            Console.Read();
        }
    }

}