using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutputServerLogs
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnFromDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                cbFromDir.Items.Add(folderBrowserDialog1.SelectedPath);
            }
        }

        private void btnToDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                cbToDirectory.Items.Add(folderBrowserDialog1.SelectedPath);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           // if (Settings.Default.cboCollection != null)
            //    this.cbFromDir.Items.AddRange(Properties.Settings.Default.cboCollectionFrom);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


    }
}
