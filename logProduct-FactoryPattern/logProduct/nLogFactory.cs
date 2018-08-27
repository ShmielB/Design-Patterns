using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logProduct
{

    public class nLogFactory : LogFactory
    {
        public string _logType { get; set; }

        public nLogFactory(string logType)
        {
            _logType = logType;
        }

        public override LogProduct GetLog()
        {
            return new nLogProduct(_logType);
        }
    }
}

