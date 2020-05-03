using System;
using System.Collections.Generic;

namespace SuperHeroesVillians
{
    class SuperHeroesVillains
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Villain("Vemon", "Spider-man"));
            people.Add(new Hero("Dr Strange", "Magic"));
            people.Add(new Person("Philip", "Burger-fan"));

            foreach (var Person in people)
            {
                Console.WriteLine(Person.PrintGreeting());
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public string NickName { get; set; } 

        public Person(string name, string nickName)
        {
            this.Name = name;
            this.NickName = nickName;
        }

        public virtual string PrintGreeting()
        {
            return $"Help, I'm a citizen named {Name}, I'm been kidnaped!";
        }
    }
    public class Hero : Person
    {
        public String SuperPower { get; set; }

            public Hero(string name, string superPower) : base(name, string.Empty)
            {
                this.Name = name;
                this.NickName = null;
                this.SuperPower = superPower;
            }

        public override string PrintGreeting()
        {
            return $"Have no fear, {Name} is here, and my {SuperPower} will save you!";
        }

    }
    public class Villain : Person
    {
        public String Nemesis { get; set; }

        public Villain(String name, String nemesis) : base(name, string.Empty)
        {
            this.Name = name;
            this.NickName = null;
            this.Nemesis = nemesis;
        }

        public override string PrintGreeting()
        {
            return $"I'm the {Name}, and I will defeat {Nemesis} today!";
        }
    }


}
