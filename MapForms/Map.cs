using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapForms
{
    public partial class MapContainer : Form
    {
        private static MapService.AjaxMapServiceSoap service;
        public MapContainer()
        {
            InitializeComponent();
        }

        private void init()
        {
            BaiduMap.Url = new System.Uri("http://localhost:58678/Map");
            CityNumVal.Text = System.Convert.ToString(service.CityNums());
            cityBindingSource.DataSource = service.Cities();
        }

        private void MapContainer_Load(object sender, EventArgs e)
        {
            service = new MapService.AjaxMapServiceSoapClient();
            init();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            init();
        }

        private void CitySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = CitySelect.SelectedValue;
            if (id == null) return;
            MapService.City city = service.GetCityById(System.Convert.ToInt32(id));
            CityNum.Text = city.Name;
        }
    }
}
