using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logProduct
{
    public abstract class LogProduct
    {
        public enum Operator { log4net, nlog };
        public abstract string LogType { get;}
    }
}
