using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPlatormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "N/A";
            label2.Text = "No sensor detected";
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;
            timer1.Enabled = true;
        }

        YSensor sensor = null;
        int hardwaredetect = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string errmsg = "";
            if (hardwaredetect == 0)
                YAPI.UpdateDeviceList(ref errmsg);
            hardwaredetect = (hardwaredetect + 1) % 20;
            YAPI.HandleEvents(ref errmsg);
            if (sensor == null)
                sensor = YSensor.FirstSensor();
            if (sensor != null) {
                if (sensor.isOnline()) {
                    label1.Text = sensor.get_friendlyName();
                    label2.Text = sensor.get_currentValue() + " " + sensor.get_unit();
                } else {
                    label1.Text = "OFFLINE";
                    label2.Text = "Sensor is offline";
                    sensor = null;
                }
            }
        }
    }
}