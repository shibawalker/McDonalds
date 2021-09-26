using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds
{
    class Orderitem {
        public int Index {  get; set; }
        public int Qty   {  get; set; }
        
        public bool Set  {  get; set; }
        public int SubTotal {  get; set; }
    }
}
