using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project
{
    public class Manager : Person
    {
        private Dictionary<string, int> inventory;
        private List<project.Barista> staff;

        public Manager(string name, string phone, int id, int role = 1) : base(name, phone, id, role) 
        { 
            inventory = new Dictionary<string, int>(); 
            //staff = new List<project.Barista>(); 
        }

        public override void PrintDetails()
        {

        }
        public void ManageInventory()
        {
            throw new System.NotImplementedException();
        }

        public void ManageStaff()
        {
            throw new System.NotImplementedException();
        }

    }
}