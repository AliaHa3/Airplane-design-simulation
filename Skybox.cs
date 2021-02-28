using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Shaders
{


    public class Skybox
    {
        private Matrix World;

        public Model skyBox;


        private TextureCube skyBoxTexture;


        private Effect skyBoxEffect;


        private Vector3 size = new Vector3(700000,700000,700000);


        public Skybox(string skyboxTexture, ContentManager Content)
        {
            skyBox = Content.Load<Model>("SkyboxImages/cube");

            skyBoxTexture = Content.Load<TextureCube>(skyboxTexture);
            skyBoxEffect = Content.Load<Effect>("SkyboxShaders/Skybox");
        }

        
        public void Draw(Matrix view, Matrix projection, Vector3 Position)
        {
            // Go through each pass in the effect, but we know there is only one...
            foreach (EffectPass pass in skyBoxEffect.CurrentTechnique.Passes)
            {
                pass.Apply();

                // Draw all of the components of the mesh, but we know the cube really
                // only has one mesh
                foreach (ModelMesh mesh in skyBox.Meshes)
                {
                    // Assign the appropriate values to each of the parameters
                  
                    foreach (ModelMeshPart part in mesh.MeshParts)
                    {
                        part.Effect = skyBoxEffect;
                        part.Effect.Parameters["World"].SetValue(
                            Matrix.CreateScale(size)*Matrix.CreateTranslation(new Vector3(-512000,0,512000)));
                        part.Effect.Parameters["View"].SetValue(view);
                        part.Effect.Parameters["Projection"].SetValue(projection);
                        part.Effect.Parameters["SkyBoxTexture"].SetValue(skyBoxTexture);
                        part.Effect.Parameters["CameraPosition"].SetValue(Position);
                        
                        //part.Effect.Parameters["FogEnabled"].SetValue(true);
                        //part.Effect.Parameters["FogColor"].SetValue(Color.CornflowerBlue.ToVector3());
                        //part.Effect.Parameters["FogStart"].SetValue(9.75f);
                        //part.Effect.Parameters["FogEnd"].SetValue(10.25f);

                    }
                  

                    // Draw the mesh with the skybox effect
                    mesh.Draw();
                }
            }
        }
    }
}
