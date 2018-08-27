using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logProduct
{
    public class  Log4NetProduct : LogProduct
    {
        public string _logType { get; set; }
        

        public Log4NetProduct(string logType,Operator op)
        {
            _logType = logType;
        }

        public override string LogType
        {
            get { return _logType; }
        }
    }
}
