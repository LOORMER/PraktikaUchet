using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrakrikaUP04._01.appData
{
    internal class Connect
    {
        public static PraktikaProninEntities c;
        public static PraktikaProninEntities context
        {
            get
            {
                if(c == null)
                    c = new PraktikaProninEntities();
                return c;
            }
        }
    }
    
}
