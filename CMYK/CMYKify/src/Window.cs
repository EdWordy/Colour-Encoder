using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Raylib_cs;
using Color = Raylib_cs.Color;
using CMYKify.OpenCV;

namespace CMYKify
{
    public class Window
    {
        // vars
        public int HEIGHT;
        public int WIDTH;

        // content
        public string msg = File.ReadAllText("E:\\Dev\\source\\repos\\csharp\\CMYK\\CMYKify\\resources\\file1.txt");
        public string msg2 = "hello";

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
                //Raylib.DrawText("0110100001100101011011000110110001101111", 10, 10, 24, Color.BLACK);
                //Raylib.DrawText(Cipher.BinaryToCMYK("0110100001100101011011000110110001101111", 2, true), 10, 30, 24, Color.BLACK);
                //Utils.DrawCMYKString(Cipher.TextToCMYK(msg2, 2, false), WIDTH);
                //Utils.DrawStringCMYK(Cipher.TextToCMYK(msg, 2, false), 30, 2, WIDTH, 10, 30);

                // rgb
                Utils.DrawStringRGB(Cipher.TextToRGB(msg, 2), 30, 2, WIDTH, 10, 30);

                // cleanup
                Raylib.EndDrawing();
            }

            string glob = "E:\\Dev\\source\\repos\\csharp\\CMYK\\CMYKify\\bin\\Debug\\net7.0\\";

            // save the image
            if (File.Exists("test.png") != true)
            {
                Raylib_cs.Image image = Raylib.LoadImageFromScreen();
                Raylib.ExportImage(image, "test.png");
            }

            // decode image
            string v = ImageDecoder.DecodeImage(glob + "test.png");

            // write to file
            File.WriteAllText(glob + "output.png", v);

            // cleanup 2
            Raylib.CloseWindow();
        }
    }
}
