using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Net;

namespace Weather_Application
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        string fullName;
        Weather weather;
        public Main()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            FRM_Location fl = new FRM_Location();
            fl.ShowDialog();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            fullName = Properties.Settings.Default.fullName;
            await Task.Run(() => LoadData());
            ShowData();
        }
        private void LoadData()
        {
            var url = "http://api.weatherstack.com/current?access_key=dad7994fedfe6fe43ad8abe708c41a35&query=" + fullName;
            Class1 cl = new Class1();
            var data = cl.JsonConvert(url);
            weather = Newtonsoft.Json.JsonConvert.DeserializeObject<Weather>(data);

        }
        private void ShowData()
        {
            lbCity.Text = weather.request.query;
            lbDescription.Text = string.Join("", weather.current.weather_descriptions);
            ShowImage();
            //pb.Image = Image.FromStream(new StreamReader().ReadToEnd();
            lbTemperature.Text = weather.current.temperature.ToString();
            lbTemperature.Text = weather.current.wind_speed.ToString();
            lbHumdity.Text = weather.current.humidity.ToString();
        }

        private async void radRepeatButton1_Click(object sender, EventArgs e)
        {
            fullName = Properties.Settings.Default.fullName;
            await Task.Run(() => LoadData());
            ShowData();
        }
        private void ShowImage()
        {
            var request = WebRequest.Create(string.Join("", weather.current.weather_icons));
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pb.Image = Bitmap.FromStream(stream);
            }
        }

    }
}
