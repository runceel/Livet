using System;
using System.Collections.Generic;

namespace LivetControlBindingSupportGenerator
{
    public partial class SetStateToControlBehavior
    {
        public string TypeName
        {
            get;
            set;
        }

        public Dictionary<string, Type> SetterHavingTargetProperties
        {
            get;
            set;
        }
    }
}