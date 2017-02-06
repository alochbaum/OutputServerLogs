namespace OutputServerLogs
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFromDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnZipTo = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbxPreset = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFromDir = new System.Windows.Forms.TextBox();
            this.rbSubDirs = new System.Windows.Forms.RadioButton();
            this.rbPrefixName = new System.Windows.Forms.RadioButton();
            this.tbToDir = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Directory";
            // 
            // btnFromDir
            // 
            this.btnFromDir.Location = new System.Drawing.Point(274, 6);
            this.btnFromDir.Margin = new System.Windows.Forms.Padding(2);
            this.btnFromDir.Name = "btnFromDir";
            this.btnFromDir.Size = new System.Drawing.Size(76, 19);
            this.btnFromDir.TabIndex = 2;
            this.btnFromDir.Text = "Add a Preset";
            this.btnFromDir.UseVisualStyleBackColor = true;
            this.btnFromDir.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Day";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 82);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "number of additional days";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(402, 82);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(674, 179);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnZipTo
            // 
            this.btnZipTo.Location = new System.Drawing.Point(479, 81);
            this.btnZipTo.Name = "btnZipTo";
            this.btnZipTo.Size = new System.Drawing.Size(206, 23);
            this.btnZipTo.TabIndex = 8;
            this.btnZipTo.Text = "Zip then save the root \"to\" directory";
            this.btnZipTo.UseVisualStyleBackColor = true;
            this.btnZipTo.Click += new System.EventHandler(this.btnZipTo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 294);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(674, 101);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // cbxPreset
            // 
            this.cbxPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPreset.FormattingEnabled = true;
            this.cbxPreset.Location = new System.Drawing.Point(92, 6);
            this.cbxPreset.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPreset.Name = "cbxPreset";
            this.cbxPreset.Size = new System.Drawing.Size(174, 21);
            this.cbxPreset.TabIndex = 0;
            this.cbxPreset.SelectedIndexChanged += new System.EventHandler(this.cbxPreset_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Preset";
            // 
            // tbFromDir
            // 
            this.tbFromDir.Location = new System.Drawing.Point(92, 32);
            this.tbFromDir.Name = "tbFromDir";
            this.tbFromDir.Size = new System.Drawing.Size(593, 20);
            this.tbFromDir.TabIndex = 12;
            // 
            // rbSubDirs
            // 
            this.rbSubDirs.AutoSize = true;
            this.rbSubDirs.Checked = true;
            this.rbSubDirs.Enabled = false;
            this.rbSubDirs.Location = new System.Drawing.Point(491, 5);
            this.rbSubDirs.Name = "rbSubDirs";
            this.rbSubDirs.Size = new System.Drawing.Size(90, 17);
            this.rbSubDirs.TabIndex = 13;
            this.rbSubDirs.TabStop = true;
            this.rbSubDirs.Text = "make sub dirs";
            this.rbSubDirs.UseVisualStyleBackColor = true;
            // 
            // rbPrefixName
            // 
            this.rbPrefixName.AutoSize = true;
            this.rbPrefixName.Enabled = false;
            this.rbPrefixName.Location = new System.Drawing.Point(587, 5);
            this.rbPrefixName.Name = "rbPrefixName";
            this.rbPrefixName.Size = new System.Drawing.Size(98, 17);
            this.rbPrefixName.TabIndex = 13;
            this.rbPrefixName.Text = "just prefix name";
            this.rbPrefixName.UseVisualStyleBackColor = true;
            // 
            // tbToDir
            // 
            this.tbToDir.Location = new System.Drawing.Point(92, 57);
            this.tbToDir.Name = "tbToDir";
            this.tbToDir.Size = new System.Drawing.Size(593, 20);
            this.tbToDir.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(355, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 19);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Selected Preset";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 407);
            this.Controls.Add(this.rbPrefixName);
            this.Controls.Add(this.rbSubDirs);
            this.Controls.Add(this.tbToDir);
            this.Controls.Add(this.tbFromDir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnZipTo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFromDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPreset);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Collect Multi-Directory iTX Logs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFromDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnZipTo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cbxPreset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFromDir;
        private System.Windows.Forms.RadioButton rbSubDirs;
        private System.Windows.Forms.RadioButton rbPrefixName;
        private System.Windows.Forms.TextBox tbToDir;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

