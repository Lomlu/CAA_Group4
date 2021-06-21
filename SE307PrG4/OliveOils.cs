using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE307PrG4
{
    class OliveOil : Kitchen 
    {
        private string catg="OliveOil";

        public override void SetCategory()
        {
            this.catg = "OliveOils";
        }

        public override string GetCategory()
        {
            return this.catg;
        }
    }
}
