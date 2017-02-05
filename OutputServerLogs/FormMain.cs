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
    public partial class FormMain : Form
    {
        // Dataset for the comboBox
        //DataSet myDataSet = new DataSet();
        // Table used for construction
        DataTable dtComboBox = new DataTable("ComboBox");

        public FormMain()
        {
            InitializeComponent();
            // Set up the columns
            DataColumn lName = new DataColumn("Preset", typeof(string));
            DataColumn fromDir = new DataColumn("fromDir", typeof(string));
            DataColumn toDir = new DataColumn("toDir", typeof(string));
            DataColumn SubDir = new DataColumn("subDir", typeof(bool));
            // converting default presets to rows
            dtComboBox.Columns.Add(lName);
            dtComboBox.Columns.Add(fromDir);
            dtComboBox.Columns.Add(toDir);
            dtComboBox.Columns.Add(SubDir);
            // see if there is xml file in current directory
            string strTemp = System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString() + "\\presets.xml";
            if (File.Exists(strTemp))
            {
                dtComboBox.ReadXml(strTemp);
            } // end load default presets
            else
            {
                // Load Default Preset Values
                string[] strPresets = new string[2] { "Framework", "output" };
                string[] strFromDir = new string[2] { "%appdata%\\itx", "c:\\itxLogs" };
                string[] strToDir = new string[2] { "c:\\CollectLogs", "c:\\CollectLogs" };
                bool[] blSubDir = new bool[2] { true, true };
                for (int i = 0; i < strPresets.Length; i++)
                {
                    DataRow lRow = dtComboBox.NewRow();
                    lRow["Preset"] = strPresets[i];
                    lRow["fromDir"] = strFromDir[i];
                    lRow["toDir"] = strToDir[i];
                    lRow["subDir"] = blSubDir[i];
                    dtComboBox.Rows.Add(lRow);
                }
            } // end of else create new base presets
            //myDataSet.Tables.Add(dtComboBox);
            // --- Handling the combobox
            cbxPreset.DataSource = dtComboBox.DefaultView;
            cbxPreset.DisplayMember = "Preset";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddPreset myFormAdd = new FormAddPreset();
            DialogResult result = myFormAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                DataRow lRow = dtComboBox.NewRow();
                lRow["Preset"] = myFormAdd.strPreset;
                lRow["fromDir"] = myFormAdd.strFromDir;
                lRow["toDir"] = myFormAdd.strToDir;
                lRow["subDir"] = myFormAdd.blSubDir;
                dtComboBox.Rows.Add(lRow);
                // this becomes new last row, but it isn't selected
                cbxPreset.SelectedIndex = cbxPreset.Items.Count - 1;
            }
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
           // if (Settings.Default.cboCollection != null)
            //    this.cbFromDir.Items.AddRange(Properties.Settings.Default.cboCollectionFrom);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtComboBox.WriteXml(System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString() + "\\presets.xml", true);
        }

        private void cbxPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            tbFromDir.Text = dtComboBox.Rows[comboBox.SelectedIndex]["fromDir"].ToString();
            tbToDir.Text = dtComboBox.Rows[comboBox.SelectedIndex]["toDir"].ToString();
            if((bool)dtComboBox.Rows[comboBox.SelectedIndex]["subDir"])
            {
                // to lazy to subclass value
                rbSubDirs.Checked = true;
                rbPrefixName.Checked = false;
            } else
            {
                rbSubDirs.Checked = false;
                rbPrefixName.Checked = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cbxPreset.Items.Count < 2)
            {
                MessageBox.Show("You can't delete last preset, you must add one first");
            }
            else
            {
                dtComboBox.Rows[cbxPreset.SelectedIndex].Delete();
            }
        }
    }
}
