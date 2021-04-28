using System;
using Raylib_cs;
namespace slutProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Testing");

             Player newPlayer = new Player(10, 300, KeyboardKey.KEY_A, KeyboardKey.KEY_D, KeyboardKey.KEY_SPACE);
             Raylib.SetTargetFPS(60);
            //  Level level = new Level();

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                  GameObject.UpdateAll();
                // Level.Update();
                // level.Draw();
                
                Raylib.ClearBackground(Color.WHITE);
                  GameObject.DrawAll();
                Raylib.EndDrawing();
                

            }

        }
    }
}
