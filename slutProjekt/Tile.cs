using System;
using Raylib_cs;
using System.Collections.Generic;

namespace slutProjekt
{
    public class Tile : GameObject
    {

        static List<GameObject> tileList = new List<GameObject>();


        public Tile()
        {
            this.rect.height = 50;
            this.rect.width = 500;
            this.rect.x = 500;
            this.rect.y = 420;
            gameObjects.Add(this);
                 tileList.Add(this);

        }

        public void spawn()
        {
             tileList.Clear();
            gameObjects.Add(this);

              tileList.Add(this);
        }

        public override void Update()
        {
            foreach (Tile tile in tileList)
            {
             Raylib.DrawRectangleRec(rect,Color.BLUE);

            }
            rect.x -= 2f;
            if(rect.x  <= 0 - 500)
            {
                Console.WriteLine("ÅHHHHHHHHHHHHHH");
                spawn();
             
            }            

        }



    }
}
