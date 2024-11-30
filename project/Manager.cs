using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using project.BSLayer;

namespace project
{
    public class Manager : Person
    {
        private Dictionary<string, int> inventory;
        private List<project.Barista> staff;
        private QueryManager query = new QueryManager();

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

        public List<Material> GetListMaterial()
        {
            return query.GetListIngredient();    
        }

        public bool EditMaterial(int itemId, string name, string unit, int count)
        {
            return query.EditIngredient(itemId, name, unit, count);
        }

        public bool AddMaterial(string name, string unit, int count)
        {
            return query.AddIngredient(name, unit, count);
        }

        public bool DeleteMaterial(int itemId)
        {
            return query.DeleteIngredient(itemId);
        }

    }
}