using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Physics_Project.Physics;

namespace Physics_Project.Parts
{
    class Engine : Part
    {
        public Engine() { }
        public Engine(ContentManager content,int index)
        {
            createEngine(content,index);
        }
        public void createEngine(ContentManager content, int index)
        {
            

            switch (index)
            {
                case 0:
                    model = content.Load<Model>("A10-engine");
                    break;
                case 1:
                    {
                        model = content.Load<Model>("Jet-Engine");
                        scale = 1.7;
                        originalRotations.X = 90;
                        originalRotations.Z = 180;
                    }
                    break;
                case 2:
                    {
                        model = content.Load<Model>("Rocket-Engine");
                        scale = 3;
                        originalRotations.X = 90;
                        originalRotations.Z = 180;
                    }
                    break;
            }
            forces = new List<Force>();
            this.forces.Add(new Gravity(Game1.engine_masses[index]));
            this.forces.Add(new Thrust(Game1.engine_force[index]));
            this.forces.Add(new Drag(Game1.engine_top_area[index], Game1.engine_front_area[index], Game1.engine_top_area[index]));
        }

    }
}
