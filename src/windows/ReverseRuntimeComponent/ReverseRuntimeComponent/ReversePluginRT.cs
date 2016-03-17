using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseRuntimeComponent
{
    public sealed class ReversePluginRT
    {
        public static String Reverse(String inStr)
        {
            String outStr = "";
            for (int i=inStr.Length; i>0;i--)
            {
                outStr += inStr.ElementAt(i - 1);
            }
            return outStr;
        }
    }
}
