using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutputServerLogs
{
    public partial class FormAddPreset : Form
    {
        public FormAddPreset()
        {
            InitializeComponent();
        }
        public string strPreset { get; set; }
        public string strFromDir { get; set; }
        public string strToDir { get; set; }
        public bool blSubDir { get; set; }

        private void btAddFromDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbFromDir.Text = folderBrowserDialog1.SelectedPath.ToString();
                if (tbPresetName.Text.Length < 1)
                {
                    // Split on directory separator.
                    string[] parts = folderBrowserDialog1.SelectedPath.ToString().Split('\\');
                    if(parts.Count()>1)
                    tbPresetName.Text = parts[0] +"-" + parts[1];
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            strPreset = tbPresetName.Text;
            strFromDir = tbFromDir.Text;
            strToDir = tbToDir.Text;
            blSubDir = rbSubDirs.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddToDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbToDir.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }
    }
}
