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

        public float y;

        public GameObject()
        {
            var bruh = Raylib.LoadImage(@"C:\Users\axel.lilja2\Documents\PROG02\SlutProjekt\slutProjekt\bin\Debug\netcoreapp3.1\whip.png");
            texture = Raylib.LoadTextureFromImage(bruh);
        }

        public abstract void Update();

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
          public static void UpdateAll()
        {
            foreach (GameObject p in gameObjects)
            {
                p.Update();
            }
        }
    }
}
