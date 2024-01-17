using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases
{
    class ChechFullorPart
    {
        public void chechFullorPart()
        {
        
            Random rnd = new Random();
                bool isPresent = rnd.Next(2) == 0;

                if (isPresent)
                {
                    Console.WriteLine("Present");
                    int totaldays = 0;
                    int totalhrs = 0;
                    int parttimewages = 0;
                    int fulltimewages = 0;
                    while (totalhrs <= 100 || totaldays <= 20)
                    {
                        int check = rnd.Next(2);
                        switch (check)
                        {
                            case 0:
                                int hrs = rnd.Next(1, 8);
                                parttimewages += hrs*8;
                                totalhrs += hrs;
                                break;


                            case 1:
                                fulltimewages += 8*20;
                                totaldays += 1;
                                break;
                        }

                    }
                    Console.WriteLine("Full time wages: " + fulltimewages);
                    Console.WriteLine("Part time wages: " + parttimewages);
                }

                else
                {
                    Console.WriteLine("Absent");
                }

            }
        
       

    }
}
