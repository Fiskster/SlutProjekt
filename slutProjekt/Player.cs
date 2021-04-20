using System;
using Raylib_cs;

namespace slutProjekt
{
    public class Player : GameObject
    {

        public KeyboardKey forwardKey;
        public KeyboardKey backKey;

        public KeyboardKey jumpKey;

        public  float playerSpeed;

        public Player(float x, float y, KeyboardKey forwardKey, KeyboardKey backKey , KeyboardKey jumpKey)
        {
            x = 2f;
            y = 2f;
            gameObjects.Add(this);
            playerSpeed = 5f; 
        }
        public void Update()
        {
            if (Raylib.IsKeyDown(forwardKey))
            {
                x += 3f;
            }
             if (Raylib.IsKeyDown(backKey))
            {
                x -= 3f;
            }
            if (Raylib.IsKeyPressed(jumpKey))
            {
                x = x + playerSpeed * Raylib.GetFrameTime();
            }
        }

    }
}
