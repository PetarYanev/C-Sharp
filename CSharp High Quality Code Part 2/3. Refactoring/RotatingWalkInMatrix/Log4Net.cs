using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace RotatingWalkInMatrix
{
    public class Log4Net
    {
        public static readonly ILog Log = LogManager.GetLogger(typeof(Log4Net));
    }
}
