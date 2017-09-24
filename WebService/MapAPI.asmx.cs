using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Map API Service used for WebServer
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AjaxMapService : System.Web.Services.WebService
    {
        private static EntityDB.MapModelEntity MapEntityContext = new EntityDB.MapModelEntity();
        private static IQueryable<EntityDB.City> cityQuery = from city in MapEntityContext.Cities.Where(s => s.Name != null)
                                              select city;
        private static IQueryable<EntityDB.Device> deviceQuery = from device in MapEntityContext.Devices
                                                             select device;

        [WebMethod]
        public int CityNums()
        {
            return cityQuery.Count();
        }

        [WebMethod]
        public EntityDB.City[] Cities()
        {
            return cityQuery.ToArray();
        }

        [WebMethod]
        public EntityDB.City GetCityById(int Id)
        {
            return cityQuery.First(s => s.Id == Id);
        }

        [WebMethod]
        public int DeviceNums()
        {
            return deviceQuery.Count();
        }

        [WebMethod]
        public EntityDB.Device[] Devices()
        {
            return deviceQuery.ToArray();
        }

        [WebMethod]
        public EntityDB.Device GetDeviceById(int Id)
        {
            return deviceQuery.First(s => s.Id == Id);
        }

        [WebMethod]
        public EntityDB.Device AddDevice(string name, string longitude, string latitude)
        {
            var device = EntityDB.Device.CreateDevice(0, name, latitude, longitude);
            MapEntityContext.AddToDevices(device);
            MapEntityContext.SaveChanges();
            return device;
        }
    }
}