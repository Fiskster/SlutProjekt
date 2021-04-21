using System;
using Raylib_cs;

namespace slutProjekt
{
    public class Player : GameObject
    {

        public KeyboardKey forwardKey;
        public KeyboardKey backKey;


        public KeyboardKey jumpKey;

        public  float playerVelocity;

        public float gravity = 1;
        public Player(float x, float y, KeyboardKey forwardKey, KeyboardKey backKey , KeyboardKey jumpKey)
        {
           
            x = 2f;
            y = 2f;
            gameObjects.Add(this);
            playerVelocity = 0f; 
             

            this.forwardKey = forwardKey;
            this.backKey = backKey;
            this.jumpKey = jumpKey;


        }
        public override void Update()
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
            if (Raylib.IsKeyPressed(jumpKey) && y >= 100)
            {
                 playerVelocity = - 15; 
            }
           y += playerVelocity;
        }

    }
}
