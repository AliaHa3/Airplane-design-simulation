using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Physics_Project
{
    public class Center_camera : Camera
    {
       
        public Vector3 Rotation = new Vector3(0,0,0);
       
        public Center_camera(Game game, Vector3 Ship_pos)

        {
            distance = 80f;
            _pos = new Vector3(Ship_pos.X,Ship_pos.Y +(distance /3),Ship_pos.Z - distance);
            View = Matrix.CreateLookAt(_pos, Ship_pos, Vector3.Up);
            Projection = Matrix.CreatePerspectiveFieldOfView(
                 MathHelper.PiOver4,
                 game.GraphicsDevice.Viewport.AspectRatio,
                 1f,
                 10000000.0f);
        }

        public void Update(Vector3 Ship_pos)
        {
            _pos = new Vector3(Ship_pos.X, Ship_pos.Y + (distance / 3), Ship_pos.Z - distance);


            KeyboardState ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.PageDown))
                distance--;
            if (ks.IsKeyDown(Keys.PageUp))
                distance++;
            if (ks.IsKeyDown(Keys.A))
                Rotation.Y -= 0.05f;
     
            if (ks.IsKeyDown(Keys.D))
                Rotation.Y += 0.05f;

            if (ks.IsKeyDown(Keys.W))
                Rotation.X += 0.05f;
            
            if (ks.IsKeyDown(Keys.S))
                Rotation.X -= 0.05f;

            _pos = Vector3.Transform(_pos - Ship_pos, Matrix.CreateRotationX(Rotation.X)*Matrix.CreateRotationY(Rotation.Y)) + Ship_pos;
            View = Matrix.CreateLookAt(_pos, Ship_pos, Vector3.Up);


        }

    }
}
