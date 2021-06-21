using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE307PrG4
{
    class Soup : Kitchen
    { 
        private string catg = "Soup";

        public override void SetCategory()
        {
            this.catg = "Soups";
        }

        public override string GetCategory()
        {
            return this.catg;
        }

    }
}
