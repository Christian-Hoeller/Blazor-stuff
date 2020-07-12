using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Classes.Sorting
{
    public interface ISortingAlgorithmSolver
    {
        List<SortingArrangement> Solve(List<int> numbersList);
    }
}
