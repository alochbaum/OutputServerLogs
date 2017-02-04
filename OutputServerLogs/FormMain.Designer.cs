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
            this.cbFromDir = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFromDir
            // 
            this.cbFromDir.FormattingEnabled = true;
            this.cbFromDir.Location = new System.Drawing.Point(184, 12);
            this.cbFromDir.Name = "cbFromDir";
            this.cbFromDir.Size = new System.Drawing.Size(852, 33);
            this.cbFromDir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "From Directory";
            // 
            // cbToDirectory
            // 
            this.cbToDirectory.FormattingEnabled = true;
            this.cbToDirectory.Location = new System.Drawing.Point(184, 51);
            this.cbToDirectory.Name = "cbToDirectory";
            this.cbToDirectory.Size = new System.Drawing.Size(852, 33);
            this.cbToDirectory.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Directory";
            // 
            // btnFromDir
            // 
            this.btnFromDir.Location = new System.Drawing.Point(1042, 12);
            this.btnFromDir.Name = "btnFromDir";
            this.btnFromDir.Size = new System.Drawing.Size(45, 36);
            this.btnFromDir.TabIndex = 2;
            this.btnFromDir.Text = "...";
            this.btnFromDir.UseVisualStyleBackColor = true;
            // 
            // btnToDir
            // 
            this.btnToDir.Location = new System.Drawing.Point(1042, 54);
            this.btnToDir.Name = "btnToDir";
            this.btnToDir.Size = new System.Drawing.Size(45, 36);
            this.btnToDir.TabIndex = 2;
            this.btnToDir.Text = "...";
            this.btnToDir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Day";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(398, 31);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "number of additional days";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(885, 103);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 365);
            this.dataGridView1.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 551);
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
            this.Name = "FormMain";
            this.Text = "Collect Output Server Logs";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFromDir;
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
    }
}

