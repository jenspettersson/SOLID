using System;

namespace Solid.InterfaceSegregationPrinciple
{
    public interface IPerson
    {
        DateTime DateOfBirth { get; set; }
        double Height { get; set; }
        double Weight { get; set; }
        string Name { get; set; }
        void Eat();
        void Play();
        void Sleep();
        void Talk();
        void Walk();
        void Work();
    }

    public class Person : IPerson
    {
        public DateTime DateOfBirth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Name { get; set; }

        public void Eat()
        {
            
        }

        public void Play()
        {
            
        }

        public void Sleep()
        {
            
        }

        public void Talk()
        {
            
        }

        public void Walk()
        {
            
        }

        public void Work()
        {
            
        }
    }

    public class BirthdayCalendar
    {
        public void Add(IPerson person)
        {
            // Does a birthday calendar really care about the persons height or weight?
            // Maybe if the calendar should be able to decide what size of underwear to buy the person...
        }
    }
}
