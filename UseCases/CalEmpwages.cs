using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases
{
     class CalEmpwages
    {
        public void calEmpwages()
        {
            int wageperhr = 20;
            int fullday = wageperhr * 8;
            Console.WriteLine("Wage for full day:" + fullday);
        }
    }
}
