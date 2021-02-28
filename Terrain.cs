using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Physics_Project
{

    class Terrain
    {
        private int terrainWidth = 100;
        private int terrainHeight = 100;
        private float[,] heightData;
        private Texture2D heightMap;
        private Texture2D grassTexture;
        List<VertexBuffer> myVertexBuffer;
        IndexBuffer myIndexBuffer;
        List<VertexPositionNormalTexture[]> list_vertices;
        int[] indices;
        private Effect effect;
        public Terrain(ContentManager content, GraphicsDevice device)
        {
            effect = content.Load<Effect>("effect");
            grassTexture = content.Load<Texture2D>("images");
            heightMap = content.Load<Texture2D>("Terrain3");
            LoadHeightData(heightMap);
            SetUpVertices();
            SetUpIndices();
            for (int i = 0; i < list_vertices.Count; i++)
                CalculateNormals(list_vertices[i]);
            myVertexBuffer = CopyToBuffers(list_vertices, device);
        }

        public void Draw(GameTime gameTime, GraphicsDeviceManager device, Camera camera)
        {







            effect.CurrentTechnique = effect.Techniques["Textured"];
            effect.Parameters["xTexture"].SetValue(grassTexture);


            effect.Parameters["xView"].SetValue(camera.View);
            effect.Parameters["xProjection"].SetValue(camera.Projection);
            effect.Parameters["xWorld"].SetValue(Matrix.Identity * Matrix.CreateScale(1000f, 1500f, 2000f));
            Vector3 lightDirection = new Vector3(1.0f, -1.0f, -1.0f);
            effect.Parameters["xEnableLighting"].SetValue(true);
            lightDirection.Normalize();
            effect.Parameters["xLightDirection"].SetValue(lightDirection);
            effect.Parameters["xAmbient"].SetValue(0.05f);


            foreach (EffectPass pass in effect.CurrentTechnique.Passes)
            {
                pass.Apply();
                for (int i = 0; i < list_vertices.Count; i++)
                {
                    device.GraphicsDevice.DrawUserIndexedPrimitives(PrimitiveType.TriangleList, list_vertices[i], 0,
                                                     list_vertices[i].Length, indices, 0, indices.Length / 3,
                                                     VertexPositionNormalTexture.VertexDeclaration);
                }

            }
        }
        private void LoadHeightData(Texture2D heightMap)
        {
            terrainWidth = heightMap.Width;
            terrainHeight = heightMap.Height;

            Color[] heightMapColors = new Color[terrainWidth * terrainHeight];
            heightMap.GetData(heightMapColors);

            heightData = new float[terrainWidth, terrainHeight];
            for (int x = 0; x < terrainWidth; x++)
                for (int y = 0; y < terrainHeight; y++)
                    heightData[x, y] = heightMapColors[x + y * terrainWidth].R / 5.0f;
        }

        private void SetUpVertices()
        {

            float minHeight = float.MaxValue;
            float maxHeight = float.MinValue;
            for (int x = 0; x < terrainWidth; x++)
            {
                for (int y = 0; y < terrainHeight; y++)
                {
                    if (heightData[x, y] < minHeight)
                        minHeight = heightData[x, y];
                    if (heightData[x, y] > maxHeight)
                        maxHeight = heightData[x, y];
                }
            }
            list_vertices = new List<VertexPositionNormalTexture[]>();
            for (int i = 0; i < 2; i++)
            {
                list_vertices.Add(new VertexPositionNormalTexture[terrainHeight * terrainWidth]);
            }

            for (int count_x = 0; count_x < 2; count_x++)
            {
                for (int x = terrainWidth * count_x; x < (terrainWidth) * (count_x + 1); x++)
                {
                    for (int count_y = 0; count_y < 1; count_y++)
                    {
                        for (int y = terrainHeight * count_y; y < (terrainHeight) * (count_y + 1); y++)
                        {
                            list_vertices[count_x + count_y * 2][(x - (terrainWidth * count_x)) + (y - (terrainHeight * count_y)) * terrainWidth].Position = new Vector3(-x, heightData[x - (terrainWidth * count_x), y - (terrainHeight * count_y)], y);
                            list_vertices[count_x + count_y * 2][(x - (terrainWidth * count_x)) + (y - (terrainHeight * count_y)) * terrainWidth].TextureCoordinate.X = (float)(x - (terrainWidth * count_x));
                            list_vertices[count_x + count_y * 2][(x - (terrainWidth * count_x)) + (y - (terrainHeight * count_y)) * terrainWidth].TextureCoordinate.Y = (float)(y - (terrainHeight * count_y));
                            //    if (heightData[x - (terrainWidth*count_x), y - (terrainHeight*count_y)] <
                            //        minHeight + (maxHeight - minHeight)/4)
                            //    {
                            //        list_vertices[count_x + count_y * 2][(x - (terrainWidth * count_x)) + (y - (terrainHeight * count_y)) * terrainWidth].TextureCoordinate.X = (float)(x - (terrainWidth * count_x));
                            //    }
                            //    else if (heightData[x - (terrainWidth*count_x), y - (terrainHeight*count_y)] <
                            //             minHeight + (maxHeight - minHeight)*2/4)
                            //        list_vertices[count_x + count_y*2].Color = Color.Green;
                            //    else if (heightData[x - (terrainWidth*count_x), y - (terrainHeight*count_y)] <
                            //             minHeight + (maxHeight - minHeight)*3/4)
                            //        list_vertices[count_x + count_y*2].Color = Color.Brown;
                            //    else
                            //        list_vertices[count_x + count_y*2].Color = Color.White;
                            //
                        }
                    }
                }
            }
            //for (int x = 0; x < terrainWidth; x++)
            //{
            //    for (int y = 0; y < terrainHeight; y++)
            //    {
            //        vertices[x + y * terrainWidth].Position = new Vector3(x, heightData[x, y], -y);
            //        vertices[x + y * terrainWidth].Color = Color.Beige;

            //    }
            //}
        }


        private void SetUpIndices()
        {
            indices = new int[(terrainWidth - 1) * (terrainHeight - 1) * 6];
            int counter = 0;
            for (int y = 0; y < terrainHeight - 1; y++)
            {
                for (int x = 0; x < terrainWidth - 1; x++)
                {
                    int lowerLeft = x + y * terrainWidth;
                    int lowerRight = (x + 1) + y * terrainWidth;
                    int topLeft = x + (y + 1) * terrainWidth;
                    int topRight = (x + 1) + (y + 1) * terrainWidth;

                    indices[counter++] = topLeft;
                    indices[counter++] = lowerRight;
                    indices[counter++] = lowerLeft;

                    indices[counter++] = topLeft;
                    indices[counter++] = topRight;
                    indices[counter++] = lowerRight;
                }
            }

        }
        private void CalculateNormals(VertexPositionNormalTexture[] vertices)
        {
            for (int i = 0; i < vertices.Length; i++)
                vertices[i].Normal = new Vector3(0, 0, 0);

            for (int i = 0; i < indices.Length / 3; i++)
            {
                int index1 = indices[i * 3];
                int index2 = indices[i * 3 + 1];
                int index3 = indices[i * 3 + 2];

                Vector3 side1 = vertices[index1].Position - vertices[index3].Position;
                Vector3 side2 = vertices[index1].Position - vertices[index2].Position;
                Vector3 normal = Vector3.Cross(side1, side2);

                vertices[index1].Normal += normal;
                vertices[index2].Normal += normal;
                vertices[index3].Normal += normal;
            }

            for (int i = 0; i < vertices.Length; i++)
                vertices[i].Normal.Normalize();
        }
        private List<VertexBuffer> CopyToBuffers(List<VertexPositionNormalTexture[]> vertices, GraphicsDevice device)
        {

            List<VertexBuffer> myVertexBuffer = new List<VertexBuffer>();
            for (int i = 0; i < vertices.Count; i++)
            {
                myVertexBuffer.Add(new VertexBuffer(device, VertexPositionNormalTexture.VertexDeclaration, vertices[i].Length, BufferUsage.WriteOnly));
                myVertexBuffer[i].SetData(vertices[i]);
            }



            myIndexBuffer = new IndexBuffer(device, typeof(int), indices.Length, BufferUsage.WriteOnly);
            myIndexBuffer.SetData(indices);
            return myVertexBuffer;
        }
    }
}
