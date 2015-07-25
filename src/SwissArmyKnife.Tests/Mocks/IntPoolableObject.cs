using SwissArmyKnife.Pools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissArmyKnife.Tests.Mocks
{
    public class IntPoolableObject : PoolableObject
    {
        public int Data
        {
            get;
            set;
        }

        protected override void Reset()
        {
            this.Data = 0;
        }
    }
}
