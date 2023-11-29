// Archmage.cs
using System;
using static System.Net.Mime.MediaTypeNames;

namespace SuperNaturalInheritance
{
    class Archmage : Mage
    {
        public Archmage(string Title) : base(Title) { }
        public Archmage(string Title, string Origin) : base(Title, Origin) { }
        public override Storm CastRainStorm()
        {
            return new Storm("rain", true, Title);
        }
        public Storm CastLightingStorm()
        {
            return new Storm("lighting", true, Title);
        }
    }
}
