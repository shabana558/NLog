using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLog
{
    internal class Addition
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static void Sum(int first, int second)
        {
            if (first <= 0 || second <= 0)
            {
                //NLog.DebugInfo("Debug Unsuccessful due to wrong inputs");
                //NLog.ErrorInfo("Providing wrong inputs");
                //NLog.WarnInfo("Inputs should not be zero values");
                logger.Debug("Debug Unsuccessful due to wrong inputs");
                logger.Error("Providing wrong logger.Error(Providing wrong inputs");
            }
            else
            {
                int sum = first + second;
                Console.WriteLine("sum:" + sum);
                logger.Debug("Debug successful");
                logger.Info("Successfully caluculated sum:" + sum);
                //NLog.DebugInfo("Debug successful");
                //NLog.InfoLevel("Successfully caluculated sum:"+sum);
            }
        }
    }
}