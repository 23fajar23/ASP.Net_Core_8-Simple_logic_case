using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Psbb
    {
        private int maxPassenger = 4;
        private int procPsbb(List<int> data)
        {
            List<int> list = data;
            List<int> descData = list.OrderByDescending(x => x).ToList();
            int bus = 0;

            //find data with result 4 people
            int exit = 0;
            while (exit < descData.Count)
            {
                Boolean reset = false;
                for (int i = 0; i < descData.Count; i++)
                {
                    if (descData[exit] + descData[i] == maxPassenger && exit != i)
                    {
                        bus++;
                        descData.RemoveAt(i);
                        descData.RemoveAt(exit);
                        reset = true;
                    }
                }

                exit++;
                if (reset)
                {
                    exit = 0;
                    reset = false;
                }
            }

            //Count remaining passenger
            int count = 0;
            while (count < descData.Count)
            {
                if (descData[count] == 0)
                {
                    count++;
                }else if (descData[count] >= maxPassenger)
                {
                    bus++;
                    descData[count] -= maxPassenger;
                }else if (descData[count] < maxPassenger)
                {
                    try
                    {
                        if (descData[count] + descData[count+1] >= maxPassenger)
                        {
                            bus++;
                            descData[count + 1] -= (maxPassenger - descData[count]);
                            descData[count] = 0;
                            count++;
                        }
                        else
                        {
                            bus++;
                            descData[count + 1] = 0;
                            descData[count] = 0;
                            count++;
                        }
                    }
                    catch
                    {
                        bus++;
                        break;
                    }
                }
            }

            return bus;

        }

        private void calculateMinBus(string families, string member)
        {
            List<int> data = member.Split(" ").Select(int.Parse).ToList();

            if (Int32.Parse(families) != data.Count)
            {
                Console.WriteLine("Input must be equal with count of family");
            }
            else
            {
                int minBus = procPsbb(data);
                Console.WriteLine("Minimum bus required is : " + minBus);
            }
        }

        public void run()
        {
            Console.Write("Input the number of families : ");
            try
            {
                string families = Console.ReadLine();
                Console.WriteLine("Input the number of in the family ");
                Console.Write("(separated by a space) : ");
                string member = Console.ReadLine();
                
                calculateMinBus(families,member);

            }catch
            {
                Console.WriteLine("Invalid Input");
            }

        }
    }
}
