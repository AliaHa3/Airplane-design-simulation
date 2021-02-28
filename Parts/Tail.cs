using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Physics_Project.Physics;
namespace Physics_Project.Parts
{
    class Tail : Part
    {
        public Tail() { }

        public Tail(ContentManager content, int index)
        {
            createTail(content, index);
            originalRotations.X = 90;
            originalRotations.Z = 180;
        }

        public void createTail(ContentManager content, int index)
        {
            switch (index)
            {
                case 0:
                    model = content.Load<Model>("A10-Tail");
                    break;
                case 1:
                    model = content.Load<Model>("Cessna-Tail");
                    break;
                case 2:
                    model = content.Load<Model>("Spitfire-Tail");
                    break;
                case 3:
                    model = content.Load<Model>("X15-Tail");
                    break;
                case 4:
                    model = content.Load<Model>("Bleriot-Tail");
                    break;
            }
        }

        //this.forces.Add(new Gravity(weight));
        //this.forces.Add(new Drag());
        //this.forces.Add(new Lift());

    }
}
