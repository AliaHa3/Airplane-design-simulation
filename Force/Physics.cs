using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Physics_Project.Parts;

namespace Physics_Project.Physics
{
    static class Physics
    {
        private static double topSpeed = 0;
        private static bool tookOff = false;

        public static void findCG()
        {
            Vector3 center = new Vector3(0, 0, 0);
            PLANE.weight = PLANE.body.weight;



            foreach (Part part in PLANE.rightWings)
            {
                center.X = (float)((float)((center.X * PLANE.weight) + (part.modifiedOffset.X * part.weight)) /
                                               (PLANE.weight + part.weight));
                center.Y = (float)((float)((center.Y * PLANE.weight) + (part.modifiedOffset.Y * part.weight)) /
                                                   (PLANE.weight + part.weight));
                center.Z = (float)((float)((center.Z * PLANE.weight) + (part.modifiedOffset.Z * part.weight)) /
                                                   (PLANE.weight + part.weight));
                PLANE.weight += part.weight;
            }
            foreach (Part part in PLANE.leftWings)
            {
                center.X = (float)((float)((center.X * PLANE.weight) + (part.modifiedOffset.X * part.weight)) /
                                               (PLANE.weight + part.weight));
                center.Y = (float)((float)((center.Y * PLANE.weight) + (part.modifiedOffset.Y * part.weight)) /
                                                   (PLANE.weight + part.weight));
                center.Z = (float)((float)((center.Z * PLANE.weight) + (part.modifiedOffset.Z * part.weight)) /
                                                   (PLANE.weight + part.weight));
                PLANE.weight += part.weight;
            }
            foreach (Part part in PLANE.engines)
            {
                center.X = (float)((float)((center.X * PLANE.weight) + (part.modifiedOffset.X * part.weight)) /
                                               (PLANE.weight + part.weight));
                center.Y = (float)((float)((center.Y * PLANE.weight) + (part.modifiedOffset.Y * part.weight)) /
                                                   (PLANE.weight + part.weight));
                center.Z = (float)((float)((center.Z * PLANE.weight) + (part.modifiedOffset.Z * part.weight)) /
                                                   (PLANE.weight + part.weight));
                PLANE.weight += part.weight;
            }
            if (PLANE.tail.model != null)
            {
                Part part = PLANE.tail;
                center.X = (float)((float)((center.X * PLANE.weight) + (part.modifiedOffset.X * part.weight)) /
                                               (PLANE.weight + part.weight));
                center.Y = (float)((float)((center.Y * PLANE.weight) + (part.modifiedOffset.Y * part.weight)) /
                                                   (PLANE.weight + part.weight));
                center.Z = (float)((float)((center.Z * PLANE.weight) + (part.modifiedOffset.Z * part.weight)) /
                                                   (PLANE.weight + part.weight));
                PLANE.weight += part.weight;
            }
            PLANE.centerOfGravity = center + PLANE.position;
        }
        
