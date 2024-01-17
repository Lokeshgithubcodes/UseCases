using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases
{
     class ParttimeEmp
    {
        public void parttimeEmp()
        {
            Random rnd = new Random();
            int hrs=rnd.Next(1,8);
            Console.WriteLine("Parttime wages:" + (hrs * 8));
            
        }
    }
}
