using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hlp_lab_5_static_properties
{
    class Test
    {
        private static int count = 0;

        private int index;

        public Test()
        {
            count++;
            this.index = count;
        }

        public int GetCount()
        {
            return count;
        }

        public int GetIndex()
        {
            return this.index;
        }
    }
}
