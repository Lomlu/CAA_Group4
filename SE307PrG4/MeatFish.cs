using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE307PrG4
{

    class MeatFish : Kitchen
    {
        private string catg = "MeatFish";


        public override void SetCategory()
        {
            this.catg = "MeatFish";
        }

        public override string GetCategory()
        {
            return this.catg;
        }
    }
}
