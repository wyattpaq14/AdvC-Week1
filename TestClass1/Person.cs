using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass1
{
    public class Person
    {
        private string fname;
        private string lname;

        public Person(string fname, string lname)
        {
            this.Fname = fname;
            this.Lname = lname;
        }

        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }

        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }


        public string retreivePersonData()
        {
            return "Name: " + fname + " " + lname;
        }

    }
}
