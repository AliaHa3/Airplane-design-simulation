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
    public partial class TailChangeForm : Form
    {
        public int state = -1;
        public TailChangeForm()
        {
            InitializeComponent();
            btnDone.Enabled = false;
            rdTailA10.Checked = true;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (rdTailA10.Checked) state = 0;
            else if (rdTailCessna.Checked) state = 1;
            else if (rdTailSpitefire.Checked) state = 2;
            else if (rdTailX15.Checked) state = 3;
            else state = 4;

            btnChange.Enabled = false;
            btnCancel.Enabled = false;
            btnDone.Enabled = true;
            PLANE.tail = new Tail(PLANE.contentmanager,state);
            PLANE.movingPart = PLANE.tail;
            PLANE.doneEditing = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PLANE.doneEditing = true;
            this.Close();
        }

        

        private void btnDone_Click(object sender, EventArgs e)
        {
            PLANE.doneEditing = true;
            this.Close();
        }
    }
}
