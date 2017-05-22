using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJLogicLevel.Model
{
    class GamesNumber
    {
        private static int instance=0;

        private GamesNumber() { }
        public static int getInstance()
        {
           return instance++;
        }
    }
}
