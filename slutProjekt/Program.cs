using System;
using Raylib_cs;
namespace slutProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Testing");

           

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawRectangle(0,500,800,200, Color.BLUE);
                Raylib.EndDrawing();


            }

        }
    }
}
