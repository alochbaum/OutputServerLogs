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
            this.cbToDirectory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFromDir = new System.Windows.Forms.Button();
            this.btnToDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnZipTo = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cbFromDir = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From Directory";
            // 
            // cbToDirectory
            // 
            this.cbToDirectory.FormattingEnabled = true;
            this.cbToDirectory.Location = new System.Drawing.Point(92, 27);
            this.cbToDirectory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbToDirectory.Name = "cbToDirectory";
            this.cbToDirectory.Size = new System.Drawing.Size(428, 21);
            this.cbToDirectory.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Directory";
            // 
            // btnFromDir
            // 
            this.btnFromDir.Location = new System.Drawing.Point(521, 6);
            this.btnFromDir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFromDir.Name = "btnFromDir";
            this.btnFromDir.Size = new System.Drawing.Size(22, 19);
            this.btnFromDir.TabIndex = 2;
            this.btnFromDir.Text = "...";
            this.btnFromDir.UseVisualStyleBackColor = true;
            this.btnFromDir.Click += new System.EventHandler(this.btnFromDir_Click);
            // 
            // btnToDir
            // 
            this.btnToDir.Location = new System.Drawing.Point(521, 28);
            this.btnToDir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToDir.Name = "btnToDir";
            this.btnToDir.Size = new System.Drawing.Size(22, 19);
            this.btnToDir.TabIndex = 2;
            this.btnToDir.Text = "...";
            this.btnToDir.UseVisualStyleBackColor = true;
            this.btnToDir.Click += new System.EventHandler(this.btnToDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Day";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 50);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "number of additional days";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(407, 54);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(526, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnZipTo
            // 
            this.btnZipTo.Location = new System.Drawing.Point(473, 52);
            this.btnZipTo.Name = "btnZipTo";
            this.btnZipTo.Size = new System.Drawing.Size(69, 23);
            this.btnZipTo.TabIndex = 8;
            this.btnZipTo.Text = "zip To dir";
            this.btnZipTo.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 235);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(525, 101);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // cbFromDir
            // 
            this.cbFromDir.FormattingEnabled = true;
            this.cbFromDir.Location = new System.Drawing.Point(92, 6);
            this.cbFromDir.Margin = new System.Windows.Forms.Padding(2);
            this.cbFromDir.Name = "cbFromDir";
            this.cbFromDir.Size = new System.Drawing.Size(428, 21);
            this.cbFromDir.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 348);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnZipTo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnToDir);
            this.Controls.Add(this.btnFromDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbToDirectory);
            this.Controls.Add(this.cbFromDir);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Collect Output Server Logs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbToDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFromDir;
        private System.Windows.Forms.Button btnToDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnZipTo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox cbFromDir;
    }
}

