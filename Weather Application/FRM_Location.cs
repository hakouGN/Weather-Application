using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Collections;

namespace Weather_Application
{
    public partial class FRM_Location : Telerik.WinControls.UI.RadForm
    {
        Country c;

        // get or set data
        string countryName;
        string cityName;
        string fullName;
        List<string> listFullName = new List<string>();
       
        public FRM_Location()
        {
            InitializeComponent();
        }

        private async void FRM_Location_Load(object sender, EventArgs e)
        {
            await Task.Run(() => LoadData());
            await Task.Run(() => SetData());
            radDropDownList1.DataSource = listFullName;

        }
        private void LoadData()
        {
            
            Class1 cl = new Class1();
            var data = cl.JsonConvert("https://countriesnow.space/api/v0.1/countries");
            c = Newtonsoft.Json.JsonConvert.DeserializeObject<Country>(data);

        }
        private void SetData()
        {
            for (int i = 0; i < c.data.Length; i++)
            {
                countryName = c.data[i].country;
                for (int j = 0; j < c.data[i].cities.Length; j++)
                {
                    cityName = c.data[i].cities[j];
                    fullName = cityName + " , " + countryName;
                    listFullName.Add(fullName);
                }
            }

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.fullName = radDropDownList1.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("location saved");
            this.Close();
        }
    }
}
