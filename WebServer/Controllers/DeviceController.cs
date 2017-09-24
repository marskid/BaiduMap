using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebServer.Controllers
{
    public class DeviceController : Controller
    {
        //
        // GET: /Device/

        public JsonResult Index()
        {
            MapService.AjaxMapServiceSoapClient service = new MapService.AjaxMapServiceSoapClient();
            var data = service.Devices().Select(s => new { name = s.Name, latitude = s.Latitude, longitude = s.Longitude });
            service.Close();
            return Json(
                new { state = "Success", data = data, code = 200 },
                JsonRequestBehavior.AllowGet
                );
        }

        //
        // GET: /Device/Details/5

        public JsonResult Details(int id)
        {
            MapService.AjaxMapServiceSoapClient service = new MapService.AjaxMapServiceSoapClient();
            var device = service.GetDeviceById(id);
            service.Close();
            return Json(
                new { state = "Success", data = new { name = device.Name, longitude = device.Longitude, latitude = device.Latitude }, code = 200 },
                JsonRequestBehavior.AllowGet
                );
        }

        //
        // GET: /Device/Create

        public JsonResult Create(string name, string longitude, string latitude)
        {
            MapService.AjaxMapServiceSoapClient service = new MapService.AjaxMapServiceSoapClient();
            var device = service.AddDevice(name, longitude, latitude);
            service.Close();
            return Json(new { state = "Success", data = new { name = device.Name, longitude = device.Longitude, latitude = device.Latitude }, code = 200 },
                JsonRequestBehavior.AllowGet);
        }

        //
        // POST: /Device/Create

        [HttpPost]
        public JsonResult Create(FormCollection collection)
        {
            MapService.Device device = new MapService.Device() { 
                Name = collection.Get("name"),
                Latitude = collection.Get("latitude"),
                Longitude = collection.Get("longitude")
            };
            return Json(new { state = "Success", data = new { name = device.Name, longitude = device.Longitude, latitude = device.Latitude }, code = 200 });
        }
        
        //
        // GET: /Device/Edit/5
 
        public JsonResult Edit(int id)
        {
            return Json(new { state = "Success", code = 200 });
        }

        //
        // POST: /Device/Edit/5

        [HttpPost]
        public JsonResult Edit(int id, FormCollection collection)
        {
            return Json(new { state = "Success", code = 200 });
        }

        //
        // GET: /Device/Delete/5
 
        public JsonResult Delete(int id)
        {
            return Json(new { state = "Success", code = 200 }, JsonRequestBehavior.AllowGet);
        }

        //
        // POST: /Device/Delete/5

        [HttpPost]
        public JsonResult Delete(int id, FormCollection collection)
        {
            return Json(new { state = "Success", code = 200 });
        }
    }
}
