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
        // --- Variables
        string[] strPresets = new string[2] { "Framework", "output" };

        DataSet myDataSet = new DataSet();

        // --- Preparation
        DataTable lTable = new DataTable("Full");
        DataColumn lName = new DataColumn("Preset", typeof(string));
        




        public FormMain()
        {
            InitializeComponent();
            // converting default presets to rows
            lTable.Columns.Add(lName);
            for (int i = 0; i < strPresets.Length; i++)
            {
                DataRow lLang = lTable.NewRow();
                lLang["Preset"] = strPresets[i];
                lTable.Rows.Add(lLang);
            }
            myDataSet.Tables.Add(lTable);
            // --- Handling the combobox
            cbxPreset.DataSource = myDataSet.Tables["Full"].DefaultView;
            cbxPreset.DisplayMember = "Preset";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddPreset myFormAdd = new FormAddPreset();
            DialogResult result = myFormAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                // add code to set data source
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
