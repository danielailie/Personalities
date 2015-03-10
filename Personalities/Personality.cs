using System;
using System.Collections.Generic;
using System.IO;

namespace Personalities
{
    class Personality
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dob { get; set; }
        public string Dod { get; set; }

        public List<Personality> Personalities= new List<Personality>();

        public Personality(string firstName,string lastName,string dob,string dod)
        {
            FirstName = firstName;
            LastName = lastName;
            Dob = dob;
            Dod = dod;
        }

        public Personality()
        {
        }
        public void ReadFromFile(string file)
        {
            using (var reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    var personality =new Personality(parts[0], parts[1] ,parts[2],parts[3]);
                    Personalities.Add(personality);
                }
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} ({2} - {3})", FirstName, LastName, Dob, Dod);
        }
    }
}
