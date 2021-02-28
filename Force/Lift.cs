using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Physics_Project.Physics
{
    class Lift : AeroForce
    {
        public Lift(double topArea)
        {
            this.topArea = topArea;
        }

        
        public override Vector3 calculate(Vector3 position, Vector3 rotation)
        {
            double density, lift, CL, angleOfRotation = Input_Form.chosenAngle;
            Vector3 velocityDirection = new Vector3(0,0,1);
            Vector3 angularVelocityDirection  = new Vector3(0,1,0);

            velocityDirection = Vector3.Transform(velocityDirection,
                Matrix.CreateRotationX(MathHelper.ToRadians(rotation.X)) *
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.Y)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Z)));

            angularVelocityDirection = Vector3.Transform(angularVelocityDirection,
                Matrix.CreateRotationX(MathHelper.ToRadians(rotation.X)) *
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.Y)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Z)));

            density = caluclateDensity(position.Y);
            CL = (2 * Math.PI * MathHelper.ToRadians((float)angleOfRotation)) / (1 + (2 / topArea));
            forceValue = 0.5*CL*density*topArea*
                         (Math.Pow(PLANE.velocity.X*velocityDirection.X, 2) +
                          Math.Pow(PLANE.velocity.Y*velocityDirection.Y, 2) +
                          Math.Pow(PLANE.velocity.Z*velocityDirection.Z, 2)) + (
                              Math.Pow(PLANE.angularVelocity.X*angularVelocityDirection.X, 2) +
                              Math.Pow(PLANE.angularVelocity.Y*angularVelocityDirection.Y, 2) +
                              Math.Pow(PLANE.angularVelocity.Z*angularVelocityDirection.Z, 2));

            intensity = new Vector3(0,(float) forceValue,0);
            intensity = Vector3.Transform(intensity,
                Matrix.CreateRotationX(MathHelper.ToRadians(rotation.X))*
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.Y))*
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Z)));
            

            

            return intensity;
        }

        public override Vector3 angularCalculate(Vector3 position, Vector3 angle)
        {
            momentumIntensity.X = (position.Y - PLANE.centerOfGravity.Y) * intensity.Z -
                               (position.Z - PLANE.centerOfGravity.Z) * intensity.Y;
            momentumIntensity.Y = (position.Z - PLANE.centerOfGravity.Z) * intensity.X -
                               (position.X - PLANE.centerOfGravity.X) * intensity.Z;
            momentumIntensity.Z = (position.X - PLANE.centerOfGravity.X) * intensity.Y -
                               (position.Y - PLANE.centerOfGravity.Y) * intensity.X;
            return momentumIntensity;

        }
    }
}
