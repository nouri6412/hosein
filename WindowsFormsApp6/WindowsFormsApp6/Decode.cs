using BarcodeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Decode : Form
    {
        public Decode()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this.merchCode3 = Convert.ToInt16(this.txtMerch.Text) + 100;
            //TimeSpan span = (TimeSpan)(this.persianDateTimePicker1.GregorianDate - this.pivot);
            //this.serieCode5 = (int)((span.TotalDays * 3.0) + Convert.ToDouble(this.cbShift.Text));

            try
            {
                string march = textBox1.Text.Substring(0,3);
                string shift = textBox1.Text.Substring(3, 5);
                txt_product.Text = (int.Parse(march) - 100).ToString();
                double db = Convert.ToDouble(shift);
                double mode = db % 3;
                if(mode==1)
                {
                    txt_shift.Text = "1";
                }
                else if (mode == 2)
                {
                    txt_shift.Text = "2";
                }
                else
                {
                    txt_shift.Text = "3";
                }
                DateTime date= new DateTime(2013, 6, 12);
                double t1 = db - mode;
                t1 = t1 / 3;
                TimeSpan ts = new TimeSpan(int.Parse(t1.ToString()), 0,0,0);
                date = date + ts;
                // string index = textBox1.Text.Substring(0, 3);



                txt_date.Text = date.ToShortDateString();


            }
            catch
            {
                txt_date.Text = "";
                txt_product.Text = "";
                txt_shift.Text = "";
            }
        }
    }
}
