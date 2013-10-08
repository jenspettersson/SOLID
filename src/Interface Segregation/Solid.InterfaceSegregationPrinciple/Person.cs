namespace Solid.InterfaceSegregationPrinciple
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Windows.Forms;

    public class Person : IPerson
    {
        public DateTime DateOfBirth { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Name { get; set; }

        public void Eat()
        {
            //As I was forced to implement this method I'm going to eat memory until the system crashes!

            var wastedMemory = new List<byte[]>();

            while (true)
            {
                var buffer = new byte[4096]; // Allocate 4kb
                wastedMemory.Add(buffer);
            }
        }

        public void Play()
        {
            throw new NotImplementedException("I don't care for this in my implementation!");
        }

        public void Sleep()
        {
            //As the interface FORCED me to implement this method, I'm letting the thread sleep for one hour
            Thread.Sleep(3600000);
        }

        public void Talk()
        {
            MessageBox.Show("As I was forced to implement this method, I'm talking to you through this message box and telling you I don't care for it at all!");
        }

        public void Walk()
        {
            throw new NotImplementedException("I don't care for this in my implementation!");
        }

        public void Work()
        {
            throw new NotImplementedException("I don't care for this in my implementation!");
        }
    }
}
