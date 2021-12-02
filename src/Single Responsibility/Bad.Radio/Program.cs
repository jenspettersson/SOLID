namespace Bad.Radio
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var badRadio = new BadRadio();

            badRadio.VolumeUp();
            badRadio.VolumeUp();
            badRadio.VolumeUp();
            badRadio.VolumeUp();
            badRadio.VolumeUp();
            
            badRadio.VolumeUp();
            badRadio.VolumeUp();
            
            badRadio.ChangeFrequency(900.5);

            Console.WriteLine("Volume is: {0}", badRadio.CurrentVolume);
            Console.WriteLine("Frequency is: {0}", badRadio.CurrentFrequency);
        }
    }
}
