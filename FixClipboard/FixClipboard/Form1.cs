using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixClipboard
{
    public partial class Fix : Form
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();



        public Fix()
        {
            InitializeComponent();
            string strTemp = Clipboard.GetText();
            //strTemp = strTemp.Replace("\t", "");
            strTemp = strTemp.Trim();
            Clipboard.SetText(strTemp);
            t.Interval = 100; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();

        }
        void timer_Tick(object sender, EventArgs e)
        {
            t.Stop();
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Exit code 0 means it quit fine
            System.Environment.Exit(0);
        }
    }
}
