using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


using Microsoft.Xna.Framework.Content;

namespace Physics_Project
{
    public class Body2DTilling : Body2D
    {
        public Body2DTilling(ContentManager content, Game1 G, string s, Matrix world, long rowTilling = 10, long colTilling = 10)
            : base(content, world, G, s)
        {

            Verts = new VertexPositionTexture[4];
            // Right Top
            Verts[0] = new VertexPositionTexture(new Vector3(-1, 1, 0), new Vector2(rowTilling, 0));
            // Left Top
            Verts[1] = new VertexPositionTexture(new Vector3(1, 1, 0), new Vector2(1, 0));
            // Right Bottom
            Verts[2] = new VertexPositionTexture(new Vector3(-1, -1, 0), new Vector2(rowTilling, colTilling));
            // Left Bottom
            Verts[3] = new VertexPositionTexture(new Vector3(1, -1, 0), new Vector2(1, colTilling));



        }

        public void Update(GameTime gameTime)
        {
            base.Update(gameTime);

        }

        public void Draw(GameTime gameTime, Camera camera, float alpha)
        {
            base.Draw(gameTime, camera, alpha);
        }
    }
}