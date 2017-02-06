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
        DataTable dtDataGrid = new DataTable("DataGrid");
        BindingSource SBind = new BindingSource();
        string strFromDir = "";

        public FormMain()
        {
            InitializeComponent();
            // Set up the columns dtComboBox
            DataColumn lName = new DataColumn("Preset", typeof(string));
            DataColumn fromDir = new DataColumn("fromDir", typeof(string));
            DataColumn toDir = new DataColumn("toDir", typeof(string));
            DataColumn SubDir = new DataColumn("subDir", typeof(bool));
            // adding columns in dtComboBox
            dtComboBox.Columns.Add(lName);
            dtComboBox.Columns.Add(fromDir);
            dtComboBox.Columns.Add(toDir);
            dtComboBox.Columns.Add(SubDir);

            //// Add a button column. 
            //DataGridViewButtonColumn buttonColumn =
            //    new DataGridViewButtonColumn();
            //buttonColumn.HeaderText = "Command";
            //buttonColumn.Name = "Command";
            //buttonColumn.Text = "Get Files";
            //buttonColumn.UseColumnTextForButtonValue = true;
            // setting up columns in dtDataGrid
            DataColumn sourceDir = new DataColumn("sourceDir", typeof(string));
            DataColumn destDir = new DataColumn("destDir", typeof(string));
            dtDataGrid.Columns.Add(sourceDir);
            dtDataGrid.Columns.Add(destDir);
            // setting binding and columns in datagrid
            SBind.DataSource = dtDataGrid;
            dataGridView1.DataSource = SBind;

            // see if there is xml file in current directory for dtComboBox
            string strTemp = System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString() + "\\presets.xml";
            if (File.Exists(strTemp))
            {
                dtComboBox.ReadXml(strTemp);
                writeLog("Read Presets: " + strTemp);
            } // end load default presets
            else
            {
                writeLog("Didn't Find: " + strTemp,"Red");
                writeLog("Loading Default Presets","Green");
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
                writeLog("Added Preset: " +myFormAdd.strPreset);
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
            writeLog("Changing to Preset: " + dtComboBox.Rows[comboBox.SelectedIndex]["Preset"]);
            tbFromDir.Text = dtComboBox.Rows[comboBox.SelectedIndex]["fromDir"].ToString();
            tbToDir.Text = dtComboBox.Rows[comboBox.SelectedIndex]["toDir"].ToString();
            if((bool)dtComboBox.Rows[comboBox.SelectedIndex]["subDir"])
            {
                // too lazy to subclass value of Radio Button, there are just 2 of them
                rbSubDirs.Checked = true;
                rbPrefixName.Checked = false;
            } else
            {
                rbSubDirs.Checked = false;
                rbPrefixName.Checked = true;
            }
            if(strFromDir != tbFromDir.Text)
            {
                strFromDir = tbFromDir.Text;
                newDataGrid();
            }
        }

        private void newDataGrid()
        {
            dtDataGrid.Clear();
            // Load Default Preset Values
            string[] strSDir = new string[2] { "Straight to the source", "Source1" };
            string[] strDDir = new string[2] { "testing123", "123testing" };
            for (int i = 0; i < strSDir.Length; i++)
            {
                DataRow DGRow = dtDataGrid.NewRow();
                DGRow["sourceDir"] = strSDir[i];
                DGRow["destDir"] = strDDir[i];;
                dtDataGrid.Rows.Add(DGRow);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cbxPreset.Items.Count < 2)
            {
                writeLog("You can't delete last preset, you must add one first","Red");
            }
            else
            {
                writeLog("Deleting Preset: " + dtComboBox.Rows[cbxPreset.SelectedIndex].ToString(), "Green");
                dtComboBox.Rows[cbxPreset.SelectedIndex].Delete();

            }
        }
        private void writeLog(string strIn,string strStyle = "Black")
        {
            if (strStyle == "Red") { richTextBox1.ForeColor = Color.Red; }
            else if (strStyle == "Green") { richTextBox1.ForeColor = Color.Green; }
            else { richTextBox1.ForeColor = Color.Black; }
            //strIn += DateTime.Now.ToString() + strIn ;
            richTextBox1.AppendText(DateTime.Now.ToString() + " " + strIn + "\r\n");
            richTextBox1.ScrollToCaret();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
