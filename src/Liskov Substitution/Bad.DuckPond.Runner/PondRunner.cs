namespace Bad.DuckPond.Runner
{
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;

    [TestFixture, Explicit("This is just an example runner")]
    public class PondRunner
    {
        [Test]
        public void MakeAllDucksSwim()
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
