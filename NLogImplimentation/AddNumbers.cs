using System;
using System.Collections.Generic;
using System.Text;

namespace NLogImplimentation
{
    public class AddNumbers
    {
        NLog nlog = new NLog();
        public int Sum(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                nlog.LogDebug("Debug Successfull : sum()");
                nlog.LogError("Expecting null value");
                nlog.LogWarn("a or b should not equal to 0");
            }
            int c = a + b;
            nlog.LogDebug("Debug Successful");
            return c;


        }
    }
    
}
