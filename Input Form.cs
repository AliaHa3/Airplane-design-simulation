using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Physics_Project.Parts;
using Point = System.Drawing.Point;

namespace Physics_Project
{
    public partial class Input_Form : Form
    {
        public int state = -1;
        public static int chosenAngle = 7;
        public Input_Form()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PLANE.adjustMode = true;
            if (rdWing.Checked)
            {
                WingAddForm wingAddForm = new WingAddForm();
                wingAddForm.StartPosition = FormStartPosition.Manual;
                wingAddForm.Location = new Point(15 + this.Location.X, this.Height/4 + this.Location.Y);
                wingAddForm.ShowDialog();

                if (wingAddForm.side == 0)
                    lstboxLeftWings.Items.Add(wingAddForm.name);
                else if(wingAddForm.side == 1)
                    lstboxRightWings.Items.Add(wingAddForm.name);
            }
            else if(rdEngine.Checked)
            {
                EngineAddForm engineAddForm = new EngineAddForm();
                engineAddForm.StartPosition = FormStartPosition.Manual;
                engineAddForm.Location = new Point(15 + this.Location.X, this.Height/4 + this.Location.Y);
                engineAddForm.ShowDialog();

                if(engineAddForm.name != null)
                    lstboxEngines.Items.Add(engineAddForm.name);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            PLANE.adjustMode = true;
            if (rdBody.Checked)
            {
                BodyChangeForm bodyChangeForm = new BodyChangeForm();
                bodyChangeForm.StartPosition = FormStartPosition.Manual;
                bodyChangeForm.Location = new Point(15 + this.Location.X, this.Height/4 + this.Location.Y);
                bodyChangeForm.ShowDialog();
            }
            else
            {
                TailChangeForm tailChangeForm = new TailChangeForm();
                tailChangeForm.StartPosition = FormStartPosition.Manual;
                tailChangeForm.Location = new Point(15 + this.Location.X, this.Height / 4 + this.Location.Y);
                tailChangeForm.ShowDialog();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            PLANE.adjustMode = false;
        }

        private void btnWingDel_Click(object sender, EventArgs e)
        {
            if (lstboxRightWings.SelectedIndices.Count > 0)
            {
                PLANE.rightWings.RemoveAt(lstboxRightWings.SelectedIndex);
                lstboxRightWings.Items.RemoveAt(lstboxRightWings.SelectedIndex);
            }
            else if(lstboxLeftWings.SelectedIndices.Count > 0)
            {
                PLANE.leftWings.RemoveAt(lstboxLeftWings.SelectedIndex);
                lstboxLeftWings.Items.RemoveAt(lstboxLeftWings.SelectedIndex);
            }
            else
            {
                MessageBox.Show("You haven't selected any item yet !", "Error");
            }
        }

        private void lstboxLeftWings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxRightWings.SelectedIndices.Count > 0)
            {
                lstboxRightWings.SetSelected(lstboxRightWings.SelectedIndex, false);
            }

            int cnt = PLANE.leftWings.Count;

            for (int i = 0; i < cnt; i++)
                PLANE.leftWings[i].selectedForDeletion = false;

            cnt = PLANE.rightWings.Count;

            for (int i = 0; i < cnt; i++)
                PLANE.rightWings[i].selectedForDeletion = false;

            //if(cnt > 0)
            try { PLANE.leftWings[lstboxLeftWings.SelectedIndex].selectedForDeletion = true; }
            catch (Exception ex) { }
        }

        private void lstboxRightWings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxLeftWings.SelectedIndices.Count > 0)
            {
                lstboxLeftWings.SetSelected(lstboxLeftWings.SelectedIndex, false);
            }

            int cnt = PLANE.rightWings.Count;

            for (int i = 0; i < cnt; i++)
                PLANE.rightWings[i].selectedForDeletion = false;

            cnt = PLANE.leftWings.Count;

            for (int i = 0; i < cnt; i++)
                PLANE.leftWings[i].selectedForDeletion = false;

            //if (cnt > 0)
            try { PLANE.rightWings[lstboxRightWings.SelectedIndex].selectedForDeletion = true; }
            catch (Exception ex) { }
        }

        private void btnEngineDel_Click(object sender, EventArgs e)
        {
            if (lstboxEngines.SelectedIndices.Count > 0)
            {
                PLANE.engines.RemoveAt(lstboxEngines.SelectedIndex);
                lstboxEngines.Items.RemoveAt(lstboxEngines.SelectedIndex);
            }
            else
            {
                MessageBox.Show("You haven't selected any item yet !", "Error");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl1.SelectedTab == tabControl1.TabPages[1])
                //PLANE.adjustMode = true;

            if (tabControl1.SelectedTab == tabControl1.TabPages[0])
            {
                foreach (Wing wing in PLANE.leftWings)
                {
                    wing.selectedForDeletion = false;
                }
                foreach (Wing wing in PLANE.rightWings)
                {
                    wing.selectedForDeletion = false;
                }
                foreach (Engine engin in PLANE.engines)
                {
                    engin.selectedForDeletion = false;
                }
            }
        }

        private void lstboxEngines_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cnt = PLANE.engines.Count;

            for (int i = 0; i < cnt; i++)
                PLANE.engines[i].selectedForDeletion = false;

            //if (cnt > 0)
            try
            {
                PLANE.engines[lstboxEngines.SelectedIndex].selectedForDeletion = true;
                if (PLANE.engines[lstboxEngines.SelectedIndex].turnedOff) button1.Text = "Turn On";
                else button1.Text = "Turn Off";
            }
            catch (Exception ex) { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstboxEngines.SelectedIndex != -1)
            {
                if (PLANE.engines[lstboxEngines.SelectedIndex].turnedOff)
                {
                    PLANE.engines[lstboxEngines.SelectedIndex].turnedOff = false;
                    button1.Text = "Turn Off";
                }
                else
                {
                    PLANE.engines[lstboxEngines.SelectedIndex].turnedOff = true;
                    button1.Text = "Turn On";
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            chosenAngle = trackBar1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region clear

            lstboxEngines.Items.Clear();
            lstboxLeftWings.Items.Clear();
            lstboxRightWings.Items.Clear();

            PLANE.engines.Clear();
            PLANE.leftWings.Clear();
            PLANE.rightWings.Clear();

            #endregion clear

            PLANE.adjustMode = true;

            PLANE.body = new Body(PLANE.contentmanager, 0);
            PLANE.body.position = PLANE.position;

            PLANE.leftWings.Add(new Wing(PLANE.contentmanager, 0, 1));
            PLANE.leftWings[0].offset = new Vector3(-15f,0,0);

            PLANE.rightWings.Add(new Wing(PLANE.contentmanager, 0, 0));
            PLANE.rightWings[0].offset = new Vector3(+15f, 0, 0);

            PLANE.engines.Add(new Engine(PLANE.contentmanager, 0));
            PLANE.engines.Add(new Engine(PLANE.contentmanager, 0));
            PLANE.engines[0].offset = new Vector3(-7.5f,0,0);
            PLANE.engines[1].offset = new Vector3(+7.5f, 0, 0);

            PLANE.tail = new Tail(PLANE.contentmanager,0);
            PLANE.tail.offset = new Vector3(0,4.5f,-22.5f);

            lstboxEngines.Items.Add("Fan");
            lstboxEngines.Items.Add("Fan");

            lstboxLeftWings.Items.Add("A10 left wing");
            lstboxRightWings.Items.Add("A10 right wing");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game1.debuggingForm.Show();
        }
    }
}
