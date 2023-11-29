using System;

namespace DatingApp
{
    class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        public Profile(string namen, int agen, string cityn = "n/a", string countryn = "n/a", string pronounsn = "they/them")
        {
            this.Name = namen;
            this.Age = agen;
            this.City = cityn;
            this.Country = countryn;
            this.Pronouns = pronounsn;
            this.hobbies = Array.Empty<string>();
        }
        public string ViewProfile()
        {
            string bio = $"Name:{Name}, Age:{Age}, City:{City}, Country:{Country}, Pronouns:{Pronouns}, Hobbies: ";
            if (this.hobbies.Length != 0)
            {
                foreach (string hobie in this.hobbies)
                {
                    bio = bio + ", " + hobie;
                }
            }
            else
            {
                bio = bio + "no hobbies";
            }
            return bio;
        }

        //setters
        public void changeHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
        public void changeName(string name)
        {
            this.Name = name;
        }
        public void changeAge(int age)
        {
            this.Age = age;
        }
        public void changeCity(string city)
        {
            this.City = city;
        }
        public void changeCountry(string country)
        {
            this.Country = country;
        }
        public void changePronouns(string pronouns)
        {
            this.Pronouns = pronouns;
        }

        //propriertys
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null) name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18) age = value;
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (value != null) city = value;
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                if (value != null) country = value;
            }
        }
        public string Pronouns
        {
            get { return pronouns; }
            set
            {
                if (value != null) pronouns = value;
            }
        }
    }
}
