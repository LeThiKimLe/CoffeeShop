using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BSLayer
{
    class QueryCoffee
    {
        public string GetCoffeeFormula(int coffeeId)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var formula = from item in context.Recipes where item.drink_id == coffeeId select item;
            string formulaString = string.Join(", ", formula.Select(item => string.Join(" ", item.Ingredient.name, item.amount, item.Ingredient.unit)));
            return formulaString;
        }
    }
}
