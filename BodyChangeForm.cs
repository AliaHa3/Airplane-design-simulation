using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Physics_Project.Parts;

namespace Physics_Project
{
    public partial class BodyChangeForm : Form
    {
        public int state = -1;
        public BodyChangeForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            PLANE.speedReached = false;
            if (rdBodyA10.Checked) state = 0;
            else if (rdBodyCessna.Checked) state = 1;
            else if (rdBodySpitfire.Checked) state = 2;
            else state = 3;

            PLANE.body = new Body(PLANE.contentmanager, state);
            
            this.Close();
        }
    }
}
