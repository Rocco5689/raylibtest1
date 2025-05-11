using Raylib_cs;

class Program
{
    static void Main()
    {
        // Initialize window
        Raylib.InitWindow(800, 600, "2D Square Movement Example");
        Raylib.SetTargetFPS(60);

        // Square properties
        float squareX = 350f; // Starting X position
        float squareY = 250f; // Starting Y position
        float squareSize = 30f; // Square size
        float moveSpeed = 5f; // Pixels per frame

        // Main game loop
        while (!Raylib.WindowShouldClose())
        {
            // Update: Handle arrow key input
            if (Raylib.IsKeyDown(KeyboardKey.Right))
                squareX += moveSpeed;
            if (Raylib.IsKeyDown(KeyboardKey.Left))
                squareX -= moveSpeed;
            if (Raylib.IsKeyDown(KeyboardKey.Up))
                squareY -= moveSpeed;
            if (Raylib.IsKeyDown(KeyboardKey.Down))
                squareY += moveSpeed;

            // Begin drawing
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Black);

            // Draw the square at its current position
            Raylib.DrawRectangle((int)squareX, (int)squareY, (int)squareSize, (int)squareSize, Color.White);

            // End drawing
            Raylib.EndDrawing();
        }

        // Clean up
        Raylib.CloseWindow();
    }
}