﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGV_V1._0.Network.MyException
{
    class PacketException:Exception
    {
        public string Message { get; private set; }
        public ExceptionCode Code { get; private set; }
        /// <summary>
        /// 异常
        /// </summary>
        /// <param name="message">出错位置，变量等信息说明</param>
        /// <param name="code">出错类型</param>
        public PacketException(string message,ExceptionCode code)
        {
            Message = message+":"+code;
            Code = code;
        }

    }
}
