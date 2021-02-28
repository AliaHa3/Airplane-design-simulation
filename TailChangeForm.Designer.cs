namespace Physics_Project
{
    partial class TailChangeForm
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
            this.rdTailX15 = new System.Windows.Forms.RadioButton();
            this.rdTailCessna = new System.Windows.Forms.RadioButton();
            this.rdTailSpitefire = new System.Windows.Forms.RadioButton();
            this.rdTailA10 = new System.Windows.Forms.RadioButton();
            this.rdTailBleriot = new System.Windows.Forms.RadioButton();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTailX15);
            this.groupBox1.Controls.Add(this.rdTailCessna);
            this.groupBox1.Controls.Add(this.rdTailSpitefire);
            this.groupBox1.Controls.Add(this.rdTailA10);
            this.groupBox1.Controls.Add(this.rdTailBleriot);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tail type";
            // 
            // rdTailX15
            // 
            this.rdTailX15.AutoSize = true;
            this.rdTailX15.Location = new System.Drawing.Point(24, 69);
            this.rdTailX15.Name = "rdTailX15";
            this.rdTailX15.Size = new System.Drawing.Size(44, 17);
            this.rdTailX15.TabIndex = 6;
            this.rdTailX15.TabStop = true;
            this.rdTailX15.Text = "X15";
            this.rdTailX15.UseVisualStyleBackColor = true;
            // 
            // rdTailCessna
            // 
            this.rdTailCessna.AutoSize = true;
            this.rdTailCessna.Location = new System.Drawing.Point(234, 31);
            this.rdTailCessna.Name = "rdTailCessna";
            this.rdTailCessna.Size = new System.Drawing.Size(60, 17);
            this.rdTailCessna.TabIndex = 5;
            this.rdTailCessna.TabStop = true;
            this.rdTailCessna.Text = "Cessna";
            this.rdTailCessna.UseVisualStyleBackColor = true;
            // 
            // rdTailSpitefire
            // 
            this.rdTailSpitefire.AutoSize = true;
            this.rdTailSpitefire.Location = new System.Drawing.Point(127, 31);
            this.rdTailSpitefire.Name = "rdTailSpitefire";
            this.rdTailSpitefire.Size = new System.Drawing.Size(57, 17);
            this.rdTailSpitefire.TabIndex = 2;
            this.rdTailSpitefire.Text = "Spitfire";
            this.rdTailSpitefire.UseVisualStyleBackColor = true;
            // 
            // rdTailA10
            // 
            this.rdTailA10.AutoSize = true;
            this.rdTailA10.Checked = true;
            this.rdTailA10.Location = new System.Drawing.Point(24, 31);
            this.rdTailA10.Name = "rdTailA10";
            this.rdTailA10.Size = new System.Drawing.Size(44, 17);
            this.rdTailA10.TabIndex = 4;
            this.rdTailA10.TabStop = true;
            this.rdTailA10.Text = "A10";
            this.rdTailA10.UseVisualStyleBackColor = true;
            // 
            // rdTailBleriot
            // 
            this.rdTailBleriot.AutoSize = true;
            this.rdTailBleriot.Location = new System.Drawing.Point(127, 69);
            this.rdTailBleriot.Name = "rdTailBleriot";
            this.rdTailBleriot.Size = new System.Drawing.Size(54, 17);
            this.rdTailBleriot.TabIndex = 3;
            this.rdTailBleriot.TabStop = true;
            this.rdTailBleriot.Text = "Bleriot";
            this.rdTailBleriot.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(132, 143);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(226, 143);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(36, 143);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // TailChangeForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 206);
            this.ControlBox = false;
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TailChangeForm";
            this.Text = "TailChangeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTailX15;
        private System.Windows.Forms.RadioButton rdTailCessna;
        private System.Windows.Forms.RadioButton rdTailSpitefire;
        private System.Windows.Forms.RadioButton rdTailA10;
        private System.Windows.Forms.RadioButton rdTailBleriot;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
    }
}