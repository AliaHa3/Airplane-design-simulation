namespace Physics_Project
{
    partial class BodyChangeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBodyX15 = new System.Windows.Forms.RadioButton();
            this.rdBodyCessna = new System.Windows.Forms.RadioButton();
            this.rdBodySpitfire = new System.Windows.Forms.RadioButton();
            this.rdBodyA10 = new System.Windows.Forms.RadioButton();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBodyX15);
            this.groupBox1.Controls.Add(this.rdBodyCessna);
            this.groupBox1.Controls.Add(this.rdBodySpitfire);
            this.groupBox1.Controls.Add(this.rdBodyA10);
            this.groupBox1.Location = new System.Drawing.Point(28, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Body type";
            // 
            // rdBodyX15
            // 
            this.rdBodyX15.AutoSize = true;
            this.rdBodyX15.Location = new System.Drawing.Point(132, 74);
            this.rdBodyX15.Name = "rdBodyX15";
            this.rdBodyX15.Size = new System.Drawing.Size(44, 17);
            this.rdBodyX15.TabIndex = 6;
            this.rdBodyX15.Text = "X15";
            this.rdBodyX15.UseVisualStyleBackColor = true;
            // 
            // rdBodyCessna
            // 
            this.rdBodyCessna.AutoSize = true;
            this.rdBodyCessna.Location = new System.Drawing.Point(24, 74);
            this.rdBodyCessna.Name = "rdBodyCessna";
            this.rdBodyCessna.Size = new System.Drawing.Size(60, 17);
            this.rdBodyCessna.TabIndex = 5;
            this.rdBodyCessna.Text = "Cessna";
            this.rdBodyCessna.UseVisualStyleBackColor = true;
            // 
            // rdBodySpitfire
            // 
            this.rdBodySpitfire.AutoSize = true;
            this.rdBodySpitfire.Location = new System.Drawing.Point(132, 31);
            this.rdBodySpitfire.Name = "rdBodySpitfire";
            this.rdBodySpitfire.Size = new System.Drawing.Size(57, 17);
            this.rdBodySpitfire.TabIndex = 2;
            this.rdBodySpitfire.Text = "Spitfire";
            this.rdBodySpitfire.UseVisualStyleBackColor = true;
            // 
            // rdBodyA10
            // 
            this.rdBodyA10.AutoSize = true;
            this.rdBodyA10.Checked = true;
            this.rdBodyA10.Location = new System.Drawing.Point(24, 31);
            this.rdBodyA10.Name = "rdBodyA10";
            this.rdBodyA10.Size = new System.Drawing.Size(44, 17);
            this.rdBodyA10.TabIndex = 4;
            this.rdBodyA10.TabStop = true;
            this.rdBodyA10.Text = "A10";
            this.rdBodyA10.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(45, 178);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(160, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BodyChangeForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BodyChangeForm";
            this.Text = "BodyChangeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBodyX15;
        private System.Windows.Forms.RadioButton rdBodyCessna;
        private System.Windows.Forms.RadioButton rdBodySpitfire;
        private System.Windows.Forms.RadioButton rdBodyA10;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
    }
}