using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Physics_Project.Parts;
using Shaders;
using System.Drawing;
using ButtonState = Microsoft.Xna.Framework.Input.ButtonState;
using Color = Microsoft.Xna.Framework.Color;
using Keys = Microsoft.Xna.Framework.Input.Keys;
using Point = System.Drawing.Point;


namespace Physics_Project
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        private GraphicsDevice device;
        SpriteBatch spriteBatch;
        public static DebuggingForm debuggingForm = new DebuggingForm();
        public static KeyboardState oldState = new KeyboardState();
        Input_Form inputForm = new Input_Form();

        private Terrain terrain;
        private Body2DTilling floor;
        private Body2DTilling[] Clouds;

        private bool Switch_camera = false;
        public Center_camera camera;
        private Cinematic_camera cinematicCamera;
        private Camera bCamera;
        Skybox skybox;
        Matrix world = Matrix.Identity;
        private Matrix view;
        private Matrix projection;
        Vector3 cameraPosition;
        float angle = 0;
        private float distance = 20;

        private PLANE plane;

        private Sprite_batches spriteBatches; 
        /* 1-Fan
         * 2-Jet
         * 3-Rocket
         */
        public static float topAngularVelociy = 200f;

        public static float[] engine_masses = new[] { 1000f, 1800f, 2722f };

        public static float[] engine_force = new[] { 40323f, 91000f, 150000f };

        public static float[] engine_front_area = new[] { 1.24f * 1.24f, 1.26f * 1.26f, 1.3f * 1.3f };
        public static float[] engine_top_area = new[] { 2.6f * 2.6f, 5.16f * 5.16f, 16f };

        /* 1-A-10
         * 2-Cessna
         * 3-F-86 = Bleriot that's how i did it
         * 4-Spitfire
         * 5-X-15
         */
        public static float[] body_masses = new[] { 16000f, 500f, 1100f, 13000f };
        //THIS DOESNT MAKE SENSE !!!
        public static float[] body_top_area = new[] { 32f, 8f * 2, 9.12f * 2, 15.5f * 3.4f };
        public static float[] body_front_area = new[] { 2f*3.5f, 2f*2f, 3f*2f, 3f*3.4f };
        public static float[] body_side_area = new[] {3.5f*16, 2f*8f, 3f*9.12f, 3f*15.5f};

        public static float[] body_maximum_speed = new[] { 190f, 83f, 155f, 2020.5f };

        public static float[] body_maximum_altitude = new[] {14000f, 4500f, 10500f, 100000f};

        public static float[] wing_top_area = new[] { 48f, 16f, 14f, 23f, 18.5f };
        public static float[] wing_front_area = new[] { 12f*0.7f, 6.75f*0.7f, 6f*0.7f, 6.8f*0.7f, 4.3f*0.7f };
        public static float[] wing_side_area = new[] {4f*0.7f, 2.5f*0.7f, 2.3f*0.7f, 3.4f*0.7f, 4.3f*0.7f};

        // wings' masses are virtual and just for testing, no real values .
        public static float[] wing_masses = new[] { 2500f, 350f, 0f , 800f, 500f };

        /*
         * A10 body -> A10 wings [4.5] .
         * 
         */

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferWidth = 1000;
            graphics.PreferredBackBufferHeight = 650;
            graphics.ApplyChanges();
            //System.Windows.Forms.Form form = (System.Windows.Forms.Form)System.Windows.Forms.Control.FromHandle(this.Window.Handle);
            //form.StartPosition = FormStartPosition.WindowsDefaultLocation;
            this.IsMouseVisible = true;
            //form.Location = new Point(0, 0);
            base.Initialize();
        }

        protected override void LoadContent()
        {

            
            plane = new PLANE(Content);

            inputForm.Show();

            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            device = graphics.GraphicsDevice;
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();

            skybox = new Skybox("SkyboxImages/Texture3", Content);


            terrain = new Terrain(Content, device);
            camera = new Center_camera(this, PLANE.position);
            cinematicCamera = new Cinematic_camera(this, PLANE.position);

            floor = new Body2DTilling(Content, this, "Road3", Matrix.Identity
                  * Matrix.CreateScale(new Vector3(500, 512000, 1))
                  * Matrix.CreateRotationX(MathHelper.ToRadians(90))
                  * Matrix.CreateTranslation(new Vector3(-511500f, 0, 512000f)), 4, 10000);
            Clouds = new Body2DTilling[12];
            for (int i = 0; i < 12; i += 2)
            {
                Clouds[i] = new Body2DTilling(Content, this, "layer" + ((i) % 2).ToString(), Matrix.Identity
                    * Matrix.CreateScale(new Vector3(1024000, 1024000, 100))
                    * Matrix.CreateRotationX(MathHelper.ToRadians(90))
                    * Matrix.CreateTranslation(new Vector3(-511500f, 3000 * (i + 1), 1024000f)), 20, 20);
                Clouds[i + 1] = new Body2DTilling(Content, this, "layer" + ((i + 1) % 2).ToString(), Matrix.Identity
                  * Matrix.CreateScale(new Vector3(1024000, 1024000, 100))
                  * Matrix.CreateRotationX(MathHelper.ToRadians(90))
                  * Matrix.CreateTranslation(new Vector3(-511500f, 3000 * (i + 1), 1024000f)), 20, 20);

            }
            spriteBatches = new Sprite_batches(Content);
            //Engines Load
            //0-Fan Turbine (A10)
            //1-Jet Turbine
            //2-Rocket Turbine
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }


        protected override void Update(GameTime gameTime)
        {
            if (!debuggingForm.flag && gameTime.TotalGameTime.Milliseconds % 1000 == 0) debuggingForm.update();


            if (!PLANE.crashed)
            {
                plane.update();
                if (!Switch_camera)
                {
                    camera.Update(PLANE.position);
                    bCamera = camera;
                }

                else
                {
                    cinematicCamera.Update(PLANE.position);
                    bCamera = cinematicCamera;
                }
            }



            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Space) && oldState.IsKeyUp(Keys.Space))
                Switch_camera = !Switch_camera;
            oldState = keyboardState;

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            floor.Update(gameTime);
            for (int i = 0; i < 12; i++)
            {
                Clouds[i].Update(gameTime);
            }
            spriteBatches.Update(PLANE.showWarning,PLANE.speedReached);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear((Color.Azure));



            plane.draw(gameTime, bCamera);

            var originalCullState = graphics.GraphicsDevice.RasterizerState;
            graphics.GraphicsDevice.RasterizerState = RasterizerState.CullNone;

            var originalBlendState = graphics.GraphicsDevice.BlendState;
            graphics.GraphicsDevice.BlendState = BlendState.AlphaBlend;

            var originalDepthStencilState = graphics.GraphicsDevice.DepthStencilState;
            var originalSamplerStates = graphics.GraphicsDevice.SamplerStates[0];
            if (!PLANE.adjustMode)
            {
                skybox.Draw(bCamera.View, bCamera.Projection, PLANE.position);
                terrain.Draw(gameTime, graphics, bCamera);
                floor.Draw(gameTime, bCamera, 1f);
                for (int i = 0; i < 12; i++)
                {
                    Clouds[i].Draw(gameTime, bCamera, 0.7f);
                }
            }

            if (!PLANE.adjustMode)
            {
                graphics.GraphicsDevice.BlendState = originalBlendState;
                graphics.GraphicsDevice.RasterizerState = originalCullState;
                spriteBatches.Draw(spriteBatch, PLANE.showWarning, PLANE.speedReached, PLANE.position.Y - 2,
                    PLANE.velocity);
                graphics.GraphicsDevice.DepthStencilState = originalDepthStencilState;
                graphics.GraphicsDevice.SamplerStates[0] = originalSamplerStates;
            }
            base.Draw(gameTime);
        }
    }
}
