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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 551);
            this.Controls.Add(this.btnToDir);
            this.Controls.Add(this.btnFromDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbToDirectory);
            this.Controls.Add(this.cbFromDir);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

