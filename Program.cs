using System;
using Raylib_cs;

namespace proj1;

class Program
{
    static void Main(string[] args)
    {
        // Initialize window
        Raylib.InitWindow(800, 600, "2D Square Example");
        Raylib.SetTargetFPS(60);

        // Main game loop
        while (!Raylib.WindowShouldClose())
        {
            // Begin drawing
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            // Draw a square (rectangle with equal sides)
            Raylib.DrawRectangle(350, 250, 100, 100, Color.Red);

            // End drawing
            Raylib.EndDrawing();
        }

        // Clean up
        Raylib.CloseWindow();
    }
}
