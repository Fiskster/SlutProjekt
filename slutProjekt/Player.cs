using System;
using Raylib_cs;

namespace slutProjekt
{
    public class Player : GameObject
    {

        public KeyboardKey forwardKey;
        public KeyboardKey backKey;

        public Player()
        {
            x = 2f;
            y = 2f;
            gameObjects.Add(this);

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
        }

    }
}
