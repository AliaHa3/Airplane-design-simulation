using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Graphics;
using Physics_Project.Physics;

namespace Physics_Project.Parts
{
    abstract class Part
    {
        
        
        public List<Force> forces = new List<Force>();

        public Model model; 
        public double weight;
        public Vector3 position;
        public Vector3 angle = new Vector3(0, 0, 0);
        public Vector3 offset = Vector3.Zero;
        public Vector3 modifiedOffset;
        public Vector3 originalRotations = new Vector3(0, 0, 0);


        protected Matrix World = Matrix.Identity;
        public double scale = 1;


        public bool selectedForDeletion = false;
        public bool turnedOff = false; // Engine' thrust 



        public void update()
        {
            int counter = 0;

            position = PLANE.position + offset;
            foreach (Force force in forces)
            {
                if (turnedOff && counter == 1)
                {
                    force.intensity = Vector3.Zero;
                }
                else
                {
                    force.intensity = force.calculate(position, PLANE.rotation);
                }
                counter++;
            }
        }

        public void angularUpdate()
        {
            position = PLANE.position + modifiedOffset;
            modifiedOffset = Vector3.Transform(offset, Matrix.CreateRotationX(MathHelper.ToRadians(PLANE.rotation.X)) *
                Matrix.CreateRotationY(MathHelper.ToRadians(PLANE.rotation.Y)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(PLANE.rotation.Z)));

            foreach (Force force in forces)
            {
                force.momentumIntensity = force.angularCalculate(position, PLANE.rotation);
            }
            World = Matrix.Identity
                * Matrix.CreateScale((float)scale+2.5f)
                * Matrix.CreateRotationX(MathHelper.ToRadians(originalRotations.X))
                * Matrix.CreateRotationY(MathHelper.ToRadians(originalRotations.Y))
                * Matrix.CreateRotationZ(MathHelper.ToRadians(originalRotations.Z))
                * Matrix.CreateTranslation(offset)
                * Matrix.CreateRotationX(MathHelper.ToRadians(PLANE.rotation.X))
                * Matrix.CreateRotationY(MathHelper.ToRadians(PLANE.rotation.Y))
                * Matrix.CreateRotationZ(MathHelper.ToRadians(PLANE.rotation.Z))
                * Matrix.CreateTranslation(PLANE.position);
        }
        public void draw(GameTime gametTime, Camera camera)
        {
            try
            {
                foreach (ModelMesh mesh in model.Meshes)
                {
                    foreach (BasicEffect effect in mesh.Effects)
                    {
                        effect.EnableDefaultLighting();

                        if (this.selectedForDeletion == true)
                        {
                            effect.FogEnabled = true;
                            effect.FogColor = Color.Blue.ToVector3();
                            effect.FogStart = camera.distance/2;
                            effect.FogEnd = camera.distance;
                        }
                        else
                        {
                            effect.FogEnabled = false;
                        }

                        effect.World = World;
                        effect.View = camera.View;
                        effect.Projection = camera.Projection;
                    }
                    mesh.Draw();
                }

            }
            catch (Exception e)
            {
            }
        }
    }
}
