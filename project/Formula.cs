using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Formula
    {
        private Coffee coffee;
        private Material material;
        private double amount;

        public Formula(Coffee drink, Material ingredient, double amount)
        {
            coffee = drink;
            material = ingredient;
            this.amount = amount;
        }

        public Coffee Coffee
        {
            get => coffee;
            set
            {
                coffee = value;
            }
        }

        public Material Material
        {
            get => material;
            set
            {
                material = value;
            }
        }

        public double Amount
        {
            get => amount;
            set
            {
                amount = value;
            }
        }
    }
}
