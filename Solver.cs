using System.Collections.Generic;
using Stately;

public class Solver
{
    public Maze Maze { get; set; }

    public void Solve()
    {
        var initial = Maze.Root;

        solve(initial);
    }

    private void solve(Space space)
    {
        space.Visited = true;

        if(space.IsSolution)
            return;
        
        if(space.)
    }
}