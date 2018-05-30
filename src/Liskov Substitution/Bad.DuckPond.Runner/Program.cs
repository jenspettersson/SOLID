using System.Collections.Generic;
using System.Linq;

namespace Bad.DuckPond.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var pond = new Pond();

            pond.AddDuck(new Duck());
            pond.AddDuck(new Duck());
            pond.AddDuck(new Duck());
            pond.AddDuck(new Duck());
            pond.AddDuck(new MechanicalDuck());
            pond.AddDuck(new MechanicalDuck());
            pond.AddDuck(new MechanicalDuck());
            pond.AddDuck(new MechanicalDuck());
            
            pond.MakeAllDucksSwim();
            
            List<IDuck> swimmingDucks = pond.Ducks.Where(x => x.IsSwimming).ToList();
        }
    }
}
