using BarcodeLib;
using PersianDateLibrary;
using Stimulsoft.Report;
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
    public partial class Form1 : Form
    {
        private DateTime pivot;

        public Form1()
        {
            this.pivot = new DateTime(2013, 6, 12);
            this.numb4 = 2;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.persianDateTimePicker1.GregorianDate = now;

        }

        private int CentimeterToPixel(double Centimeter)
        {
            double num = -1.0;
            Graphics objA = base.CreateGraphics();
            try
            {
                num = (Centimeter * objA.DpiY) / 2.54;
            }
            finally
            {
                if (!ReferenceEquals(objA, null))
                {
                    objA.Dispose();
                }
            }
            return (int)num;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            int num = 60;
            if (this.cbLabel.Text == "label")
            {
                num = 0x2d;
            }
            Barcode barcode = new Barcode
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                Width = 200,
                Height = num,
                RotateFlipType = RotateFlipType.RotateNoneFlipNone,
                BackColor = Color.White,
                ForeColor = Color.Black
            };
            int num2 = Convert.ToInt16(this.txtFrom.Text);
            int num3 = Convert.ToInt16(this.txtTo.Text);
            this.merchCode3 = Convert.ToInt16(this.txtMerch.Text) + 100;
            TimeSpan span = (TimeSpan)(this.persianDateTimePicker1.GregorianDate - this.pivot);
           // MessageBox.Show(span.TotalDays.ToString());
            this.serieCode5 = (int)((span.TotalDays * 3.0) + Convert.ToDouble(this.cbShift.Text));
            Image[] imageArray = new Image[(num3 - num2) + 1];
            int cnt = 2;
            try
            {
                cnt = int.Parse(DrCount.Text);
            }
            catch { }
            int index = num2;
            while (true)
            {
                bool flag = index <= num3;
                if (!flag)
                {
                    Image[] imageArray2 = new Image[imageArray.Length * cnt];
                    index = 0;
                    while (true)
                    {
                        flag = index < imageArray2.Length;
                        if (!flag)
                        {
                            this.stiReport1.Load(this.cbLabel.Text + ".mrt");
                            DataTable dataTable = new DataTable();
                            dataTable.Columns.Add("pic", typeof(Image));
                            Image[] imageArray3 = imageArray2;
                            int num5 = 0;
                            while (true)
                            {
                                flag = num5 < imageArray3.Length;
                                if (!flag)
                                {
                                    this.stiReport1.RegData("dtp", dataTable);
                                    this.stiReport1.Show();
                                    return;
                                }
                                Image image = imageArray3[num5];
                                object[] values = new object[] { image };
                                dataTable.Rows.Add(values);
                                num5++;
                            }
                        }
                        Image image1 = imageArray[index / cnt];


                        Image image3  = image1;
                        for(int i=0;i<cnt;i++)
                        {
                            imageArray2[index + i] = image3;
                        }
                        index += cnt;
                    }
                }
                string ss1 = this.merchCode3.ToString("D3") + this.serieCode5.ToString("D5") + index.ToString("D4");
                test.Text = ss1;
                imageArray[index - num2] = barcode.Encode(TYPE.EAN13, ss1);
                index++;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Decode frm = new Decode();
            frm.ShowDialog();
        }
    }
}
