using System;
using Raylib_cs;

namespace slutProjekt
{
    public class Player : GameObject
    {
        
        public KeyboardKey forwardKey;
        public KeyboardKey backKey;

           Sound jump = Raylib.LoadSound(@"boink.mp3");
           

        public KeyboardKey jumpKey;

        public  float playerVelocity;

        private float gravity = 1;
        //give player input keys and values.
        public Player(float x, float y, KeyboardKey forwardKey, KeyboardKey backKey , KeyboardKey jumpKey)
        {
            LoadTexture(@"whip.png");
            Raylib.SetSoundVolume(jump, 0.5f);
            x = 2f;
            y = 2f;
            gameObjects.Add(this);
            playerVelocity = 0f; 
             

            this.forwardKey = forwardKey;
            this.backKey = backKey;
            this.jumpKey = jumpKey;


        }
        //Using get gravity so it is constant and not able to be changed.
        public float getGravity()
        {
            return gravity; 
        }
        //using sealed method here so Tile.update Appends to this method. Seems to be working ¯\_(ツ)_/¯
        public sealed override void Update()
        {
           playerVelocity += gravity;
           
            if (Raylib.IsKeyDown(forwardKey))
            {
                x -= 3f;
            }
             if (Raylib.IsKeyDown(backKey))
            {
                x += 3f;
            }
            if (y > 100)
            {
                playerVelocity = 0; 
            }
            if (Raylib.IsKeyPressed(jumpKey) && y >= 100) //jump method and groundcheck 
            {
                 playerVelocity = - 15; 
                 Raylib.PlaySound(jump);
            }
           y += playerVelocity;
        }

    }
}
