using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases
{
     class WagesInhrsDays
    {
        public void wagesInhrsDays() 
        {
            Random rd= new Random();
            int tothrs = 0;
            int totdays = 0;
            while(tothrs<=100 ||  totdays<=20) 
            {
                int check=rd.Next(2);
                if(check==0)
                {
                    tothrs += rd.Next(1, 8); // tothrs =tothrs+rd.Next(1,8);

                }
                else
                {
                    totdays++;
                }
            }
            Console.WriteLine("total hrs:" + tothrs);
            Console.WriteLine("total days:" + totdays);
            
        }
    }
}
