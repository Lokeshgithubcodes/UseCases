using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases
{
     class EmpPorA
    {
        public void emPorA()
        {
            Random rnd = new Random();
            bool isPresnt=rnd.Next(2) == 0;
            if (isPresnt)
            {
                Console.WriteLine("Presnt");
            }
            else { Console.WriteLine("Absent");
            }
        }
    }
}
