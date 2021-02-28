using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Physics_Project.Parts;

namespace Physics_Project
{
    public partial class WingAddForm : Form
    {
        public int side = -1;
        public int type = -1;
        public string name;
        public WingAddForm()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void WingAddForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] wingsNames = new[] { "A10 wing", "Cessna wing", "Spitfire wing", "X15 wing", "Bleriot wing" };
            

            if (rdWingA10.Checked) type = 0;
            else if (rdWingCessna.Checked) type = 1;
            else if (rdWingSpitefire.Checked) type = 2;
            else if (rdWingX15.Checked) type = 3;
            else if (rdWingBleriot.Checked) type = 4;

            if (rdWingLeft.Checked) side = 0;
            else if (rdWingRight.Checked) side = 1;

            if (side == 0)
            {
                PLANE.leftWings.Add(new Wing(PLANE.contentmanager, type, side));
                PLANE.movingPart = PLANE.leftWings[PLANE.leftWings.Count - 1];
            }
            else
            {
                PLANE.rightWings.Add(new Wing(PLANE.contentmanager, type, side));
                PLANE.movingPart = PLANE.rightWings[PLANE.rightWings.Count - 1];
            }
            PLANE.doneEditing = false;
            btnCancel.Enabled = false;
            btnAdd.Enabled = false;
            button1.Enabled = true;
            name = wingsNames[type];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PLANE.doneEditing = true;
            this.Close();
        }
    }
}
