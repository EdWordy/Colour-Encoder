using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Raylib_cs;
using Color = Raylib_cs.Color;

namespace CMYKify
{
    public class Window
    {
        // vars
        public int HEIGHT;
        public int WIDTH;

        // content
        public string msg = File.ReadAllText("E:\\Dev\\source\\repos\\csharp\\CMYK\\CMYKify\\resources\\input.txt");

        // funcs

        public void Open()
        {
            Raylib.InitWindow(WIDTH, HEIGHT, "CMYKify");

            while (!Raylib.WindowShouldClose())
            {
                // setup
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);

                // cmyk
                //Utils.DrawStringCMYK(ImageEncoder.TextToCMYK(msg, 2, false), 30, 2, WIDTH, 10, 30);

                // rgb
                Utils.DrawStringRGB(ImageEncoder.TextToRGB(msg, 2), 30, 2, WIDTH, 5, 30); // 5 interval = 10 and 30 margins; 10 interval = 20 and 30 margins

                // cleanup
                Raylib.EndDrawing();
            }

            string glob = "E:\\Dev\\source\\repos\\csharp\\CMYK\\CMYKify\\resources\\";

            // save the image
            if (File.Exists(glob + "test.png") != true)
            {
                Raylib_cs.Image image = Raylib.LoadImageFromScreen();
                Raylib.ExportImage(image, glob + "test.png");
            }

            // decode image
            string v = ImageDecoder.DecodeImage(glob + "test.png");

            // write to file
            File.WriteAllText(glob + "output.txt", v);

            // final cleanip
            Raylib.CloseWindow();
        }
    }
}
