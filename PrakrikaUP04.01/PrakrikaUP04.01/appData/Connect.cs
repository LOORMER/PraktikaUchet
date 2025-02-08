using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakrikaUP04._01.appData
{
    internal class Connect
    {
        public static Database1Entities c;
        public static Database1Entities context
        {
            get
            {
                if(c == null)
                    c = new Database1Entities();
                return c;
            }
        }
    }
    
}
