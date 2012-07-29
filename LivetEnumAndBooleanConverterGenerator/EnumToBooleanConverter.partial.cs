using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivetEnumAndBooleanConverterGenerator
{
    partial class EnumToBooleanConverter
    {
        public string TypeName
        {
            get;
            set;
        }

        public IList<string> EnumMemberNames
        {
            get;
            set;
        }
    }
}
