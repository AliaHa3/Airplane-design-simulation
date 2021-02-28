using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Physics_Project.Physics;

namespace Physics_Project.Parts
{
    class Wing : Part
    {
        public Wing() { }
        public Wing(ContentManager content, int index,int side )
        {
            createWing(content, index, side);
        }

        public void createWing(ContentManager content, int index, int side)
        {
            if (side == 0)
            {
                switch (index)
                {
                    case 0:
                    {
                        model = content.Load<Model>("A10-Left-Wing");
                        originalRotations.X = 90;
                        originalRotations.Z = 180;
                    }
                        break;
                    case 1:
                    {
                        model = content.Load<Model>("Cessna-Left-Wing");
                        originalRotations.X = 90;
                        originalRotations.Z = 180;
                    }
                        break;
                    case 2:
                    {
                        model = content.Load<Model>("Spitfire-Left-Wing");
                        originalRotations.X = 90;
                        originalRotations.Z = 180;
                    }
                        break;
                    case 3:
                    {
                        model = content.Load<Model>("X15-Left-Wing");
                        originalRotations.X = -90;
                        originalRotations.Z = 180;
                    }
                        break;
                    case 4:
                    {
                        model = content.Load<Model>("Bleriot-Left-Wing");
                        originalRotations.X = 90;
                        originalRotations.Z = 180;
                    }
                        break;
                }
            }
            else
            {
                switch (index)
                {
                    case 0:
                    {
                        model = content.Load<Model>("A10-Right-Wing");
                        originalRotations.X = 90;
                        originalRotations.Z = 180;
                    }
                        break;
                    case 1:
                    {
                        model = content.Load<Model>("Cessna-Right-Wing");
                        originalRotations.X = 90;
                        originalRotations.Z = 180;
                    }
                        break;
                    case 2:
                    {
                        model = content.Load<Model>("Spitfire-Right-Wing");
                        originalRotations.X = +90;
                        originalRotations.Z = 180;
                    }
                        break;
                    case 3:
                    {
                        model = content.Load<Model>("X15-Right-Wing");
                        originalRotations.X = -90;
                        originalRotations.Z = 180;
                    }
                        break;
                    case 4:
                    {
                        model = content.Load<Model>("Bleriot-Right-Wing");
                        originalRotations.X = 90;
                        originalRotations.Z = 180;
                    }
                        break;
                }
            }
            
            forces = new List<Force>();
            this.forces.Add(new Gravity(Game1.wing_masses[index]));
            this.forces.Add(new Drag(Game1.wing_top_area[index], Game1.wing_front_area[index], Game1.wing_side_area[index]));
            this.forces.Add(new Lift(Game1.wing_top_area[index]));
            this.weight = Game1.wing_masses[index];
            //angle = PLANE.rotation;
        }
    }
}
