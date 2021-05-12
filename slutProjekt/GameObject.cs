using System;
using System.Collections.Generic;
using Raylib_cs;

namespace slutProjekt
{
    public abstract class GameObject
    {
        Texture2D texture;

        public static List<GameObject> gameObjects = new List<GameObject>();

        public float x;

        public Rectangle rect = new Rectangle();

        public float y;

        public GameObject()
        {
          x = rect.x;  
          y = rect.y;

        }

        public void LoadTexture(string txtFile)
        {

            texture = Raylib.LoadTexture(txtFile);
            rect.width = texture.width;
            rect.height = texture.height;
        }

        public abstract void Update();
        //abstract method to be overwritten
        public void Draw()
        {
            Raylib.DrawTexture(texture, (int) x, (int) y, Color.YELLOW);

        }




        public static void DrawAll()
        {
            foreach (GameObject p in gameObjects)
            {
                p.Draw();
            }
        }
        //drawAll and UpdateAll methods to reduce code in Main. 
          public static void UpdateAll()
        {
            foreach (GameObject p in gameObjects)
            {
                p.Update();
                

            }
        }
    }
}
