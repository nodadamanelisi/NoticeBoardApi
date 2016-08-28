using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class Log4Net
    {
        public static void Log(string inputType)
        {
            SetUp.Setup();
            //ICollection config = null;
            //config = config.Count.Equals(0) ? 
            //    log4net.Config.BasicConfigurator.Configure() : config;
            log4net.ILog log = log4net.LogManager.GetLogger(inputType);
            log.Info("Testing message.");
            //log.Error("InnerException: " +ex.InnerException);
            //log.Error("Source: "+ex.Source);
            //log.Error("StackTrace: " + ex.StackTrace);
        }
    }
}
