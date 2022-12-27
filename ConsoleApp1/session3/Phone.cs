using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session3
{
    public class Phone
    {
        public string name { get; set; }
        public List<string> phoneNumbers;
        public Phone() { 
        }
        public Phone(string name, string phone)
        {
            this.name = name;
            this.phoneNumbers = new List<String>();
            this.phoneNumbers.Add(phone);
        }
       

    }
}
