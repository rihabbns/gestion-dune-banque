using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque
{
    class actG
    {

        public static int useridglobale { get; private set; }
        public static void mettreidglobale(int userid)
        {
            useridglobale = userid;
        }
    }
}
