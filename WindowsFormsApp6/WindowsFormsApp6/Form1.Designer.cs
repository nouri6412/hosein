using PersianDateLibrary;
using Stimulsoft.Report;
using Stimulsoft.Report.Engine;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Create = new System.Windows.Forms.Button();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbShift = new System.Windows.Forms.ComboBox();
            this.cbLabel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.persianDateTimePicker1 = new PersianDateLibrary.PersianDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMerch = new System.Windows.Forms.TextBox();
            this.DrCount = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(80, 242);
            this.Create.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(105, 33);
            this.Create.TabIndex = 0;
            this.Create.Text = "ایجاد";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // stiReport1
            // 
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "4de2ca2f50ea4309b4167cfcac948005";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = null;
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(213, 87);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtFrom.MaxLength = 4;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(91, 22);
            this.txtFrom.TabIndex = 2;
            this.txtFrom.Text = "1";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(80, 87);
            this.txtTo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTo.MaxLength = 4;
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(94, 22);
            this.txtTo.TabIndex = 3;
            this.txtTo.Text = "400";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "تا";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "از";
            // 
            // cbShift
            // 
            this.cbShift.FormattingEnabled = true;
            this.cbShift.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbShift.Location = new System.Drawing.Point(80, 119);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(160, 22);
            this.cbShift.TabIndex = 5;
            this.cbShift.Text = "1";
            // 
            // cbLabel
            // 
            this.cbLabel.FormattingEnabled = true;
            this.cbLabel.Items.AddRange(new object[] {
            "1",
            "2",
            "25",
            "3"});
            this.cbLabel.Location = new System.Drawing.Point(80, 152);
            this.cbLabel.Name = "cbLabel";
            this.cbLabel.Size = new System.Drawing.Size(160, 22);
            this.cbLabel.TabIndex = 6;
            this.cbLabel.Text = "label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 123);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(44, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "شیفت:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 155);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "لیبل:";
            // 
            // persianDateTimePicker1
            // 
            this.persianDateTimePicker1.BackColor = System.Drawing.SystemColors.Control;
            this.persianDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianDateTimePicker1.Format = PersianDateLibrary.PersianDateTimePicker.DateFormat.Long;
            this.persianDateTimePicker1.GregorianDate = new System.DateTime(2013, 6, 12, 0, 0, 0, 0);
            this.persianDateTimePicker1.Location = new System.Drawing.Point(80, 49);
            this.persianDateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.persianDateTimePicker1.MaxDate = "1500/4/23";
            this.persianDateTimePicker1.MinDate = "1200/2/15";
            this.persianDateTimePicker1.Name = "persianDateTimePicker1";
            this.persianDateTimePicker1.Size = new System.Drawing.Size(251, 30);
            this.persianDateTimePicker1.TabIndex = 7;
            this.persianDateTimePicker1.Value = "1392/03/22";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 187);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(64, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "کد محصول:";
            // 
            // txtMerch
            // 
            this.txtMerch.Location = new System.Drawing.Point(80, 183);
            this.txtMerch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMerch.MaxLength = 3;
            this.txtMerch.Name = "txtMerch";
            this.txtMerch.Size = new System.Drawing.Size(160, 22);
            this.txtMerch.TabIndex = 8;
            this.txtMerch.Text = "1";
            // 
            // DrCount
            // 
            this.DrCount.FormattingEnabled = true;
            this.DrCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.DrCount.Location = new System.Drawing.Point(80, 212);
            this.DrCount.Name = "DrCount";
            this.DrCount.Size = new System.Drawing.Size(160, 22);
            this.DrCount.TabIndex = 11;
            this.DrCount.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 215);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(40, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "تعداد :";
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(28, 285);
            this.test.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.test.MaxLength = 4;
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(146, 22);
            this.test.TabIndex = 12;
            this.test.Text = "1";
            this.test.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 279);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Decode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.test);
            this.Controls.Add(this.DrCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMerch);
            this.Controls.Add(this.persianDateTimePicker1);
            this.Controls.Add(this.cbLabel);
            this.Controls.Add(this.cbShift);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.Create);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Barcode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
   
        private int merchCode3;
        private int serieCode5;
        private int numb4;
        private Button Create;
        private StiReport stiReport1;
        private TextBox txtFrom;
        private TextBox txtTo;
        private Label label1;
        private Label label2;
        private ComboBox cbShift;
        private ComboBox cbLabel;
        private Label label3;
        private Label label4;
        private PersianDateTimePicker persianDateTimePicker1;
        private Label label5;
        private TextBox txtMerch;
        private ComboBox DrCount;
        private Label label6;
        private TextBox test;
        private Button button2;
    }
}

