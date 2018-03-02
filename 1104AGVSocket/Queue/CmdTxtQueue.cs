using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGV_V1._0.Queue
{
    class CmdTxtQueue : BaseQueue<string>
    {
        private static CmdTxtQueue instance;
        public static CmdTxtQueue Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new CmdTxtQueue();
                }
                return instance;
            }
        }
    }
}
