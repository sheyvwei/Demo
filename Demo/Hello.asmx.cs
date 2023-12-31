﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Demo
{
    /// <summary>
    /// Hello 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class Hello : System.Web.Services.WebService
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Hello));

        [WebMethod]
        public string HelloWorld()
        {
            log.Info($"{ DateTime.Now.ToString()}");
            return "Hello World";
        }

        [WebMethod]
        public string getLog()
        {
            return "写日志";
        }
    }
}
