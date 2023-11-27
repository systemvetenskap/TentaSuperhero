using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    class HeadQuarters
    {
         public List<Hero> Avengers { get; set; } = new List<Hero>
{
      new Hero("Tony", "Stark", "Ironman", 5324),
      new Hero("Hank", "Pym", "Ant-Man",  4869),
      new Hero("Steven", "Rogers", "Captain America", 3172),
      new Hero("Janet", "van Dyne", "Wasp", 4765),
      new Hero("Bruce", "Banner", "Hulk", 4929),
      new Hero("Carol", "Danvers", "miss Marvel", 2953),
      new Hero("T'Challa", "Black Panther", 1571),
      new Hero("Clint", "Barnton", "Hawkeye", 3543),
      new Hero("Thor", 678)
};
        public string Address { get; set; } = "Avengers Mansion 200 Park Avenue, New York, NY, USA";
        public HeadQuarters()
        {
            //FillAvengers();
            Hero hero = new Hero()
            {
                Name = "Erik",
                Home = 5324
            };
        }

        public Hero GetNearestHero(int pointOfInterest)
        {
            int nearest = int.MaxValue;
            Hero nearestHero = null;
            foreach (Hero hero in Avengers)
            {
                int distance = CalculateDistance(hero, pointOfInterest);
                if (distance < nearest)
                {
                    nearest = distance;
                    nearestHero = hero;
                }
            }
            return nearestHero;
        }

        public string GetEncryptedMessage(string message)
        {
            int code = 'E';            string encrypted = string.Empty;            foreach (char letter in message)
            {
                code = letter + 14;
                encrypted += code;
                encrypted += ";";
            }            string test = TrimMessage(encrypted);            return encrypted.Substring(0, encrypted.Length - 1);        }

        public List<string> GetSecrets(string message)
        {
            List<string> secrets = new List<string>();
            foreach(Hero hero in Avengers)
            {
                string encrypted = hero.GetEncryptedMessage(message);
                secrets.Add(encrypted);
            }
            return secrets;
        }

        private string TrimMessage(string text)
        {
            string fixedString = string.Empty;
            
            for (int i = 0; i < text.Length-1; i++)
            {
                fixedString += text[i];
            }
            return fixedString;
        }

        public int CalculateTotalDistance(int pointOfInterest)
        {
            int totalDistance = 0;  
            foreach (Hero hero in Avengers)
            {
                totalDistance += CalculateDistance(hero, pointOfInterest);
            }
            return totalDistance;
        }

        private int CalculateDistance(Hero hero, int pointOfInterest)
        {
            return Math.Abs(hero.Home - pointOfInterest);
        }

        private void FillAvengers()
        {
            Avengers = new List<Hero>
            {
                new Hero("Tony", "Stark", "Ironman", 5324),
                new Hero("Hank", "Pym", "Ant-Man",  4869),
                new Hero("Steven", "Rogers", "Captain America", 3172),
                new Hero("Janet", "van Dyne", "Wasp", 4765),
                new Hero("Bruce", "Banner", "Hulk", 4929),
                new Hero("Carol", "Danvers", "miss Marvel", 2953),
                new Hero("T'Challa", "Black Panther", 1571),
                new Hero("Clint", "Barnton", "Hawkeye", 3543),
                new Hero("Thor", 678)
            };
    }
    }
}
