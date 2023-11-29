using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperNaturalInheritance
{
    class Pupil
    {
        protected string Title { get; private set; }
        protected string Origin { get; private set; }
        public Pupil(string title)
        {
            Title = title;
        }
        public Pupil(string title, string origin)
        {
            Title = title;
            Origin = origin;
        }
        public Storm CastWindStorm()
        {
            return new Storm("wind", false, Title);
        }
    }
}
