namespace Bad.DuckPond
{
    public class Duck : IDuck
    {
        public bool IsSwimming { get; private set; }
        
        public void Swim()
        {
            IsSwimming = true;
        }
    }
}