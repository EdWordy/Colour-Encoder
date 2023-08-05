using Emgu.CV.Structure;
using Raylib_cs;
using Color = Raylib_cs.Color;
using Image = Raylib_cs.Image;

namespace CMYKify
{
    public class Window
    {
        public int HEIGHT;
        public int WIDTH;
        public string msg = File.ReadAllText("E:\\Dev\\source\\repos\\csharp\\CMYK\\CMYKify\\resources\\file1.txt");
        public string msg2 = "hello";

        public void Open()
        {
            Raylib.InitWindow(WIDTH, HEIGHT, "CMYKify");

            while (!Raylib.WindowShouldClose())
            {
                // setup
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);

                //Raylib.DrawText("0110100001100101011011000110110001101111", 10, 10, 24, Color.BLACK);
                //Raylib.DrawText(Cipher.BinaryToCMYK("0110100001100101011011000110110001101111", 2, true), 10, 30, 24, Color.BLACK);
                //Utils.DrawCMYKString(Cipher.TextToCMYK(msg2, 2, false), WIDTH);
                Utils.DrawStringCMYK(Cipher.TextToCMYK(msg, 2, false), 30, 2, WIDTH, 10, 30);  

                // cleanup
                Raylib.EndDrawing();
            }

            string glob = "E:\\Dev\\source\\repos\\csharp\\CMYK\\CMYKify\\bin\\Debug\\net7.0\\";

            // save the image
            if (File.Exists("test.png") != true)
            {
                Image image = Raylib.LoadImageFromScreen();
                Raylib.ExportImage(image, "test.png");
                // convert to bmp
                ImageHandler.SaveImageBMP(glob + "test.png", glob + "test.bmp");
            }

            // find the points
            MKeyPoint[] points = ImageUtils.FindPointsAndDraw(glob + "test.png");

            // cleanup 2
            Raylib.CloseWindow();
        }
    }
}
