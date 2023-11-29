namespace RoverControlCenter
{
    class Rover : Probe
    {
        public Rover(string alias, int yearLanded)
        {
            Alias = alias;
            YearLaunched = yearLanded;
        }

        public override string GetInfo()
        {
            return $"Alias: {Alias}, YearLanded: {YearLaunched}";
        }

        public override string Explore()
        {
            return "Rover is exploring the surface!";
        }

        public override string Collect()
        {
            return "Rover is collecting rocks!";
        }
    }
}