namespace OutputServerLogs
{
    partial class FormAddPreset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPreset));
            this.rbPrefixName = new System.Windows.Forms.RadioButton();
            this.rbSubDirs = new System.Windows.Forms.RadioButton();
            this.tbPresetName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbToDir = new System.Windows.Forms.TextBox();
            this.tbFromDir = new System.Windows.Forms.TextBox();
            this.btAddFromDir = new System.Windows.Forms.Button();
            this.btnAddToDir = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // rbPrefixName
            // 
            this.rbPrefixName.AutoSize = true;
            this.rbPrefixName.Location = new System.Drawing.Point(497, 12);
            this.rbPrefixName.Name = "rbPrefixName";
            this.rbPrefixName.Size = new System.Drawing.Size(98, 17);
            this.rbPrefixName.TabIndex = 14;
            this.rbPrefixName.Text = "just prefix name";
            this.rbPrefixName.UseVisualStyleBackColor = true;
            // 
            // rbSubDirs
            // 
            this.rbSubDirs.AutoSize = true;
            this.rbSubDirs.Checked = true;
            this.rbSubDirs.Location = new System.Drawing.Point(399, 12);
            this.rbSubDirs.Name = "rbSubDirs";
            this.rbSubDirs.Size = new System.Drawing.Size(90, 17);
            this.rbSubDirs.TabIndex = 15;
            this.rbSubDirs.TabStop = true;
            this.rbSubDirs.Text = "make sub dirs";
            this.rbSubDirs.UseVisualStyleBackColor = true;
            // 
            // tbPresetName
            // 
            this.tbPresetName.Location = new System.Drawing.Point(90, 12);
            this.tbPresetName.Name = "tbPresetName";
            this.tbPresetName.Size = new System.Drawing.Size(303, 20);
            this.tbPresetName.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Preset Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "To Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "From Directory";
            // 
            // tbToDir
            // 
            this.tbToDir.Location = new System.Drawing.Point(90, 77);
            this.tbToDir.Name = "tbToDir";
            this.tbToDir.Size = new System.Drawing.Size(451, 20);
            this.tbToDir.TabIndex = 20;
            // 
            // tbFromDir
            // 
            this.tbFromDir.Location = new System.Drawing.Point(90, 45);
            this.tbFromDir.Name = "tbFromDir";
            this.tbFromDir.Size = new System.Drawing.Size(451, 20);
            this.tbFromDir.TabIndex = 21;
            // 
            // btAddFromDir
            // 
            this.btAddFromDir.Location = new System.Drawing.Point(548, 43);
            this.btAddFromDir.Name = "btAddFromDir";
            this.btAddFromDir.Size = new System.Drawing.Size(48, 23);
            this.btAddFromDir.TabIndex = 22;
            this.btAddFromDir.Text = "...";
            this.btAddFromDir.UseVisualStyleBackColor = true;
            this.btAddFromDir.Click += new System.EventHandler(this.btAddFromDir_Click);
            // 
            // btnAddToDir
            // 
            this.btnAddToDir.Location = new System.Drawing.Point(548, 75);
            this.btnAddToDir.Name = "btnAddToDir";
            this.btnAddToDir.Size = new System.Drawing.Size(48, 23);
            this.btnAddToDir.TabIndex = 22;
            this.btnAddToDir.Text = "...";
            this.btnAddToDir.UseVisualStyleBackColor = true;
            this.btnAddToDir.Click += new System.EventHandler(this.btnAddToDir_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(520, 110);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(428, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddPreset
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(608, 145);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAddToDir);
            this.Controls.Add(this.btAddFromDir);
            this.Controls.Add(this.tbToDir);
            this.Controls.Add(this.tbFromDir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPresetName);
            this.Controls.Add(this.rbPrefixName);
            this.Controls.Add(this.rbSubDirs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddPreset";
            this.Text = "FormAddPreset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPrefixName;
        private System.Windows.Forms.RadioButton rbSubDirs;
        private System.Windows.Forms.TextBox tbPresetName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbToDir;
        private System.Windows.Forms.TextBox tbFromDir;
        private System.Windows.Forms.Button btAddFromDir;
        private System.Windows.Forms.Button btnAddToDir;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}