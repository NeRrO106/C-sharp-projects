using System;

namespace SuperNaturalInheritance
{
    class Mage : Pupil
    {
        public Mage(string Title) : base(Title) { }
        public Mage(string Title, string Origin) : base(Title, Origin) { }
        public virtual Storm CastRainStorm()
        {
            return new Storm("rain", false, Title);
        }
    }
}
