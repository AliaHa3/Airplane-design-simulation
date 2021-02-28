using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Physics_Project.Parts;

namespace Physics_Project
{
    public partial class EngineAddForm : Form
    {
        public int type = -1;
        public string name = null;
        public EngineAddForm()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] enginesNames = new[] { "Fan", "Jet", "Rocket" };

            if (rdFan.Checked) type = 0;
            else if (rdJet.Checked) type = 1;
            else type = 2;

            PLANE.engines.Add(new Engine(PLANE.contentmanager,type));
            PLANE.movingPart = PLANE.engines[PLANE.engines.Count - 1];
            btnCancel.Enabled = false;
            btnAdd.Enabled = false;
            PLANE.doneEditing = false;
            button1.Enabled = true;
            name = enginesNames[type];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PLANE.doneEditing = true;

            this.Close();
        }
    }
}
