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
                // string index = textBox1.Text.Substring(0, 3);


                txt_product.Text = (int.Parse(march)-100).ToString();
                txt_product.Text = "";
                txt_shift.Text = "";
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
