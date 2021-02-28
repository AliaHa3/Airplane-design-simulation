using System.Drawing;
using System.Windows.Forms;

namespace Physics_Project
{
    partial class Input_Form
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.rdWing = new System.Windows.Forms.RadioButton();
            this.rdEngine = new System.Windows.Forms.RadioButton();
            this.rdTail = new System.Windows.Forms.RadioButton();
            this.rdBody = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstboxLeftWings = new System.Windows.Forms.ListBox();
            this.btnWingDel = new System.Windows.Forms.Button();
            this.lstboxRightWings = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstboxEngines = new System.Windows.Forms.ListBox();
            this.btnEngineDel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(293, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(293, 318);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(293, 163);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // rdWing
            // 
            this.rdWing.AutoSize = true;
            this.rdWing.Checked = true;
            this.rdWing.Location = new System.Drawing.Point(36, 18);
            this.rdWing.Name = "rdWing";
            this.rdWing.Size = new System.Drawing.Size(50, 17);
            this.rdWing.TabIndex = 3;
            this.rdWing.TabStop = true;
            this.rdWing.Text = "Wing";
            this.rdWing.UseVisualStyleBackColor = true;
            // 
            // rdEngine
            // 
            this.rdEngine.AutoSize = true;
            this.rdEngine.Location = new System.Drawing.Point(138, 19);
            this.rdEngine.Name = "rdEngine";
            this.rdEngine.Size = new System.Drawing.Size(58, 17);
            this.rdEngine.TabIndex = 4;
            this.rdEngine.TabStop = true;
            this.rdEngine.Text = "Engine";
            this.rdEngine.UseVisualStyleBackColor = true;
            // 
            // rdTail
            // 
            this.rdTail.AutoSize = true;
            this.rdTail.Location = new System.Drawing.Point(138, 19);
            this.rdTail.Name = "rdTail";
            this.rdTail.Size = new System.Drawing.Size(42, 17);
            this.rdTail.TabIndex = 6;
            this.rdTail.TabStop = true;
            this.rdTail.Text = "Tail";
            this.rdTail.UseVisualStyleBackColor = true;
            // 
            // rdBody
            // 
            this.rdBody.AutoSize = true;
            this.rdBody.Checked = true;
            this.rdBody.Location = new System.Drawing.Point(37, 19);
            this.rdBody.Name = "rdBody";
            this.rdBody.Size = new System.Drawing.Size(49, 17);
            this.rdBody.TabIndex = 5;
            this.rdBody.TabStop = true;
            this.rdBody.Text = "Body";
            this.rdBody.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdEngine);
            this.groupBox1.Controls.Add(this.rdWing);
            this.groupBox1.Location = new System.Drawing.Point(21, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 53);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBody);
            this.groupBox2.Controls.Add(this.rdTail);
            this.groupBox2.Location = new System.Drawing.Point(21, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 53);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 593);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btnDone);
            this.tabPage1.Controls.Add(this.btnModify);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Addtion";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Show Info";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Standard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "7";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trackBar1.LargeChange = 0;
            this.trackBar1.Location = new System.Drawing.Point(21, 242);
            this.trackBar1.Maximum = 15;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(247, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Value = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deletion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Location = new System.Drawing.Point(25, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 157);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wings";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstboxLeftWings);
            this.panel2.Controls.Add(this.btnWingDel);
            this.panel2.Controls.Add(this.lstboxRightWings);
            this.panel2.Location = new System.Drawing.Point(6, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 123);
            this.panel2.TabIndex = 4;
            // 
            // lstboxLeftWings
            // 
            this.lstboxLeftWings.FormattingEnabled = true;
            this.lstboxLeftWings.Location = new System.Drawing.Point(13, 13);
            this.lstboxLeftWings.Name = "lstboxLeftWings";
            this.lstboxLeftWings.Size = new System.Drawing.Size(101, 82);
            this.lstboxLeftWings.TabIndex = 0;
            this.lstboxLeftWings.SelectedIndexChanged += new System.EventHandler(this.lstboxLeftWings_SelectedIndexChanged);
            // 
            // btnWingDel
            // 
            this.btnWingDel.Location = new System.Drawing.Point(129, 72);
            this.btnWingDel.Name = "btnWingDel";
            this.btnWingDel.Size = new System.Drawing.Size(75, 23);
            this.btnWingDel.TabIndex = 1;
            this.btnWingDel.Text = "Delete";
            this.btnWingDel.UseVisualStyleBackColor = true;
            this.btnWingDel.Click += new System.EventHandler(this.btnWingDel_Click);
            // 
            // lstboxRightWings
            // 
            this.lstboxRightWings.FormattingEnabled = true;
            this.lstboxRightWings.Location = new System.Drawing.Point(218, 13);
            this.lstboxRightWings.Name = "lstboxRightWings";
            this.lstboxRightWings.Size = new System.Drawing.Size(101, 82);
            this.lstboxRightWings.TabIndex = 2;
            this.lstboxRightWings.SelectedIndexChanged += new System.EventHandler(this.lstboxRightWings_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.btnEngineDel);
            this.groupBox3.Location = new System.Drawing.Point(25, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 155);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Engines";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lstboxEngines);
            this.panel3.Location = new System.Drawing.Point(19, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 107);
            this.panel3.TabIndex = 5;
            // 
            // lstboxEngines
            // 
            this.lstboxEngines.FormattingEnabled = true;
            this.lstboxEngines.Location = new System.Drawing.Point(0, 3);
            this.lstboxEngines.Name = "lstboxEngines";
            this.lstboxEngines.Size = new System.Drawing.Size(101, 82);
            this.lstboxEngines.TabIndex = 4;
            this.lstboxEngines.SelectedIndexChanged += new System.EventHandler(this.lstboxEngines_SelectedIndexChanged);
            // 
            // btnEngineDel
            // 
            this.btnEngineDel.Location = new System.Drawing.Point(238, 98);
            this.btnEngineDel.Name = "btnEngineDel";
            this.btnEngineDel.Size = new System.Drawing.Size(75, 23);
            this.btnEngineDel.TabIndex = 3;
            this.btnEngineDel.Text = "Delete";
            this.btnEngineDel.UseVisualStyleBackColor = true;
            this.btnEngineDel.Click += new System.EventHandler(this.btnEngineDel_Click);
            // 
            // Input_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 386);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(940, 20);
            this.Name = "Input_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Input_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAdd;
        private Button btnDone;
        private Button btnModify;
        private RadioButton rdWing;
        private RadioButton rdEngine;
        private RadioButton rdTail;
        private RadioButton rdBody;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnWingDel;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private ListBox lstboxEngines;
        private Button btnEngineDel;
        private ListBox lstboxLeftWings;
        private ListBox lstboxRightWings;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private TrackBar trackBar1;
        private Label label1;
        private Button button2;
        private Button button3;
    }
}