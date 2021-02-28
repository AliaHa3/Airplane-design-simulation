using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Physics_Project.Parts;

namespace Physics_Project
{
    class PLANE
    {
        public static List<Wing> rightWings;
        public static List<Wing> leftWings;
        public static List<Engine> engines;
        public static Body body;
        public static Tail tail;

        public static Vector3 centerOfGravity = new Vector3(0, 0, 0); // relative to the PLANE itself .
        public static Vector3 acceleration = new Vector3(0, 0, 0);
        public static Vector3 angularAcceleration = new Vector3(0, 0, 0);
        public static Vector3 velocity = new Vector3(0, 0, 0); // initilize the x component, according 
        public static Vector3 angularVelocity = new Vector3(0, 0, 0);
        public static Vector3 position = new Vector3(-511500f, 2, 300000); // relative to the world .
        public static Vector3 rotation = new Vector3(0, 0, 0);
        public static Vector3 mileage = new Vector3(0, 0, 0);
        public static double weight;

        public static ContentManager contentmanager;

        public static bool adjustMode = false;
        public static bool doneEditing = true;
        public static Part movingPart = null;

        public static bool speedReached = false;
        public static bool showWarning = false;
        public static bool crashed = false;


        private static KeyboardState oldState = new KeyboardState();

        public PLANE(ContentManager content)
        {
            rightWings = new List<Wing>();
            leftWings = new List<Wing>();
            engines = new List<Engine>();
            tail = new Tail();
            body = new Body();

            contentmanager = content;
        }
        public void update()
        {


            ////update linear

            rightWings.ForEach(wing => wing.update());
            leftWings.ForEach(wing => wing.update());
            engines.ForEach(engine => engine.update());
            body.update();
            tail.update();

            if (PLANE.body.model != null && !adjustMode)
                Physics.Physics.calculateLinear();

            Physics.Physics.findCG();
            if (PLANE.position.Y == 110) centerOfGravity = PLANE.position;

            rightWings.ForEach(wing => wing.angularUpdate());
            leftWings.ForEach(wing => wing.angularUpdate());
            engines.ForEach(engine => engine.angularUpdate());
            body.angularUpdate();
            tail.angularUpdate();

            if (PLANE.body.model != null && !adjustMode)
                Physics.Physics.calculateRotational();

            if (!doneEditing) move();
        }

        public void draw(GameTime gameTime, Camera camera)
        {
            rightWings.ForEach(wing => wing.draw(gameTime, camera));
            leftWings.ForEach(wing => wing.draw(gameTime, camera));
            engines.ForEach(engine => engine.draw(gameTime, camera));
            body.draw(gameTime, camera);
            tail.draw(gameTime, camera);
        }

        public static void move()
        {
            KeyboardState newState = Keyboard.GetState();
            if (newState.IsKeyDown(Keys.NumPad8) && oldState.IsKeyUp(Keys.NumPad8)) PLANE.movingPart.offset.Z += 1.5f;
            if (newState.IsKeyDown(Keys.NumPad5) && oldState.IsKeyUp(Keys.NumPad5)) PLANE.movingPart.offset.Z -= 1.5f;
            if (newState.IsKeyDown(Keys.NumPad4) && oldState.IsKeyUp(Keys.NumPad4)) PLANE.movingPart.offset.X += 1.5f;
            if (newState.IsKeyDown(Keys.NumPad6) && oldState.IsKeyUp(Keys.NumPad6)) PLANE.movingPart.offset.X -= 1.5f;
            if (newState.IsKeyDown(Keys.NumPad9) && oldState.IsKeyUp(Keys.NumPad9)) PLANE.movingPart.offset.Y += 1.5f;
            if (newState.IsKeyDown(Keys.NumPad7) && oldState.IsKeyUp(Keys.NumPad7)) PLANE.movingPart.offset.Y -= 1.5f;
            oldState = newState;
        }
    }
}
