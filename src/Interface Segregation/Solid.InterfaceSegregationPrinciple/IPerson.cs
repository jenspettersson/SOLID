namespace Solid.InterfaceSegregationPrinciple
{
    using System;

    public interface IPerson
    {
        // This interface breaks the Interface Segregation Principle
        // "many client-specific interfaces are better than one general-purpose interface."

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
}