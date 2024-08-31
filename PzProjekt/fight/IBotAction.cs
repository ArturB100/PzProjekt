using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt.fight
{
    public interface IBotAction
    {
        public void MakeMove(Fight fight);
        public string NameOfPlugin ();
    }
}
