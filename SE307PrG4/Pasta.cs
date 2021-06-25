using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE307PrG4
{
    class Pasta : Kitchen
    {
        private string catg = "Pasta";

        public Pasta()
        {

        }

        public override void SetCategory()
        {
            this.catg = "Pasta";  
        }

        public override string GetCategory()
        {
            return this.catg;
        }
    }
}
