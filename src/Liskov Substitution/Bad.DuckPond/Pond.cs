namespace Bad.DuckPond
{
    using System.Collections.Generic;

    public class Pond
    {
        private readonly List<IDuck> _ducks;
        public IEnumerable<IDuck> Ducks
        {
            get { return _ducks; }
        }

        public Pond()
        {
            _ducks = new List<IDuck>();
        }

        public void AddDuck(IDuck duck)
        {
            _ducks.Add(duck);
        }

        public void MakeAllDucksSwim()
        {
            foreach (var duck in _ducks)
            {
                //This breaks the Liskov Substitution Principle!
                if(duck is MechanicalDuck)
                    ((MechanicalDuck)duck).WindUp();

                duck.Swim();
            }
        }
    }
}