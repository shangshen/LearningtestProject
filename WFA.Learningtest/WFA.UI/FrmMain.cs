using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Runtime;

using MathWorks.MATLAB.NET.Arrays;
using MathWorks;
using MathWorks.MATLAB;
using MathWorks.MATLAB.NET.Utility;

using System.Linq;

namespace WFA.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //pictureBox1.Image = Image.FromFile(@"D:\abc.png");
        }

        public void Init(string path)
        {
            List<double> x = new List<double>();
            List<double> y = new List<double>();
            List<double> z1 = new List<double>();
            List<double> z2 = new List<double>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                x.Add(random.Next(10));
                y.Add(random.Next(10));
            }
            for (int i = 0; i < x.Count; i++)
            {
                z1.Add(x[i] + y[i]);
            }
            threeTest.threeChart tc1 = new threeTest.threeChart();
            //if (System.IO.File.Exists(path))
            //{
            //    //如果存在则删除
            //    System.IO.File.Delete(path);
            //}
            if (random.Next(100) % 2 == 0)
            {
                tc1.threeDtest();
            }
            else
            {

                tc1.threeDtest((MWNumericArray)x.ToArray(), (MWNumericArray)y.ToArray(), (MWNumericArray)z1.ToArray(), path);
            }

        }


        private void button1_Click(object sender, System.EventArgs e)
        {
            //pictureBox1.Image.Dispose();
            //pictureBox1.Image = null;
            ////string path = Application.StartupPath + "123.png";
            //string path = @"D:\abc.png";
            //Init(path);
            //pictureBox1.Image = Image.FromFile(path);
        }

        private void btnEntryOrder_Click(object sender, System.EventArgs e)
        {
            List<Entrytest> listEntry = new List<Entrytest>();
            for (int i = 0; i < 3; i++)
            {
                Entrytest test = new Entrytest();
                test.Name = "test" + i.ToString();
                test.Old = i + 20;
                listEntry.Add(test);
            }

            var query = from r in listEntry
                        orderby r.Old descending
                        select r;

            listEntry = new List<Entrytest>();
            
            foreach (Entrytest t in query)
            {
                listEntry.Add(t);
            }
            dataGridView1.DataSource = listEntry;
        }
    }
}
