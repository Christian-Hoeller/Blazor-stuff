using System.Collections.Generic;

namespace Portfolio.Classes.TSP
{
    public interface ITSPSolver
    {
        List<int> Solve(IReadOnlyList<Location> cities);
    }
}
