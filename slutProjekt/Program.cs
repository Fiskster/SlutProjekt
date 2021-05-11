using System;
using Raylib_cs;
namespace slutProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Testing");
            Raylib.InitAudioDevice();

             Player newPlayer = new Player(10, 300, KeyboardKey.KEY_A, KeyboardKey.KEY_D, KeyboardKey.KEY_SPACE);
             Tile tile = new Tile();
             Raylib.SetTargetFPS(60);
             Raylib.SetMasterVolume(0.3f);
             

            //  Level level = new Level();

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                
                  GameObject.UpdateAll();

                Raylib.ClearBackground(Color.WHITE);
                  GameObject.DrawAll();
                Raylib.EndDrawing();
                

            }

        }
    }
}
