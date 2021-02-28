namespace Physics_Project
{
    partial class WingAddForm
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
            this.rdWingX15 = new System.Windows.Forms.RadioButton();
            this.rdWingCessna = new System.Windows.Forms.RadioButton();
            this.rdWingSpitefire = new System.Windows.Forms.RadioButton();
            this.rdWingA10 = new System.Windows.Forms.RadioButton();
            this.rdWingBleriot = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdWingRight = new System.Windows.Forms.RadioButton();
            this.rdWingLeft = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdWingX15);
            this.groupBox1.Controls.Add(this.rdWingCessna);
            this.groupBox1.Controls.Add(this.rdWingSpitefire);
            this.groupBox1.Controls.Add(this.rdWingA10);
            this.groupBox1.Controls.Add(this.rdWingBleriot);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wing type";
            // 
            // rdWingX15
            // 
            this.rdWingX15.AutoSize = true;
            this.rdWingX15.Location = new System.Drawing.Point(24, 74);
            this.rdWingX15.Name = "rdWingX15";
            this.rdWingX15.Size = new System.Drawing.Size(44, 17);
            this.rdWingX15.TabIndex = 6;
            this.rdWingX15.TabStop = true;
            this.rdWingX15.Text = "X15";
            this.rdWingX15.UseVisualStyleBackColor = true;
            // 
            // rdWingCessna
            // 
            this.rdWingCessna.AutoSize = true;
            this.rdWingCessna.Location = new System.Drawing.Point(232, 31);
            this.rdWingCessna.Name = "rdWingCessna";
            this.rdWingCessna.Size = new System.Drawing.Size(60, 17);
            this.rdWingCessna.TabIndex = 5;
            this.rdWingCessna.TabStop = true;
            this.rdWingCessna.Text = "Cessna";
            this.rdWingCessna.UseVisualStyleBackColor = true;
            // 
            // rdWingSpitefire
            // 
            this.rdWingSpitefire.AutoSize = true;
            this.rdWingSpitefire.Location = new System.Drawing.Point(122, 31);
            this.rdWingSpitefire.Name = "rdWingSpitefire";
            this.rdWingSpitefire.Size = new System.Drawing.Size(57, 17);
            this.rdWingSpitefire.TabIndex = 2;
            this.rdWingSpitefire.Text = "Spitfire";
            this.rdWingSpitefire.UseVisualStyleBackColor = true;
            // 
            // rdWingA10
            // 
            this.rdWingA10.AutoSize = true;
            this.rdWingA10.Checked = true;
            this.rdWingA10.Location = new System.Drawing.Point(24, 31);
            this.rdWingA10.Name = "rdWingA10";
            this.rdWingA10.Size = new System.Drawing.Size(44, 17);
            this.rdWingA10.TabIndex = 4;
            this.rdWingA10.TabStop = true;
            this.rdWingA10.Text = "A10";
            this.rdWingA10.UseVisualStyleBackColor = true;
            // 
            // rdWingBleriot
            // 
            this.rdWingBleriot.AutoSize = true;
            this.rdWingBleriot.Location = new System.Drawing.Point(122, 74);
            this.rdWingBleriot.Name = "rdWingBleriot";
            this.rdWingBleriot.Size = new System.Drawing.Size(54, 17);
            this.rdWingBleriot.TabIndex = 3;
            this.rdWingBleriot.TabStop = true;
            this.rdWingBleriot.Text = "Bleriot";
            this.rdWingBleriot.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdWingRight);
            this.groupBox2.Controls.Add(this.rdWingLeft);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wing side";
            // 
            // rdWingRight
            // 
            this.rdWingRight.AutoSize = true;
            this.rdWingRight.Location = new System.Drawing.Point(129, 39);
            this.rdWingRight.Name = "rdWingRight";
            this.rdWingRight.Size = new System.Drawing.Size(50, 17);
            this.rdWingRight.TabIndex = 8;
            this.rdWingRight.TabStop = true;
            this.rdWingRight.Text = "Right";
            this.rdWingRight.UseVisualStyleBackColor = true;
            // 
            // rdWingLeft
            // 
            this.rdWingLeft.AutoSize = true;
            this.rdWingLeft.Checked = true;
            this.rdWingLeft.Location = new System.Drawing.Point(22, 39);
            this.rdWingLeft.Name = "rdWingLeft";
            this.rdWingLeft.Size = new System.Drawing.Size(46, 17);
            this.rdWingLeft.TabIndex = 7;
            this.rdWingLeft.TabStop = true;
            this.rdWingLeft.Text = "Left ";
            this.rdWingLeft.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(244, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WingAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 331);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WingAddForm";
            this.Text = "WingAddForm";
            this.Load += new System.EventHandler(this.WingAddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdWingX15;
        private System.Windows.Forms.RadioButton rdWingCessna;
        private System.Windows.Forms.RadioButton rdWingSpitefire;
        private System.Windows.Forms.RadioButton rdWingA10;
        private System.Windows.Forms.RadioButton rdWingBleriot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdWingRight;
        private System.Windows.Forms.RadioButton rdWingLeft;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
    }
}