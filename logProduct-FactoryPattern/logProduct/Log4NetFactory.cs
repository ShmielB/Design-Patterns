using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logProduct
{
    public class Log4NetFactory : LogFactory
    {
        private string _logType;
        
        public Log4NetFactory(string logType)
        {
            _logType = logType;
        }

        public override LogProduct GetLog()
        {
            return new Log4NetProduct(_logType,0);
        }
    }
}
