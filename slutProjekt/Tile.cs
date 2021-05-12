using System;
using Raylib_cs;
using System.Collections.Generic;

namespace slutProjekt
{
    public class Tile : GameObject
    {

        static List<Rectangle> tileList = new List<Rectangle>();
        //list for all tiles.
        // Rectangle r2 = new Rectangle();
        //test
        public Tile()
        {
            this.rect.height = 50;
            this.rect.width = 800;
            this.rect.x = 100;
            this.rect.y = 420;

                gameObjects.Add(this);

            tileList.Add(rect);
           // tileList.Add(r2);
            //test 
        }

        public void spawn()
        {

            tileList.Add(rect);
        }
        //tile update method to override abstract method
        public override void Update()
        {
            foreach (Rectangle tile in tileList)
            {
             Raylib.DrawRectangleRec(rect,Color.BLUE);

            }
            rect.x -= 2f;
            if(rect.x  == 0 - 500)
            {
                
                     Console.WriteLine("ÅHHHHHHHHHHHHHH");
                spawn();
                
               //when tile reach destination, spawn new tile.
             
            }            

        }



    }
}
