using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DateTime> dates = new List<DateTime>();

            DateTime startTime = DateTime.Now;
            // Добавляем 10_000 объектов DateTime
            for (int x = 0; x < 10_000; x++)
            {
                DateTime time = System.DateTime.Now;
                dates.Add(time);
            }
            DateTime stopTime = DateTime.Now;
            int finalTime = startTime.Millisecond - stopTime.Millisecond;
            DateTime dt = new DateTime(0, 0, 0, 0, 0, 0, finalTime, DateTimeKind.Local);
            label1.Text = dt.ToString();
            

        }
    }
}
