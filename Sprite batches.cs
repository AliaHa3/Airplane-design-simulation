using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Shaders;


namespace Physics_Project
{
    class Sprite_batches
    {
        private Texture2D Warning_texture;
        private Texture2D broken_texture;
        private Texture2D Cloud; 
        private float count;
        private float count2;
        private bool zero;
        private bool one;
        private bool zero1;
        private bool one1;
        private SpriteFont font;
        public Sprite_batches(ContentManager content)
        {
            Warning_texture = content.Load<Texture2D>("Warning");
            Cloud = content.Load<Texture2D>("white_fabric_texture");
            font = content.Load<SpriteFont>("SpriteFont1");
            broken_texture = content.Load<Texture2D>("Broken-Glass-psd41136");
            count = 0;
            count2 = 0;

        }

        public void Update(bool Warning,bool Speed_limite)
        {
            if (Speed_limite)
            {
                if (count2 <= 1.05f && count2 >= 0.95f)
                {
                    zero1 = false;
                    one1 = true;
                }
                else if (count2 <= 0.01f && count2 >= -0.01f)
                {
                    zero1 = true;
                    one1 = false;
                }
                if (zero1)
                    count2 += 0.02f;
                else if (one1)
                    count2 -= 0.02f;
            }
            else
                count2 = 0;


            if (Warning)
            {
                if (count <= 1.05f && count >= 0.95f)
                {
                    zero = false;
                    one = true;
                }
                else if (count <= 0.01f && count >= -0.01f)
                {
                    zero = true;
                    one = false;
                }
                if (zero)
                    count += 0.02f;
                else if (one)
                    count -= 0.02f;
            }
            else
                count = 0; 
        }

        public void Draw(SpriteBatch spriteBatch, bool Warning,bool Speed_limit,float altitude,Vector3 velocity)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Cloud, new Rectangle(0, 0, 280, 175), Color.Black*0.3f);
            spriteBatch.DrawString(font, "Altitude : " + altitude.ToString("0.00"), new Vector2(20, 20), Color.LightGray);
            spriteBatch.DrawString(font, "Velocity.X : " + velocity.X.ToString("0.00"), new Vector2(20, 50), Color.LightGray);
            spriteBatch.DrawString(font, "Velocity.Y : " + velocity.Y.ToString("0.00"), new Vector2(20, 80), Color.LightGray);
            spriteBatch.DrawString(font, "Velocity.Z : " + velocity.Z.ToString("0.00"), new Vector2(20, 110), Color.LightGray);
            if (Warning)
                spriteBatch.Draw(Warning_texture, new Rectangle(0, 0, 1000, 650), Color.Red*count);
            else
            {
                if (PLANE.crashed)
                {
                    spriteBatch.Draw(broken_texture, new Rectangle(0, 0, 1000, 650), Color.White);
                }
            }
            if(Speed_limit)
                spriteBatch.DrawString(font, "SPEED LIMIT REACHED !" , new Vector2(20, 140), Color.Red*count2 );
            spriteBatch.End();
        }
    }
}
