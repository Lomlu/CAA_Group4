using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE307PrG4
{
    class Dessert : Kitchen
    {
        private string catg = "Dessert";

        public Dessert()
        {

        }

        public override void SetCategory()
        {
            this.catg = "Desserts";
        }

        public override string GetCategory()
        {
            return this.catg;
        }

    }
}
