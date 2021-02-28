using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Physics_Project
{
    class Cinematic_camera : Camera   
    {
        
        public Cinematic_camera(Game game, Vector3 Ship_pos)

        {
            distance = 100f;
            _pos = new Vector3(Ship_pos.X + distance,Ship_pos.Y+distance,Ship_pos.Z +distance) ;
            View = Matrix.CreateLookAt(_pos, Ship_pos, Vector3.Up);
            Projection = Matrix.CreatePerspectiveFieldOfView(
                 MathHelper.PiOver4,
                 game.GraphicsDevice.Viewport.AspectRatio,
                 1f,
                 10000000.0f);
            

        }

        public void Update(Vector3 Ship_pos)
        {

            

            if (Ship_pos.Z - _pos.Z > distance*5 )
                _pos.Z = Ship_pos.Z + distance;
             if (Ship_pos.Y - _pos.Y > distance*2)
                _pos.Y = Ship_pos.Y + distance;
             if (Ship_pos.X - _pos.X > distance*2)
                 _pos.X = Ship_pos.X + distance;
            View = Matrix.CreateLookAt(_pos, Ship_pos, Vector3.Up);


        }
    }
}
