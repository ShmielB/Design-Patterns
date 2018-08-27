using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logProduct
{
  public  class nLogProduct : LogProduct
    {
         private string _logType { get; set; }

        public nLogProduct(string logType)
        {
            _logType = logType;
        }

        public override string LogType
        {
            get{ return _logType; }
        }
    }
}
