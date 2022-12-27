using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session3
{
    public class PhoneBook : AbstractPhone

    {
        public List<Phone> PhoneList;
        public PhoneBook()
        {
            this.PhoneList= new List<Phone>();
        }


        public override void insertPhone(string name, string phone)
        {
            foreach(Phone s in PhoneList)
            {
                if (s.name.Equals(name))
                {
                    for(int i=0;i<s.phoneNumbers.Count;i++)
                    {
                        if (phone.Equals(s.phoneNumbers[i]))
                        {
                            return;
                        }
                    }
                    s.phoneNumbers.Add(phone);
                }

            }
            Phone a = new Phone(name,phone);
            this.PhoneList.Add(a);
            
        }

        public override void RemovePhone(string name)
        {
            foreach(Phone s in PhoneList)
            {
                if(s.name.Equals(name))
                {
                    this.PhoneList.Remove(s);
                }
            }
        }

  

        public override Phone Search(string name)
        {
            foreach(Phone s in PhoneList)
            {
                if (s.name.Equals(name))
                {
                    return s;
                }
            }
            return null;
        }

        public override void Sort()
        {
           
        }

        public override void UpdatePhone(string name, string newphone)
        {
            foreach(Phone s in PhoneList)
            {
                if (s.name.Equals(name))
                {
                    this.PhoneList.Remove(s) ;
                }
            }
        }
    }
}
