using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebServer.Controllers
{
    public class CityController : Controller
    {
        private static MapService.AjaxMapServiceSoap service = new MapService.AjaxMapServiceSoapClient();
        //
        // GET: /MapAPI/

        public JsonResult Index()
        {
            return Json(
                service.Cities().Select(s => new {name = s.Name, code = s.Code}),
                JsonRequestBehavior.AllowGet
                );
        }
    }
}
