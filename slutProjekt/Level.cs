using System;
using Raylib_cs;
using System.Collections.Generic;

namespace slutProjekt
{
    public class Level
    {
        static Queue<GameObject> tileQueue = new Queue<GameObject>();

        static public float tileX = 5f;

        static public float tileY = 5f;

        public Rectangle rect = new Rectangle();

        public Level()
        {
            this.rect.height = 50;
            this.rect.width = 100;
            this.rect.x = tileX;
            this.rect.y = tileY;
            

        }

        public static void Update()
        {
            if (tileQueue.Count <= 3)
            {
                // Console.WriteLine("working");
            }
            tileX -= 1f;
        }
        public void Draw()
        {
            foreach(GameObject tile in tileQueue)
            {

            }
        }


    }
}
