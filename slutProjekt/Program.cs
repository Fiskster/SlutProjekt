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

            while (!Raylib.WindowShouldClose())
            {
                  GameObject.UpdateAll();
                
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                  GameObject.DrawAll();
                Raylib.EndDrawing();


            }

        }
    }
}
