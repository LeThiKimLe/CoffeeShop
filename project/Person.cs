using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project
{
    public abstract class Person
    {
        private string name;
        private string phone;
        private int id;
        private int role;

        public Person(string name, string phone, int id, int role)
        {
            this.name = name;
            this.phone = phone;
            this.id = id;
            this.role = role;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Role
        {
            get { return role; }
            set { role = value; }
        }

        public abstract void PrintDetails();

    }
}