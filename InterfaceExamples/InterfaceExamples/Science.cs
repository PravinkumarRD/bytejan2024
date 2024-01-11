using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    class ScienceBase
    {

    }
    //internal class Science : ScienceBase, IPhysics, IBiology, IChemistry
    internal class Science : ScienceBase, IScience
    {
        void IBiology.BiologyCalci()
        {
            throw new NotImplementedException();
        }

        void IChemistry.ChemistryCalci()
        {
            throw new NotImplementedException();
        }

        void IPhysics.PhysicCalci()
        {
            throw new NotImplementedException();
        }
    }
}