        public static void calculateLinear()
        {

            double xForceComponent = 0, yForceComponent = 0, zForceComponent = 0,
                   time = 1.0f / 60.0f;

            int forcesCount = 0;
            int partsCount = PLANE.rightWings.Count;
            topSpeed = Game1.body_maximum_speed[Body.bodyIndex];

            for (int i = 0; i < partsCount; i++)
            {
                forcesCount = PLANE.rightWings[i].forces.Count;

                for (int j = 0; j < forcesCount; j++)
                {
                    xForceComponent += PLANE.rightWings[i].forces[j].intensity.X;
                    yForceComponent += PLANE.rightWings[i].forces[j].intensity.Y;
                    zForceComponent += PLANE.rightWings[i].forces[j].intensity.Z;
                }
            }

            partsCount = PLANE.leftWings.Count;

            for (int i = 0; i < partsCount; i++)
            {
                forcesCount = PLANE.leftWings[i].forces.Count;

                for (int j = 0; j < forcesCount; j++)
                {
                    xForceComponent += PLANE.leftWings[i].forces[j].intensity.X;
                    yForceComponent += PLANE.leftWings[i].forces[j].intensity.Y;
                    zForceComponent += PLANE.leftWings[i].forces[j].intensity.Z;
                }
            }

            partsCount = PLANE.engines.Count;
            for (int i = 0; i < partsCount; i++)
            {
                forcesCount = PLANE.engines[i].forces.Count;

                for (int j = 0; j < forcesCount; j++)
                {
                    xForceComponent += PLANE.engines[i].forces[j].intensity.X;
                    yForceComponent += PLANE.engines[i].forces[j].intensity.Y;
                    zForceComponent += PLANE.engines[i].forces[j].intensity.Z;
                }
            }

            forcesCount = PLANE.body.forces.Count;

            for (int j = 0; j < forcesCount; j++)
            {

                xForceComponent += PLANE.body.forces[j].intensity.X;
                yForceComponent += PLANE.body.forces[j].intensity.Y;
                zForceComponent += PLANE.body.forces[j].intensity.Z;
            }

            forcesCount = 0;

            for (int j = 0; j < forcesCount; j++)
            {
                xForceComponent += PLANE.tail.forces[j].intensity.X;
                yForceComponent += PLANE.tail.forces[j].intensity.Y;
                zForceComponent += PLANE.tail.forces[j].intensity.Z;
            }

            /* sigma(forces) = mass * acceleration .
             * acceleration = segma(forces) / mass .
             * Time = update time = 1.0f/60.0f .
             * 
             * velocity = acceleration * time + initial velocity .
             * Distance = 1/2 * acceleration * time^2 + initial velocity * time +  initial distance .
            */

            PLANE.acceleration.X = (float)(xForceComponent / PLANE.weight);
            PLANE.acceleration.Y = (float)(yForceComponent / PLANE.weight);
            PLANE.acceleration.Z = (float)(zForceComponent / PLANE.weight);

            PLANE.mileage.X = (float)((1.0f / 2.0f) * PLANE.acceleration.X * (time * time) + PLANE.velocity.X * time);
            PLANE.mileage.Y = (float)((1.0f / 2.0f) * PLANE.acceleration.Y * (time * time) + PLANE.velocity.Y * time);
            PLANE.mileage.Z = (float)((1.0f / 2.0f) * PLANE.acceleration.Z * (time * time) + PLANE.velocity.Z * time);

            PLANE.position.X += PLANE.mileage.X;
            PLANE.position.Y += PLANE.mileage.Y;
            PLANE.position.Z += PLANE.mileage.Z;

            PLANE.velocity.X += (float)(PLANE.acceleration.X * time);
            PLANE.velocity.Y += (float)(PLANE.acceleration.Y * time);
            PLANE.velocity.Z += (float)(PLANE.acceleration.Z * time);

            if (PLANE.velocity.X > topSpeed) { PLANE.velocity.X = (float)topSpeed; PLANE.speedReached = true; }
            if (PLANE.velocity.Y > topSpeed) { PLANE.speedReached = true; PLANE.velocity.Y = (float)topSpeed; }
            if (PLANE.velocity.Z > topSpeed) { PLANE.speedReached = true; PLANE.velocity.Z = (float)topSpeed; }

            if (PLANE.velocity.X < (-topSpeed)) { PLANE.speedReached = true; PLANE.velocity.X = (float)-topSpeed; }
            if (PLANE.velocity.Y < (-topSpeed)) { PLANE.speedReached = true; PLANE.velocity.Y = (float)-topSpeed; }
            if (PLANE.velocity.Z < (-topSpeed)) { PLANE.speedReached = true; PLANE.velocity.Z = (float)-topSpeed; }

            if (PLANE.position.Y > 177)
            {
                tookOff = true; 
            }
            PLANE.showWarning = false;
            if (tookOff && PLANE.position.Y < 177)
            {
                PLANE.showWarning = true;
            }

            

            if (PLANE.position.Y < 2)
            {
                PLANE.velocity.Y = 0;
                PLANE.position.Y = 2;
            }
            if (tookOff && PLANE.position.Y == 2)
            {
                PLANE.showWarning = false;
                PLANE.crashed = true;
                PLANE.velocity = Vector3.Zero;
            }

        }

