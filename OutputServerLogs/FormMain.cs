﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
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


            // setting up columns in dtDataGrid
            DataColumn sourceDir = new DataColumn("sourceDir", typeof(string));
            DataColumn destDir = new DataColumn("destDir", typeof(string));
            dtDataGrid.Columns.Add(sourceDir);
            dtDataGrid.Columns.Add(destDir);

            // setting binding and columns in datagrid
            SBind.DataSource = dtDataGrid;
            dataGridView1.DataSource = SBind;

            // Add a button column. 
            DataGridViewButtonColumn buttonColumn =
                new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Command";
            buttonColumn.Name = "Command";
            buttonColumn.Text = "Get Files";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);

            // making the middle column fill space
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
                string[] strPresets = new string[2] { "AsRun", "Trace" };
                string[] strFromDir = new string[2] { "E:\\AsRun", "E:\\itxlogs" };
                string[] strToDir = new string[2] { "E:\\AsRunLogs", "E:\\TraceLogs" };
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

            string version = Application.ProductVersion;
            this.Text = String.Format("Collect Multi-Directory iTX Logs vrs {0}", version);
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
            // redraw the grid
            newDataGrid();

        }

        private void newDataGrid()
        {
            dtDataGrid.Clear();
            int iIndex = cbxPreset.SelectedIndex;
            string strScanDir = dtComboBox.Rows[iIndex][1].ToString();
            if (Directory.Exists(strScanDir))
            {
                // fill in datagrid with sub directory names
                writeLog("Scanning " + strScanDir + " directory for sub directories.");
                foreach (string sDir in GetSubdirectoriesContainingOnlyFiles(strScanDir))
                {
                    DataRow DGRow = dtDataGrid.NewRow();
                    DGRow["sourceDir"] = sDir;
                    // in dtComboBox 0 is preset name 1 is fromDir and 2 is toDir

                    //Compute sub directory if needed
                    if (rbSubDirs.Checked)
                    {
                        int i = sDir.LastIndexOf("\\");
                        DGRow["destDir"] = dtComboBox.Rows[cbxPreset.SelectedIndex][2] + sDir.Substring(i, sDir.Length - i);
                    }
                    else
                    {
                        DGRow["destDir"] = dtComboBox.Rows[cbxPreset.SelectedIndex][2];
                    }
                    dtDataGrid.Rows.Add(DGRow);
                }
                dataGridView1.AutoResizeColumns();
            } else
            {
                writeLog("Didn't find a directory named: " + strScanDir + " to get sub directories.", "Red");
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
            // if you use ForeColor it changes whole thing
            if (strStyle == "Red") { richTextBox1.SelectionColor = Color.Red; }
            else if (strStyle == "Green") { richTextBox1.SelectionColor = Color.Green; }
            else { richTextBox1.SelectionColor = Color.Black; }
            //strIn += DateTime.Now.ToString() + strIn ;
            richTextBox1.AppendText(DateTime.Now.ToString() + " " + strIn + "\r\n");
            richTextBox1.ScrollToCaret();
        }

        static IEnumerable<string> GetSubdirectoriesContainingOnlyFiles(string path)
        {
            return from subdirectory in Directory.GetDirectories(path, "*", SearchOption.AllDirectories)
                   where Directory.GetDirectories(subdirectory).Length == 0
                   select subdirectory;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Command")
            {
                int irow = e.RowIndex;
                int icol = e.ColumnIndex;
                writeLog("Button Column Clicked in row "+ irow.ToString(), "Red");
                copyDeFiles(irow);
            }
        }
        // this function takes in row of table and looks for all the file types that matches then copies them to dest folder 
        private void copyDeFiles(int irow)
        {
            writeLog("Dest Directory: " + dtDataGrid.Rows[irow][1].ToString(), "Green");
            int i = 0;
            DateTime dtmWorking = dateTimePicker1.Value;
            string strWorkingSource = dtDataGrid.Rows[irow][0].ToString();
            string strWorkingDest = dtDataGrid.Rows[irow][1].ToString();
            do
            {
                if (File.Exists(strWorkingSource + "\\" + dtmWorking.ToString("yyyyMMdd") + ".CSV"))
                {
                    // create directory if doesn't exist
                    System.IO.Directory.CreateDirectory(strWorkingDest);
                    // if sub directories copy file with no name change
                    if (rbSubDirs.Checked) File.Copy(strWorkingSource + "\\" + dtmWorking.ToString("yyyyMMdd") + ".CSV",
                         strWorkingDest + "\\" +dtmWorking.ToString("yyyyMMdd") + ".CSV", true);
                    else
                    {
                        int iIndex = strWorkingSource.LastIndexOf("\\");
                        File.Copy(strWorkingSource + "\\" + dtmWorking.ToString("yyyyMMdd") + ".CSV",
                        strWorkingDest + strWorkingSource.Substring(iIndex, strWorkingSource.Length - iIndex) + "_" + dtmWorking.ToString("yyyyMMdd") + ".CSV",
                        true);
                    }
                    writeLog("Copying " + strWorkingSource + "\\" + dtmWorking.ToString("yyyyMMdd") + ".CSV", "Green");
                }
                if (File.Exists(strWorkingSource + "\\DAY_" + dtmWorking.ToString("dd") + ".txt"))
                {
                    // create directory if doesn't exist
                    System.IO.Directory.CreateDirectory(strWorkingDest);
                    // if sub directories copy file with no name change
                    if (rbSubDirs.Checked) File.Copy(strWorkingSource + "\\DAY_" + dtmWorking.ToString("dd") + ".txt",
                         strWorkingDest + "\\DAY_" + dtmWorking.ToString("dd") + ".txt", true);
                    else
                    {
                        int iIndex = strWorkingSource.LastIndexOf("\\");
                        File.Copy(strWorkingSource + "\\DAY_" + dtmWorking.ToString("dd") + ".txt",
                        strWorkingDest + strWorkingSource.Substring(iIndex, strWorkingSource.Length - iIndex) + "_DAY_" + dtmWorking.ToString("dd") + ".txt",
                        true);
                    }
                    writeLog("Copying "+ strWorkingSource + "\\DAY_" + dtmWorking.ToString("dd") + ".txt","Green");
                }
                //writeLog(dtmWorking.ToString("yyyyMMdd")+" "+i.ToString(), "Red");
                // add a day for next loop
                dtmWorking = dtmWorking.AddDays(1);
            } while (i++ < numericUpDown1.Value);
            

        }

        private void btnZipTo_Click(object sender, EventArgs e)
        {
            writeLog("Zipping " + tbToDir.Text + " to " + tbToDir.Text + ".zip", "Green");
            File.Delete(tbToDir.Text + ".zip");

            CompressDirectory(tbToDir.Text, tbToDir.Text + ".zip");
        }
        static void CompressDirectory(string sInDir, string sOutFile)
        {
            string[] sFiles = Directory.GetFiles(sInDir, "*.*", SearchOption.AllDirectories);
            int iDirLen = sInDir[sInDir.Length - 1] == Path.DirectorySeparatorChar ? sInDir.Length : sInDir.Length + 1;

            using (FileStream outFile = new FileStream(sOutFile, FileMode.Create, FileAccess.Write, FileShare.None))
            using (GZipStream str = new GZipStream(outFile, CompressionMode.Compress))
                foreach (string sFilePath in sFiles)
                {
                    string sRelativePath = sFilePath.Substring(iDirLen);
                    CompressFile(sInDir, sRelativePath, str);
                }
        }

        static void CompressFile(string sDir, string sRelativePath, GZipStream zipStream)
        {
            //Compress file name
            char[] chars = sRelativePath.ToCharArray();
            zipStream.Write(BitConverter.GetBytes(chars.Length), 0, sizeof(int));
            foreach (char c in chars)
                zipStream.Write(BitConverter.GetBytes(c), 0, sizeof(char));

            //Compress file content
            byte[] bytes = File.ReadAllBytes(Path.Combine(sDir, sRelativePath));
            zipStream.Write(BitConverter.GetBytes(bytes.Length), 0, sizeof(int));
            zipStream.Write(bytes, 0, bytes.Length);
        }
    }
}
