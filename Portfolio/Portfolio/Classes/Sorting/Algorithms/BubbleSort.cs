using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Classes.Sorting
{
    public class BubbleSort : ISortingAlgorithmSolver
    {
        public List<SortingArrangement> Solve(List<int> givenList)
        {
            var x = givenList;
            List<int> sortedList = givenList;
            Console.WriteLine("givenLIst: " + string.Join(",", givenList));
            Console.WriteLine("givenLIst: " + string.Join(",", givenList));

            List<SortingArrangement> arrangementList = new List<SortingArrangement>();
            int temp;
            for(int j = 0; j <= sortedList.Count - 2; j++)
            {
                for(int i = 0; i < sortedList.Count - 1; i++)
                {
                    if(sortedList[i] > sortedList[i + 1])
                    {
                        temp = sortedList[i + 1];
                        sortedList[i + 1] = sortedList[i];
                        sortedList[i] = temp;
                    }
                    SortingArrangement newArrangement = new SortingArrangement(sortedList);
                    arrangementList.Add(newArrangement);
                    //Console.WriteLine(i + " " + arrangementList[i].ToString());
                }
            }

            Console.WriteLine("givenLIst: " + string.Join(",", givenList));
            Console.WriteLine("givenLIst: " + string.Join(",", x));
            Console.WriteLine("sortedList: " + string.Join(",", sortedList));

            return arrangementList;
        }
    }
}
