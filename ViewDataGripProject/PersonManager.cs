using System;
using System.Collections.Generic;
using System.IO;

namespace ViewDataGripProject
{
    public static class PersonManager
    {
        public static List<Person> Create(int count)
        {
            List<Person> persons = new List<Person>(count);
            var names = GetNamesFromFile();
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                persons.Add(new Person()
                {
                    ID=random.Next(1,100),
                    Age = random.Next(1, 100),
                    Name = names[random.Next(0, count)]
                });
            }

            return persons;
        }

        private static string[] GetNamesFromFile()
        {
            var text = File.ReadAllText("names.txt");
            return text.Split(",");
        }
    }
}



