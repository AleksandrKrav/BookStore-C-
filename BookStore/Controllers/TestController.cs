using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public string Index()        
            {
                string browser = HttpContext.Request.Browser.Browser;
                string user_agent = HttpContext.Request.UserAgent;
                string url = HttpContext.Request.RawUrl;
                string ip = HttpContext.Request.UserHostAddress;
                string referrer = HttpContext.Request.UrlReferrer == null ? "" : HttpContext.Request.UrlReferrer.AbsoluteUri;
                return "<p>Browser: " + browser + "</p><p>User-Agent: " + user_agent + "</p><p>Url запроса: " + url +
                    "</p><p>Реферер: " + referrer + "</p><p>IP-адрес: " + ip + "</p>";
            }        
	}
}