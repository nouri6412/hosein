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

        public db database;

        public Form1()
        {
            this.pivot = new DateTime(2013, 6, 12);
            this.numb4 = 2;
            InitializeComponent();
            database = new db() { count=2, from=1, to=400, h=45, label=25, product=1, shift=1, w=188 };
            try
            {
                if (System.IO.File.Exists(@"" + Environment.CurrentDirectory.ToString() + "\\mbm.db"))
                {
                    using (System.IO.Stream stream = System.IO.File.Open(@"" + Environment.CurrentDirectory.ToString() + "\\mbm.db", System.IO.FileMode.Open))
                    {
                        var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        db salesman1 = (db)bformatter.Deserialize(stream);
                        database = salesman1;
                        try
                        {
                            txtFrom.Text = database.from.ToString();
                        }
                        catch { }
                        try
                        {
                            txtTo.Text = database.to.ToString();
                        }
                        catch { }
                        try
                        {
                            txt_w.Text = database.w.ToString();
                        }
                        catch { }

                        try
                        {
                            txt_h.Text = database.h.ToString();
                        }
                        catch { }

                        try
                        {
                            cbShift.Text = database.shift.ToString();
                        }
                        catch { }

                        try
                        {
                           cbLabel.Text = database.label.ToString();
                        }
                        catch { }

                        try
                        {
                            txtMerch.Text = database.product.ToString();
                        }
                        catch { }

                        try
                        {
                            DrCount.Text = database.product.ToString();
                        }
                        catch { }
                    }
                    //  System.IO.File.Delete(ss);
                }
            }
            catch { }
        }

        public void saveDB()
        {
            database.h =int.Parse( txt_h.Text);
            database.w = int.Parse(txt_w.Text);
            database.product = int.Parse(txtMerch.Text);
            database.count = int.Parse(DrCount.Text);
            database.from = int.Parse(txtFrom.Text);
            database.to = int.Parse(txtTo.Text);
            database.shift = int.Parse(cbShift.Text);
            try
            {
                using (System.IO.Stream stream = System.IO.File.Open(@"" + Environment.CurrentDirectory.ToString() + "\\mbm.db", System.IO.FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(stream, database);
                }
            }
            catch { }
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
                num = 45;
            }

            int width_image = 188;
            int height_image = 45;

            try
            {

            }
            catch
            {
            }

            Barcode barcode = new Barcode
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                Width = width_image,
                Height = height_image,
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveDB();
        }
    }

    [Serializable]
    public class db
    {
        public int shift { get; set; }
        public int label { get; set; }
        public int product { get; set; }
        public int count { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int from { get; set; }
        public int to { get; set; }
    }
}
