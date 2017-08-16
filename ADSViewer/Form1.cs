using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADSViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GObtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(urlTB.Text);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string cadenafinal = "";
            for (int x = 1; x < 5; x++)
            {

                HtmlElement div = webBrowser1.Document.GetElementById("cimg" + Convert.ToString(x));
                HtmlElementCollection imagen = div.GetElementsByTagName("img");
                cadenafinal += imagen[0].GetAttribute("src")[35];
            }
            webBrowser1.Document.GetElementsByTagName("input")[0].SetAttribute("value", cadenafinal);
            webBrowser1.Document.GetElementsByTagName("input")[1].InvokeMember("click");
        }

        private void STOPbtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
