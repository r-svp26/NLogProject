using System;
using System.Collections.Generic;
using System.Text;

namespace NLogProject
{
    class Addition

    {
        static NLog nlog = new NLog();
        public int Add(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                nlog.LogInfo("Sub method");
                nlog.LogDebug("Debug Successful");
                nlog.LogError("First Number or Second Number is zero.");
                return 0;
            }
            int sum = firstNumber + secondNumber;
            nlog.LogInfo("Sub method");
            nlog.LogDebug("Debug Successful");
            nlog.LogWarn("First Number or Second Number is zero.");
            return sum;
        }
    }
}
