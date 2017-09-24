using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebServer.Controllers
{
    public class MapController : Controller
    {
        private static MapService.AjaxMapServiceSoap service = new MapService.AjaxMapServiceSoapClient();
        //
        // GET: /Map/

        public ActionResult Index(string type)
        {
            //Load /Views/Map/BaiduMap
            ViewData.Add("CityNum", service.CityNums());
            var cityName = "";
            foreach (string name in service.Cities().Select(s => s.Name)) {
                cityName += name + " ";
            }
            ViewData.Add("Cities", cityName);
            return View("BaiduMap");
        }

    }
}
