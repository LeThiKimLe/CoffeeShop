using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BSLayer
{
    class QueryManager
    {
        public List<Material> GetListIngredient()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var objectMaterial = from item in context.Ingredients where item.active == true select item;
            List<Material> listOrder = objectMaterial.Select(o => new Material(o.id, o.name, (int)o.count, o.unit)).ToList();
            return listOrder;
        }

        public bool EditIngredient(int itemId, string name, string unit, int count)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            Ingredient item = context.Ingredients.FirstOrDefault(o => o.id == itemId);
            if (item != null)
            {
                item.name = name;
                item.unit = unit;
                item.count = count;
                context.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public bool AddIngredient(string name, string unit, int count)
        {
            try
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                int newID = context.Ingredients.Max(o => o.id) + 1;
                Ingredient newIngredient = new Ingredient();
                newIngredient.id = newID;
                newIngredient.name = name;
                newIngredient.unit = unit;
                newIngredient.count = count;
                newIngredient.active = true;
                context.Ingredients.InsertOnSubmit(newIngredient);
                context.SubmitChanges();
                return true;
            } catch (Exception err)
            {
                return false;
            }
            
        }

        public bool DeleteIngredient(int itemId)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            Ingredient item = context.Ingredients.FirstOrDefault(o => o.id == itemId);
            if (item != null)
            {
                item.active = false;
                context.SubmitChanges();
                return true;
            }
            else
                return false;
        }
    }
}
