using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MathWorks.MATLAB.NET.Arrays;
using MathWorks;
using MathWorks.MATLAB;
using MathWorks.MATLAB.NET.Utility;

namespace WFA.UI
{
    public partial class UCthree : UserControl
    {
        public UCthree()
        {
            InitializeComponent();
            //Init();
        }

        public void Refresh()
        {
            Init();
        }
        public void Init()
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
            if (random.Next(100) % 2 == 0)
            {
                tc1.threeDtest();
            }
            else
            {
                tc1.threeDtest((MWNumericArray)x.ToArray(), (MWNumericArray)y.ToArray(), (MWNumericArray)z1.ToArray());
            }
            #region 寻找窗体
            System.IntPtr wf = new System.IntPtr();
            int num = 0;
            while (num < 5)
            {
                num++;
                //若找不到窗体,循环5次，每次100ms
                if (wf == IntPtr.Zero)
                {
                    wf = user32App.FindWindow("SunAwtFrame", null);
                    System.Threading.Thread.Sleep(new TimeSpan(100));
                    wf = (System.IntPtr)1;
                }
                else
                {   //找到隐藏起来
                    //user32App.SendMessage(wf, 0xA1, 0x02, 0);
                    user32App.ShowWindow(wf, user32App._SW.SW_HIDE); break;
                }
            }
            if (wf == IntPtr.Zero)
            {
                MessageBox.Show("无法获取Figure窗体,请确认信息是否正确");
                return;
            }
            else
            {
                user32App.SetParent(wf, this.Handle);
                user32App.ShowWindow(wf, user32App._SW.SW_MAXIMIZE);
            }
            #endregion

        }
    }
}
