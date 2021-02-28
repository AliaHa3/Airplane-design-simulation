namespace Physics_Project
{
    partial class EngineAddForm
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
            this.rdFan = new System.Windows.Forms.RadioButton();
            this.rdJet = new System.Windows.Forms.RadioButton();
            this.rdRocket = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdFan
            // 
            this.rdFan.AutoSize = true;
            this.rdFan.Checked = true;
            this.rdFan.Location = new System.Drawing.Point(20, 33);
            this.rdFan.Name = "rdFan";
            this.rdFan.Size = new System.Drawing.Size(43, 17);
            this.rdFan.TabIndex = 0;
            this.rdFan.TabStop = true;
            this.rdFan.Text = "Fan";
            this.rdFan.UseVisualStyleBackColor = true;
            // 
            // rdJet
            // 
            this.rdJet.AutoSize = true;
            this.rdJet.Location = new System.Drawing.Point(102, 33);
            this.rdJet.Name = "rdJet";
            this.rdJet.Size = new System.Drawing.Size(39, 17);
            this.rdJet.TabIndex = 1;
            this.rdJet.TabStop = true;
            this.rdJet.Text = "Jet";
            this.rdJet.UseVisualStyleBackColor = true;
            // 
            // rdRocket
            // 
            this.rdRocket.AutoSize = true;
            this.rdRocket.Location = new System.Drawing.Point(170, 33);
            this.rdRocket.Name = "rdRocket";
            this.rdRocket.Size = new System.Drawing.Size(60, 17);
            this.rdRocket.TabIndex = 2;
            this.rdRocket.TabStop = true;
            this.rdRocket.Text = "Rocket";
            this.rdRocket.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdFan);
            this.groupBox1.Controls.Add(this.rdRocket);
            this.groupBox1.Controls.Add(this.rdJet);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Engine type";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(111, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(203, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EngineAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 168);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EngineAddForm";
            this.Text = "EngineAddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdFan;
        private System.Windows.Forms.RadioButton rdJet;
        private System.Windows.Forms.RadioButton rdRocket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;

    }
}