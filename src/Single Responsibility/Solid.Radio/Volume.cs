namespace Solid.Radio
{
    public class Volume
    {
        public int Value { get; set; }

        private int MaxAllowedVolume = 10;
        private int MinAllowedVolume = 0;

        public Volume()
        {
            Value = 5;
        }

        public void Up()
        {
            if(Value < MaxAllowedVolume)
                Value++;
        }

        public void Down()
        {
            if(Value > MinAllowedVolume)
                Value--;
        }
    }
}