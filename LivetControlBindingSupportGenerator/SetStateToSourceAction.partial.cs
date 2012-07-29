using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivetControlBindingSupportGenerator
{
    public partial class SetStateToSourceAction
    {

        public string TypeName
        {
            get;
            set;
        }

        public Dictionary<string, Type> GetterHavingTargetProperties
        {
            get;
            set;
        }
    }
}
