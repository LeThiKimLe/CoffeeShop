using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Material
    {
        private string name;
        private int count;
        private string unit;
        private int id;

        public Material(int materialId, string materialName, int materialAmount, string materialUnit)
        {
            id = materialId;
            name = materialName;
            count = materialAmount;
            unit = materialUnit;
        }
        public int Id
        {
            get => id;
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

        public int Count
        {
            get => count;
            set
            {
                count = value;
            }
        }

        public string Unit
        {
            get => unit;
            set
            {
                unit = value;
            }
        }
    }
}
