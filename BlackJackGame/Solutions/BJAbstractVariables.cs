 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public abstract class BJAbstractVariables
    {
        public abstract int Rand();
        public abstract string winner(int x, int y);
    }
}

