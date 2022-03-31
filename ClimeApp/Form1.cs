using ClimeApp.DataAccess.Repositories;
using ClimeApp.Domain.Entities;
using ClimeDao.AppCore.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClimeApp
{
    public partial class Form1 : Form
    {
        IClimeServices clime;
        public Form1(IClimeServices clime)
        {
            this.clime = clime;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = clime.weatherClimeDao(textBox1.Text);
                ChargeLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargeLabels()
        {
            lblLong.Text = clime.weatherClimeDao(textBox1.Text)[0].Lon.ToString();
            lblLat.Text = clime.weatherClimeDao(textBox1.Text)[0].Lat.ToString();
            lblTemp.Text = clime.weatherClimeDao(textBox1.Text)[0].Temp.ToString();
            lblFeelLike.Text = clime.weatherClimeDao(textBox1.Text)[0].Feels_like.ToString();
            lblFeelMin.Text = clime.weatherClimeDao(textBox1.Text)[0].Feels_min.ToString();
            lblFeelMax.Text = clime.weatherClimeDao(textBox1.Text)[0].Temp_max.ToString();
            lblPressure.Text = clime.weatherClimeDao(textBox1.Text)[0].Pressure.ToString();
            lblHumidity.Text = clime.weatherClimeDao(textBox1.Text)[0].Humidity.ToString();
            lblType.Text = clime.weatherClimeDao(textBox1.Text)[0].Type.ToString();
            lblMessage.Text = clime.weatherClimeDao(textBox1.Text)[0].Message.ToString();
            lblCountry.Text = clime.weatherClimeDao(textBox1.Text)[0].Country.ToString();
            lblSunrise.Text = clime.weatherClimeDao(textBox1.Text)[0].Sunrise.ToString();
            lblSunset.Text = clime.weatherClimeDao(textBox1.Text)[0].Sunset.ToString();
            lblMain.Text = clime.weatherClimeDao(textBox1.Text)[0].Main.ToString();
            lblDescription.Text = clime.weatherClimeDao(textBox1.Text)[0].Description.ToString();
            lblIcon.Text = clime.weatherClimeDao(textBox1.Text)[0].Icon.ToString();
            lblSpeed.Text = clime.weatherClimeDao(textBox1.Text)[0].speed.ToString();

        }
    }
}