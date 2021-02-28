using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Physics_Project
{
    public partial class DebuggingForm : Form
    {
        /*
         * flag indicates to the update mehod
         * true means the update method is manual
         * false means it's auto
         * the default method is manual .
         */
        public bool flag;
        private double millisecondsperfram = 30;
        private double timesincelastupdate = 0; 
        public DebuggingForm()
        {
            flag = true;
            InitializeComponent();
        }

        

        private void updatePLANEProperties()
        {
            cglbl.Text = (PLANE.centerOfGravity.X - PLANE.position.X).ToString("0.00") + " , " + (PLANE.centerOfGravity.Y - PLANE.position.Y).ToString("0.00") + " , " + (PLANE.centerOfGravity.Z - PLANE.position.Z).ToString("0.00");
            albl.Text = PLANE.acceleration.X.ToString("0.00") + " , " + PLANE.acceleration.Y.ToString("0.00") + " , " + PLANE.acceleration.Z.ToString("0.00");
            aalbl.Text = PLANE.angularAcceleration.X.ToString("0.00") + " , " + PLANE.angularAcceleration.Y.ToString("0.00") + " , " + PLANE.angularAcceleration.Z.ToString("0.00");
            vlbl.Text = PLANE.velocity.X.ToString("0.00") + " , " + PLANE.velocity.Y.ToString("0.00") + " , " + PLANE.velocity.Z.ToString("0.00");
            avlbl.Text = PLANE.angularVelocity.X.ToString("0.00") + " , " + PLANE.angularVelocity.Y.ToString("0.00") + " , " + PLANE.angularVelocity.Z.ToString("0.00");
            plbl.Text = PLANE.position.X.ToString("0.00") + " , " + PLANE.position.Y.ToString("0.00") + " , " + PLANE.position.Z.ToString("0.00");
            angleslbl.Text = PLANE.rotation.X.ToString("0.00") + " , " + PLANE.rotation.Y.ToString("0.00") + " , " + PLANE.rotation.Z.ToString("0.00");
            wlbl.Text = PLANE.weight.ToString("0.00");
        }
        private void updateRightWing()
        {
            try
            {
                label50.Text = PLANE.rightWings[0].forces[2].intensity.X.ToString("0.00") + " , " + PLANE.rightWings[0].forces[2].intensity.Y.ToString("0.00") + " , " + PLANE.rightWings[0].forces[2].intensity.Z.ToString("0.00"); // lift inten
                label48.Text = PLANE.rightWings[0].forces[0].intensity.X.ToString("0.00") + " , " + PLANE.rightWings[0].forces[0].intensity.Y.ToString("0.00") + " , " + PLANE.rightWings[0].forces[0].intensity.Z.ToString("0.00"); // weight inten
                label40.Text = PLANE.rightWings[0].forces[1].intensity.X.ToString("0.00") + " , " + PLANE.rightWings[0].forces[1].intensity.Y.ToString("0.00") + " , " + PLANE.rightWings[0].forces[1].intensity.Z.ToString("0.00"); // drag inten

                label49.Text = PLANE.rightWings[0].forces[2].forceValue.ToString("0.00"); // lift value
                label47.Text = PLANE.rightWings[0].forces[0].forceValue.ToString("0.00"); // weight value
                label39.Text = PLANE.rightWings[0].forces[1].forceValue.ToString("0.00"); // drag value

                label77.Text = PLANE.rightWings[0].angle.X.ToString("0.00") + " , " + PLANE.rightWings[0].angle.Y.ToString("0.00") + " , " + PLANE.rightWings[0].angle.Z.ToString("0.00"); // angles 
                label82.Text = PLANE.rightWings[0].position.X.ToString("0.00") + " , " + PLANE.rightWings[0].position.Y.ToString("0.00") + " , " + PLANE.rightWings[0].position.Z.ToString("0.00"); ; // position

            }
            catch (Exception e) { }
        }

        private void updateLeftWing()
        {
            try
            {
                label38.Text = PLANE.leftWings[0].forces[2].intensity.X.ToString("0.00") + " , " + PLANE.leftWings[0].forces[2].intensity.Y.ToString("0.00") + " , " + PLANE.leftWings[0].forces[2].intensity.Z.ToString("0.00"); // lift inten
                label36.Text = PLANE.leftWings[0].forces[0].intensity.X.ToString("0.00") + " , " + PLANE.leftWings[0].forces[0].intensity.Y.ToString("0.00") + " , " + PLANE.leftWings[0].forces[0].intensity.Z.ToString("0.00"); // weight inten
                label34.Text = PLANE.leftWings[0].forces[1].intensity.X.ToString("0.00") + " , " + PLANE.leftWings[0].forces[1].intensity.Y.ToString("0.00") + " , " + PLANE.leftWings[0].forces[1].intensity.Z.ToString("0.00"); // drag inten

                label37.Text = PLANE.leftWings[0].forces[2].forceValue.ToString("0.00"); // lift value
                label35.Text = PLANE.leftWings[0].forces[0].forceValue.ToString("0.00"); // weight value
                label33.Text = PLANE.leftWings[0].forces[1].forceValue.ToString("0.00"); // drag value

                label76.Text = PLANE.leftWings[0].angle.X.ToString("0.00") + " , " + PLANE.leftWings[0].angle.Y.ToString("0.00") + " , " + PLANE.leftWings[0].angle.Z.ToString("0.00"); // angles 
                label81.Text = PLANE.leftWings[0].position.X.ToString("0.00") + " , " + PLANE.leftWings[0].position.Y.ToString("0.00") + " , " + PLANE.leftWings[0].position.Z.ToString("0.00"); ; // position

            }
            catch (Exception e) { }
        }

        private void updateBody()
        {
            try
            {
                label60.Text = PLANE.body.forces[0].intensity.X.ToString("0.00") + " , " + PLANE.body.forces[0].intensity.Y.ToString("0.00") + " , " + PLANE.body.forces[0].intensity.Z.ToString("0.00"); // weight inten
                label58.Text = PLANE.body.forces[1].intensity.X.ToString("0.00") + " , " + PLANE.body.forces[1].intensity.Y.ToString("0.00") + " , " + PLANE.body.forces[1].intensity.Z.ToString("0.00"); // drag inten

                label59.Text = PLANE.body.forces[0].forceValue.ToString("0.00"); // weight value
                label57.Text = PLANE.body.forces[1].forceValue.ToString("0.00"); // drag value

                label78.Text = PLANE.body.angle.X.ToString("0.00") + " , " + PLANE.body.angle.Y.ToString("0.00") + " , " + PLANE.body.angle.Z.ToString("0.00"); // angles 
                label83.Text = PLANE.body.position.X.ToString("0.00") + " , " + PLANE.body.position.Y.ToString("0.00") + " , " + PLANE.body.position.Z.ToString("0.00"); // position

            }
            catch (Exception e) { }
        }
        private void updateTail()
        {
            try
            {
                label56.Text = PLANE.tail.forces[2].intensity.X.ToString("0.00") + " , " + PLANE.tail.forces[2].intensity.Y.ToString("0.00") + " , " + PLANE.tail.forces[2].intensity.Z.ToString("0.00"); // lift inten
                label54.Text = PLANE.tail.forces[0].intensity.X.ToString("0.00") + " , " + PLANE.tail.forces[0].intensity.Y.ToString("0.00") + " , " + PLANE.tail.forces[0].intensity.Z.ToString("0.00"); // weight inten
                label52.Text = PLANE.tail.forces[1].intensity.X.ToString("0.00") + " , " + PLANE.tail.forces[1].intensity.Y.ToString("0.00") + " , " + PLANE.tail.forces[1].intensity.Z.ToString("0.00"); // drag inten

                label55.Text = PLANE.tail.forces[2].forceValue.ToString("0.00"); // lift value
                label53.Text = PLANE.tail.forces[0].forceValue.ToString("0.00"); // weight value
                label51.Text = PLANE.tail.forces[1].forceValue.ToString("0.00"); // deag value

                label74.Text = PLANE.tail.angle.X.ToString("0.00") + " , " + PLANE.tail.angle.Y.ToString("0.00") + " , " + PLANE.tail.angle.Z.ToString("0.00"); // angles 
                label79.Text = PLANE.tail.position.X.ToString("0.00") + " , " + PLANE.tail.position.Y.ToString("0.00") + " , " + PLANE.tail.position.Z.ToString("0.00"); // position

            }
            catch (Exception e) { }
        }
        private void updateEngine()
        {
            try
            {
                label66.Text = PLANE.engines[0].forces[1].intensity.X.ToString("0.00") + " , " + PLANE.engines[0].forces[1].intensity.Y.ToString("0.00") + " , " + PLANE.engines[0].forces[1].intensity.Z.ToString("0.00"); // thrust inten
                label64.Text = PLANE.engines[0].forces[0].intensity.X.ToString("0.00") + " , " + PLANE.engines[0].forces[0].intensity.Y.ToString("0.00") + " , " + PLANE.engines[0].forces[0].intensity.Z.ToString("0.00"); // weight inten
                //label62.Text = ; // drag inten

                label65.Text = PLANE.engines[0].forces[1].forceValue.ToString("0.00"); // thrust value
                label63.Text = PLANE.engines[0].forces[0].forceValue.ToString("0.00"); // weight value
                //label61.Text = ; // deag value

                label75.Text = PLANE.engines[0].angle.X.ToString("0.00") + " , " + PLANE.engines[0].angle.Y.ToString("0.00") + " , " + PLANE.engines[0].angle.Z.ToString("0.00"); // angles 
                label80.Text = PLANE.engines[0].position.X.ToString("0.00") + " , " + PLANE.engines[0].position.Y.ToString("0.00") + " , " + PLANE.engines[0].position.Z.ToString("0.00"); // position

            }
            catch (Exception e) { }
        }
        public void update()
        {
            updatePLANEProperties();
            updateBody();
            updateRightWing();
            updateLeftWing();
            updateTail();
            updateEngine();
        }
        private void btnupdatemanually_Click_1(object sender, EventArgs e)
        {
            flag = true;
            update();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            flag = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            flag = true;
        }
    }
}
