using System;
using static System.Net.Mime.MediaTypeNames;

/*
At the Codecademy Guild of the Supernatural, there are three ranks of magicians. They rank from least to most powerful: Pupils, Mages, and Archmages. In this project, you’ll be developing a system in C# to track the weather magicians in the guild and their spells.

Pupils have a title and can create one weak wind storm.
Mages have a title and can create a weak wind storm and a weak rain storm.
Archmages have a title and can create a weak wind storm, a strong rain storm, and a strong lightning storm.
Notice anything shared in these ranks? If we created a class for each type of magician, we would have a lot of duplicated code. For example, every magician has a title and wind storm. To avoid duplication, we’ll use inheritance.

Pupil is the base class
Mage inherits from Pupil
Archmage inherits from Mage
*/

namespace SuperNaturalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm[] storms = new Storm[10];
            int index = 0;
            Pupil pupil = new Pupil("Mezil-kree");
            storms[index] = pupil.CastWindStorm();
            index++;

            Mage mage = new Mage("Gul`dan");
            storms[index] = mage.CastRainStorm();
            index++;

            Archmage archmage = new Archmage("Nielas Aran");
            storms[index] = archmage.CastRainStorm();
            index++;
            storms[index] = archmage.CastLightingStorm();

            Pupil p = new Pupil("Mezil-kree", "Icecrown");
            Mage m = new Mage("Gul`dan", "Draenor");
            Archmage a = new Archmage("Nielas Aran", "Stormwind");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(storms[i].Announce());
            }
        }
    }
}