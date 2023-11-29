namespace RoverControlCenter
{
    class Probe
    {
        public string Alias
        { get; protected set; }

        public int YearLaunched
        { get; protected set; }
        public virtual string GetInfo()
        {
            return "";
        }
        public virtual string Explore()
        {
            return "";
        }
        public virtual string Collect()
        {
            return "";
        }
    }
}