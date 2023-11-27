using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    class Hero
    {
        public string Name { get; set; }
        public int Home { get; set; }

        private string _firstname;
        private string _lastname;


        private int CalculateNameKey()
        {
            int length = 0;
            if (_firstname != null)
            {
                length += _firstname.Length;
            }
            if(length== 0)
            {
                length = 14;
            }
            return length;
        }


        public Hero(string firstname, string lastname, string name, int home)
        {
            firstname = _firstname;
            lastname = _lastname;
            Name = name;
            Home = home;
        }
        // "T'Challa", "Black Panther", 1571
        public Hero(string lastname, string name, int home) 
        {
            _lastname = lastname;
            Name = name;
            Home = home;
        }
        public Hero( string name, int home)
        {
            Name = name;
            Home = home;
        }
        public Hero()
        {
                
        }

        public string GetEncryptedMessage(string message)
        {
            return "";
        }
    }
}
