using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAI_MOBIL_ESHOP
{
    internal class loggerManager
    {
        private static String logger;

        public static void resetLogger()
        {
            logger = null;
        }

        public static String getLogger()
        {
            return logger;
        }

        public static void setLogger(String logger)
        {
            loggerManager.logger = logger;
        }
    }
}
