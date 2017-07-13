using System;

namespace DriveFitnessLibrary
{
    [Serializable]
    public class Person
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string Email { get; private set; }
        public string Telephone { get; private set; }
        public DateTime Birthday { get; private set; }

        public Person(int id, string n, string l, DateTime b, string e, string t)
        {
            ID = id;
            Name = n;
            LastName = l;
            Birthday = b;
            Email = e;
            Telephone = t;
            Age = GetAge(Birthday);
        }

        public Person(string n, string l, DateTime b, string e, string t)
        {
            Name = n;
            LastName = l;
            Birthday = b;
            Email = e;
            Telephone = t;
            Age = GetAge(Birthday);
        }

        int GetAge(DateTime birthday)
        {
            DateTime nowDate = DateTime.Today;
            int age = nowDate.Year - birthday.Year;
            if (birthday > nowDate.AddYears(-age)) age--;

            return age;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", LastName, Name);
        }
    }
}
