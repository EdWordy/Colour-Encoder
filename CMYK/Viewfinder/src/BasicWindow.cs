using Raylib_CsLo;
using System.ComponentModel;

namespace Viewfinder
{
    internal class BasicWindow
    {

        public static void OpenMainWindow(int width, int height)
        {
            // open window
            Raylib.InitWindow(width, height, "Viewfinder");
            // set fps
            Raylib.SetTargetFPS(60);

            RayGui.GuiLoadStyle("E:\\Dev\\source\\repos\\csharp\\CMYK\\Viewfinder\\resources\\styles\\Terminal.rgs");
            Texture tex = LoadTextures();

            // Main game loop
            while (!Raylib.WindowShouldClose()) // Detect window close button or ESC key
            {
                // setup
                Raylib.BeginDrawing();

                // setup 2
                Raylib.ClearBackground(Raylib.BLACK);
                Raylib.DrawFPS(10, 10);

                Raylib.DrawTexture(tex, width / 2 - tex.width / 2, height / 2 - tex.height / 2, Raylib.WHITE);

                // update
                Update();

                // draw
                DrawUI();

                // clean up
                Raylib.EndDrawing();
            }
            // close window
            Raylib.CloseWindow();
        }

        private static Texture LoadTextures()
        {
            Image image = Raylib.LoadImage("E:\\Dev\\source\\repos\\csharp\\CMYK\\Viewfinder\\resources\\test.png");          // Loaded in CPU memory (RAM)
            Texture texture = Raylib.LoadTextureFromImage(image);           // Image converted to texture, GPU memory (VRAM)
            Raylib.UnloadImage(image);                                      // can now be unloaded from RAM

            return texture;
        }

        private static void Update() // main game loop
        {
            // ...
        }

        private static void DrawUI() // Draw UI 
        {
           


        }
    }
}
