namespace Serial_Maker
{
    partial class frmMain
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            this.stbBase = new System.Windows.Forms.TextBox();
            this.stbPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(203, 86);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(102, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Indetifier:";
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.Location = new System.Drawing.Point(68, 6);
            this.txtIdentifier.MaxLength = 3;
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(27, 20);
            this.txtIdentifier.TabIndex = 4;
            this.txtIdentifier.Text = "591";
            // 
            // stbBase
            // 
            this.stbBase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.stbBase.Location = new System.Drawing.Point(12, 33);
            this.stbBase.Name = "stbBase";
            this.stbBase.Size = new System.Drawing.Size(293, 20);
            this.stbBase.TabIndex = 5;
            // 
            // stbPass
            // 
            this.stbPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.stbPass.Location = new System.Drawing.Point(12, 59);
            this.stbPass.Name = "stbPass";
            this.stbPass.ReadOnly = true;
            this.stbPass.Size = new System.Drawing.Size(293, 20);
            this.stbPass.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 121);
            this.Controls.Add(this.stbPass);
            this.Controls.Add(this.stbBase);
            this.Controls.Add(this.txtIdentifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.TextBox stbBase;
        private System.Windows.Forms.TextBox stbPass;
    }
}

