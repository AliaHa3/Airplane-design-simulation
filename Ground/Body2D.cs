using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


using Microsoft.Xna.Framework.Content;
namespace Physics_Project
{
    public class Body2D
    {
        public Texture2D _texture;
        public VertexPositionTexture[] Verts;
        public Matrix World;
        public Vector3 Angle;
        public BasicEffect _basicEffect;
        public Game1 CGame1;

        public Body2D(ContentManager content, Game1 G, string s)
        {
            InitParams(content, G, s);
            CGame1 = G;
        }

        public Body2D(ContentManager content, Matrix world, Game1 G, string s)
        {
            this.InitParams(content, G, s);
            this.World = world;
            CGame1 = G;
        }



        private void InitParams(ContentManager content, Game1 G, string s)
        {
            this._basicEffect = new BasicEffect(G.GraphicsDevice);
            this.World = Matrix.Identity;
            this._texture = content.Load<Texture2D>(s);

            Verts = new VertexPositionTexture[4];
            // Right Top
            Verts[0] = new VertexPositionTexture(
                new Vector3(-1, 1, 0), new Vector2(0, 0));
            // Left Top
            Verts[1] = new VertexPositionTexture(
                new Vector3(1, 1, 0), new Vector2(1, 0));
            // Right Bottom
            Verts[2] = new VertexPositionTexture(
                new Vector3(-1, -1, 0), new Vector2(0, 1));
            // Left Bottom
            Verts[3] = new VertexPositionTexture(
                new Vector3(1, -1, 0), new Vector2(1, 1));

            Angle = new Vector3(0, 50, 0);
        }

        public void Update(GameTime gameTime)
        {


        }

        public void Draw(GameTime gameTime, Camera camera, float alpha)
        {
            var graphicsDevice = CGame1.GraphicsDevice;




            //_basicEffect.FogEnabled = true;
            //_basicEffect.FogColor = Color.WhiteSmoke.ToVector3();
            //_basicEffect.FogStart = 300f;
            //_basicEffect.FogEnd = 200000f;


            _basicEffect.View = camera.View;
            _basicEffect.Projection = camera.Projection;
            _basicEffect.Texture = this._texture;
            _basicEffect.TextureEnabled = true;
            _basicEffect.World = World;
            _basicEffect.Alpha = alpha;

            //var originalCullState = graphicsDevice.RasterizerState;
            //graphicsDevice.RasterizerState = RasterizerState.CullNone;

            //var originalBlendState = graphicsDevice.BlendState;
            //graphicsDevice.BlendState = BlendState.AlphaBlend;

            foreach (EffectPass pass in _basicEffect.CurrentTechnique.Passes)
            {
                pass.Apply();
                graphicsDevice.DrawUserPrimitives<VertexPositionTexture>
                        (PrimitiveType.TriangleStrip, Verts, 0, 2);
            }

            //Go back to original GraphicsDevice state
            //graphicsDevice.BlendState = originalBlendState;
            //graphicsDevice.RasterizerState = originalCullState;
        }
    }
}
