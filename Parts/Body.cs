using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Physics_Project.Physics;
using Physics_Project;

namespace Physics_Project.Parts
{
    class Body : Part
    {

        public static int bodyIndex=0;
        public Body() { }
        public Body(ContentManager content, int index)
        {
            createBody(content, index);
            originalRotations.X = 90;
            originalRotations.Z = 180;
        }

        public void createBody(ContentManager content, int index)
        {
            bodyIndex = index;
            switch (index)
            {
                case 0:
                    {
                        model = content.Load<Model>("A10-Body");
                        weight = Game1.body_masses[0];        
                    }
                    break;
                case 1:
                    {
                        model = content.Load<Model>("Cessna-Body");
                        weight = Game1.body_masses[1];
                    }
                    break;
                case 2:
                    {
                        model = content.Load<Model>("Spitfire-Body");
                        weight = Game1.body_masses[2];
                    }
                    break;
                case 3:
                    {
                        model = content.Load<Model>("X15-Body");
                        weight = Game1.body_masses[3];
                    }
                    break;
            }
            forces = new List<Force>();
            this.forces.Add(new Gravity(Game1.body_masses[index]));
            this.forces.Add(new Drag(Game1.body_top_area[index], Game1.body_front_area[index], Game1.body_side_area[index]));
            offset = new Vector3(0,0,0);
        }
    }
}
