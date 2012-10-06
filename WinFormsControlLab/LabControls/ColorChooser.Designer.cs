namespace LabControls
{
    partial class ColorChooser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbRed = new System.Windows.Forms.Label();
            this.lbGreen = new System.Windows.Forms.Label();
            this.lbBlue = new System.Windows.Forms.Label();
            this.rBtnDec = new System.Windows.Forms.RadioButton();
            this.rBtnHex = new System.Windows.Forms.RadioButton();
            this.lbOutputColor = new System.Windows.Forms.Label();
            this.nmBoxBlue = new LabControls.NumberBox(this.components);
            this.nmBoxGreen = new LabControls.NumberBox(this.components);
            this.nmBoxRed = new LabControls.NumberBox(this.components);
            this.SuspendLayout();
            // 
            // lbRed
            // 
            this.lbRed.AutoSize = true;
            this.lbRed.Location = new System.Drawing.Point(17, 12);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(30, 13);
            this.lbRed.TabIndex = 0;
            this.lbRed.Text = "Red:";
            // 
            // lbGreen
            // 
            this.lbGreen.AutoSize = true;
            this.lbGreen.Location = new System.Drawing.Point(8, 38);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(39, 13);
            this.lbGreen.TabIndex = 1;
            this.lbGreen.Text = "Green:";
            // 
            // lbBlue
            // 
            this.lbBlue.AutoSize = true;
            this.lbBlue.Location = new System.Drawing.Point(16, 64);
            this.lbBlue.Name = "lbBlue";
            this.lbBlue.Size = new System.Drawing.Size(31, 13);
            this.lbBlue.TabIndex = 2;
            this.lbBlue.Text = "Blue:";
            // 
            // rBtnDec
            // 
            this.rBtnDec.AutoSize = true;
            this.rBtnDec.Checked = true;
            this.rBtnDec.Location = new System.Drawing.Point(11, 87);
            this.rBtnDec.Name = "rBtnDec";
            this.rBtnDec.Size = new System.Drawing.Size(45, 17);
            this.rBtnDec.TabIndex = 6;
            this.rBtnDec.TabStop = true;
            this.rBtnDec.Text = "Dec";
            this.rBtnDec.UseVisualStyleBackColor = true;
            this.rBtnDec.CheckedChanged += new System.EventHandler(this.rBtnDec_CheckedChanged);
            // 
            // rBtnHex
            // 
            this.rBtnHex.AutoSize = true;
            this.rBtnHex.Location = new System.Drawing.Point(62, 87);
            this.rBtnHex.Name = "rBtnHex";
            this.rBtnHex.Size = new System.Drawing.Size(44, 17);
            this.rBtnHex.TabIndex = 7;
            this.rBtnHex.Text = "Hex";
            this.rBtnHex.UseVisualStyleBackColor = true;
            // 
            // lbOutputColor
            // 
            this.lbOutputColor.BackColor = System.Drawing.Color.Black;
            this.lbOutputColor.ForeColor = System.Drawing.Color.Black;
            this.lbOutputColor.Location = new System.Drawing.Point(112, 9);
            this.lbOutputColor.Name = "lbOutputColor";
            this.lbOutputColor.Size = new System.Drawing.Size(95, 95);
            this.lbOutputColor.TabIndex = 8;
            // 
            // nmBoxBlue
            // 
            this.nmBoxBlue.Location = new System.Drawing.Point(53, 61);
            this.nmBoxBlue.Name = "nmBoxBlue";
            this.nmBoxBlue.CurrentNotation = LabControls.Notation.Decimal;
            this.nmBoxBlue.Size = new System.Drawing.Size(53, 20);
            this.nmBoxBlue.TabIndex = 5;
            this.nmBoxBlue.Text = "0";
            // 
            // nmBoxGreen
            // 
            this.nmBoxGreen.Location = new System.Drawing.Point(53, 35);
            this.nmBoxGreen.Name = "nmBoxGreen";
            this.nmBoxGreen.CurrentNotation = LabControls.Notation.Decimal;
            this.nmBoxGreen.Size = new System.Drawing.Size(53, 20);
            this.nmBoxGreen.TabIndex = 4;
            this.nmBoxGreen.Text = "0";
            // 
            // nmBoxRed
            // 
            this.nmBoxRed.Location = new System.Drawing.Point(53, 9);
            this.nmBoxRed.Name = "nmBoxRed";
            this.nmBoxRed.CurrentNotation = LabControls.Notation.Decimal;
            this.nmBoxRed.Size = new System.Drawing.Size(53, 20);
            this.nmBoxRed.TabIndex = 3;
            this.nmBoxRed.Text = "0";
            // 
            // ColorChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbOutputColor);
            this.Controls.Add(this.rBtnHex);
            this.Controls.Add(this.rBtnDec);
            this.Controls.Add(this.nmBoxBlue);
            this.Controls.Add(this.nmBoxGreen);
            this.Controls.Add(this.nmBoxRed);
            this.Controls.Add(this.lbBlue);
            this.Controls.Add(this.lbGreen);
            this.Controls.Add(this.lbRed);
            this.Name = "ColorChooser";
            this.Size = new System.Drawing.Size(216, 114);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.Label lbGreen;
        private System.Windows.Forms.Label lbBlue;
        private NumberBox nmBoxRed;
        private NumberBox nmBoxGreen;
        private NumberBox nmBoxBlue;
        private System.Windows.Forms.RadioButton rBtnDec;
        private System.Windows.Forms.RadioButton rBtnHex;
        private System.Windows.Forms.Label lbOutputColor;
    }
}