        public static void calculateRotational()
        {
            double xMomentComponent = 0, yMomentComponent = 0, zMomentComponent = 0, time = 1.0f / 60.0f;

            int forcesCount = 0;
            int partsCount = PLANE.rightWings.Count;

            for (int i = 0; i < partsCount; i++)
            {
                forcesCount = PLANE.rightWings[i].forces.Count;

                for (int j = 0; j < forcesCount; j++)
                {
                    xMomentComponent += PLANE.rightWings[i].forces[j].momentumIntensity.X;
                    yMomentComponent += PLANE.rightWings[i].forces[j].momentumIntensity.Y;
                    zMomentComponent += PLANE.rightWings[i].forces[j].momentumIntensity.Z;
                }
            }

            partsCount = PLANE.leftWings.Count;

            for (int i = 0; i < partsCount; i++)
            {
                forcesCount = PLANE.leftWings[i].forces.Count;

                for (int j = 0; j < forcesCount; j++)
                {
                    xMomentComponent += PLANE.leftWings[i].forces[j].momentumIntensity.X;
                    yMomentComponent += PLANE.leftWings[i].forces[j].momentumIntensity.Y;
                    zMomentComponent += PLANE.leftWings[i].forces[j].momentumIntensity.Z;
                }
            }

            partsCount = PLANE.engines.Count;
            for (int i = 0; i < partsCount; i++)
            {
                forcesCount = PLANE.engines[i].forces.Count;

                for (int j = 0; j < forcesCount; j++)
                {
                    xMomentComponent += PLANE.engines[i].forces[j].momentumIntensity.X;
                    yMomentComponent += PLANE.engines[i].forces[j].momentumIntensity.Y;
                    zMomentComponent += PLANE.engines[i].forces[j].momentumIntensity.Z;
                }
            }

            forcesCount = PLANE.body.forces.Count;

            for (int j = 0; j < forcesCount; j++)
            {
                xMomentComponent += PLANE.body.forces[j].momentumIntensity.X;
                yMomentComponent += PLANE.body.forces[j].momentumIntensity.Y;
                zMomentComponent += PLANE.body.forces[j].momentumIntensity.Z;
            }

            forcesCount = 0;

            for (int j = 0; j < forcesCount; j++)
            {
                xMomentComponent += PLANE.tail.forces[j].momentumIntensity.X;
                yMomentComponent += PLANE.tail.forces[j].momentumIntensity.Y;
                zMomentComponent += PLANE.tail.forces[j].momentumIntensity.Z;
            }

            PLANE.angularAcceleration.X = (float)(xMomentComponent / PLANE.weight);
            PLANE.angularAcceleration.Y = (float)(yMomentComponent / PLANE.weight);
            PLANE.angularAcceleration.Z = (float)(zMomentComponent / PLANE.weight);

            PLANE.angularVelocity.X += (float)(PLANE.angularAcceleration.X * time);
            PLANE.angularVelocity.Y += (float)(PLANE.angularAcceleration.Y * time);
            PLANE.angularVelocity.Z += (float)(PLANE.angularAcceleration.Z * time);

            PLANE.rotation.X += (float)((1.0f / 2.0f) * PLANE.angularAcceleration.X * (time * time) + PLANE.angularVelocity.X * time);
            PLANE.rotation.Y += (float)((1.0f / 2.0f) * PLANE.angularAcceleration.Y * (time * time) + PLANE.angularVelocity.Y * time);
            PLANE.rotation.Z += (float)((1.0f / 2.0f) * PLANE.angularAcceleration.Z * (time * time) + PLANE.angularVelocity.Z * time);

            #region crashing/warning

            if (PLANE.angularVelocity.X > Game1.topAngularVelociy) PLANE.showWarning = true;
            if (PLANE.angularVelocity.Y > Game1.topAngularVelociy) PLANE.showWarning = true;
            if (PLANE.angularVelocity.Z > Game1.topAngularVelociy) PLANE.showWarning = true;

            if (PLANE.angularVelocity.X < (-Game1.topAngularVelociy)) PLANE.showWarning = true;
            if (PLANE.angularVelocity.Y < (-Game1.topAngularVelociy)) PLANE.showWarning = true;
            if (PLANE.angularVelocity.Z < (-Game1.topAngularVelociy)) PLANE.showWarning = true;

            if (PLANE.angularVelocity.X > Game1.topAngularVelociy + 50)
            {
                PLANE.showWarning = false; PLANE.crashed = true; 
            }
            if (PLANE.angularVelocity.Y > Game1.topAngularVelociy + 50)
            {
                PLANE.showWarning = false; PLANE.crashed = true;
            }
            if (PLANE.angularVelocity.Z > Game1.topAngularVelociy + 50)
            {
                PLANE.showWarning = false; PLANE.crashed = true;
            }

            if (PLANE.angularVelocity.X < (-Game1.topAngularVelociy) - 50)
            {
                PLANE.showWarning = false; PLANE.crashed = true;
            }
            if (PLANE.angularVelocity.Y < (-Game1.topAngularVelociy) - 50)
            {
                PLANE.showWarning = false; PLANE.crashed = true;
            }
            if (PLANE.angularVelocity.Z < (-Game1.topAngularVelociy) - 50)
            {
                PLANE.showWarning = false; PLANE.crashed = true;
            }

            #endregion 

        }
    }
}
