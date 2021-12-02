using System;
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

            var electricalDuck = new ElectricalDuck();
            electricalDuck.InsertBatteries();

            pond.AddDuck(electricalDuck);

            var mechanicalDuck = new MechanicalDuck();
            mechanicalDuck.WindUp();

            pond.AddDuck(mechanicalDuck);

            var duckOnFire = new DuckOnFire();
            duckOnFire.LightOnFire();

            pond.AddDuck(duckOnFire);

            pond.MakeAllDucksSwim();

            var swimmingDucks = pond.Ducks.Count(x => x.IsSwimming);

            Console.WriteLine($"Ducks that are swimming: {swimmingDucks}");
        }
    }

    public class DuckOnFire : IDuck
    {
        private bool _isSwimming;
        private bool _isOnFire;

        public bool IsSwimming => _isSwimming;

        public void Swim()
        {
            if (_isOnFire)
            {
                throw new Exception("I'M BURNING!");
            }

            _isSwimming = true;
        }

        public void LightOnFire()
        {
            _isOnFire = true;
        }
    }
}