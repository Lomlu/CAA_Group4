using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE307PrG4
{
    class Salad : Kitchen
    {
        private string catg = "Salad";

        public override void SetCategory()
        {
            this.catg = "Salads";
        }

        public override string GetCategory()
        {
            return this.catg;
        }

    }
}
