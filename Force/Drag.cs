using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Physics_Project.Physics
{
    class Drag : AeroForce
    {
        private Vector3 rotationInducedDrag;
        public Drag(double topArea, double frontArea, double sideArea)
        {
            this.topArea = topArea;
            this.frontArea = frontArea;
            this.sideArea = sideArea;
        }


        public override Vector3 calculate(Vector3 position, Vector3 rotation)
        {
            double density, cd;
            density = caluclateDensity(position.Y);
            cd = 1f * 0.5f * density;
            Vector3 frontAreaVector3 = new Vector3(0, 0, 1);
            frontAreaVector3 = Vector3.Transform(frontAreaVector3,
                Matrix.CreateRotationX(MathHelper.ToRadians(rotation.X)) *
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.Y)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Z)));
            frontAreaVector3 = new Vector3(Math.Abs(frontAreaVector3.X), Math.Abs(frontAreaVector3.Y),
                Math.Abs(frontAreaVector3.Z));
            Vector3 areaVector3 = new Vector3(0, 1, 0);
            areaVector3 = Vector3.Transform(areaVector3,
                Matrix.CreateRotationX(MathHelper.ToRadians(rotation.X)) *
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.Y)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Z)));
            areaVector3 = new Vector3(Math.Abs(areaVector3.X), Math.Abs(areaVector3.Y),
                Math.Abs(areaVector3.Z));
            Vector3 sideAreaVector3 = new Vector3(1, 0, 0);
            sideAreaVector3 = Vector3.Transform(sideAreaVector3,
                Matrix.CreateRotationX(MathHelper.ToRadians(rotation.X)) *
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.Y)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Z)));
            
            sideAreaVector3 = new Vector3(Math.Abs(sideAreaVector3.X), Math.Abs(sideAreaVector3.Y),
                Math.Abs(sideAreaVector3.Z));


            intensity.X = (float)(Math.Pow(PLANE.velocity.X, 2) * cd *
                                   (sideArea * sideAreaVector3.X + frontArea * frontAreaVector3.X + topArea * areaVector3.X));
            intensity.Y = (float)(Math.Pow(PLANE.velocity.Y, 2) * cd *
                                   (sideArea * sideAreaVector3.Y + frontArea * frontAreaVector3.Y + topArea * areaVector3.Y));
            intensity.Z = (float)(Math.Pow(PLANE.velocity.Z, 2) * cd *
                                   (sideArea * sideAreaVector3.Z + frontArea * frontAreaVector3.Z + topArea * areaVector3.Z));

            if (PLANE.velocity.X > 0) intensity.X *= -1;
            if (PLANE.velocity.Y > 0) intensity.Y *= -1;
            if (PLANE.velocity.Z > 0) intensity.Z *= -1;


            rotationInducedDrag = new Vector3();


            //Area According To X
            frontAreaVector3 = new Vector3(0, 0, 1);
            sideAreaVector3 = Vector3.Transform(sideAreaVector3,
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.Y)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Z)));
            areaVector3 = new Vector3(0, 1, 0);
            sideAreaVector3 = Vector3.Transform(sideAreaVector3,
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.Y)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Z)));
            sideAreaVector3 = new Vector3(1, 0, 0);
            sideAreaVector3 = Vector3.Transform(sideAreaVector3,
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.Y)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Z)));

            frontAreaVector3 = new Vector3(Math.Abs(frontAreaVector3.X), Math.Abs(frontAreaVector3.Y),
                Math.Abs(frontAreaVector3.Z));
            areaVector3 = new Vector3(Math.Abs(areaVector3.X), Math.Abs(areaVector3.Y),
                Math.Abs(areaVector3.Z));
            sideAreaVector3 = new Vector3(Math.Abs(sideAreaVector3.X), Math.Abs(sideAreaVector3.Y),
                Math.Abs(sideAreaVector3.Z));

            rotationInducedDrag.X = (float)(cd *
                                             (Math.Pow(PLANE.angularVelocity.X, 2) *
                                              (PLANE.angularVelocity.X > 0 ? -1 : 1) *
                                              (topArea * areaVector3.Y + frontArea * frontAreaVector3.Y +
                                               sideArea * sideAreaVector3.Y)));


            //Area According To Y
            frontAreaVector3 = new Vector3(0, 0, 1);
            sideAreaVector3 = Vector3.Transform(sideAreaVector3,
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.X)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Z)));
            areaVector3 = new Vector3(0, 1, 0);
            sideAreaVector3 = Vector3.Transform(sideAreaVector3,
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.X)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Z)));
            sideAreaVector3 = new Vector3(1, 0, 0);
            sideAreaVector3 = Vector3.Transform(sideAreaVector3,
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.X)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Z)));

            frontAreaVector3 = new Vector3(Math.Abs(frontAreaVector3.X), Math.Abs(frontAreaVector3.Y),
                Math.Abs(frontAreaVector3.Z));
            areaVector3 = new Vector3(Math.Abs(areaVector3.X), Math.Abs(areaVector3.Y),
                Math.Abs(areaVector3.Z));
            sideAreaVector3 = new Vector3(Math.Abs(sideAreaVector3.X), Math.Abs(sideAreaVector3.Y),
                Math.Abs(sideAreaVector3.Z));

            rotationInducedDrag.Y = (float)(cd *
                                             (Math.Pow(PLANE.angularVelocity.Y, 2) *
                                              (PLANE.angularVelocity.Y > 0 ? -1 : 1) *
                                              (topArea * areaVector3.Z + frontArea * frontAreaVector3.Z +
                                               sideArea * sideAreaVector3.Z)));




            //Area According To Z
            frontAreaVector3 = new Vector3(0, 0, 1);
            sideAreaVector3 = Vector3.Transform(sideAreaVector3,
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.X)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Y)));
            areaVector3 = new Vector3(0, 1, 0);
            sideAreaVector3 = Vector3.Transform(sideAreaVector3,
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.X)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Y)));
            sideAreaVector3 = new Vector3(1, 0, 0);
            sideAreaVector3 = Vector3.Transform(sideAreaVector3,
                Matrix.CreateRotationY(MathHelper.ToRadians(rotation.X)) *
                Matrix.CreateRotationZ(MathHelper.ToRadians(rotation.Y)));

            frontAreaVector3 = new Vector3(Math.Abs(frontAreaVector3.X), Math.Abs(frontAreaVector3.Y),
                Math.Abs(frontAreaVector3.Z));
            areaVector3 = new Vector3(Math.Abs(areaVector3.X), Math.Abs(areaVector3.Y),
                Math.Abs(areaVector3.Z));
            sideAreaVector3 = new Vector3(Math.Abs(sideAreaVector3.X), Math.Abs(sideAreaVector3.Y),
                Math.Abs(sideAreaVector3.Z));

            rotationInducedDrag.Z = (float)(cd *
                                             (Math.Pow(PLANE.angularVelocity.Z, 2) *
                                              (PLANE.angularVelocity.Z > 0 ? -1 : 1) *
                                              (topArea * areaVector3.Y + frontArea * frontAreaVector3.Y +
                                               sideArea * sideAreaVector3.Y)));



            return intensity;
        }

        public override Vector3 angularCalculate(Vector3 position, Vector3 angle)
        {
            momentumIntensity.X = (position.Y - PLANE.centerOfGravity.Y) * intensity.Z -
                                  (position.Z - PLANE.centerOfGravity.Z) * intensity.Y + rotationInducedDrag.X;
            momentumIntensity.Y = (position.Z - PLANE.centerOfGravity.Z) * intensity.X -
                                  (position.X - PLANE.centerOfGravity.X) * intensity.Z + rotationInducedDrag.Y;
            momentumIntensity.Z = (position.X - PLANE.centerOfGravity.X) * intensity.Y -
                                  (position.Y - PLANE.centerOfGravity.Y) * intensity.X + rotationInducedDrag.Z;
            return momentumIntensity;
        }
    }
}
