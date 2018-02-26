using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProOperation;

namespace Cheng
{
    public class Cheng : Operation
    {
        public Cheng(int n1,int n2):base(n1, n2)
        { }
        public override string Type
        {
            get
            {
                return "*";
            }

            set
            {
                
            }
        }

        public override int GetResult()
        {
            return this.NumberOne * this.NumberTwo;
        }
    }
}
