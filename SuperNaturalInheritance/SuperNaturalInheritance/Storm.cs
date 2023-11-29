using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperNaturalInheritance
{
    class Storm
    {
        protected string Essence { get; private set; }
        protected bool IsStrong { get; private set; }
        protected string Caster { get; private set; }
        public Storm(string essence, bool isstrong, string caster)
        {
            Essence = essence;
            IsStrong = isstrong;
            Caster = caster;
        }
        public string Announce()
        {
            string strong;
            if (IsStrong) strong = "strong";
            else strong = "week";
            return $"{Caster} cast a {strong} {Essence} storm!";
        }
    }
}
