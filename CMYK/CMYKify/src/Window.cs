using Emgu.CV;
using Emgu.CV.CvEnum;
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
                //Utils.DrawStringRGB(Cipher.BinaryToRGB("0110100001100101011011000110110001101111", 2), 30, 2, WIDTH, 10, 30);
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
                // convert to bmp
                ImageHandler.SaveImageBMP(glob + "test.png", glob + "test.bmp");
            }

            // find and draw
            Mat[] mats = ImageUtils.FindMats(glob + "test.png");
            ImageUtils.FindPointsAndDraw(glob + "test.png");

            // get the mats
            Mat blueMat = mats[0];      // B
            blueMat -= mats[1];
            blueMat -= mats[2];
            //CvInvoke.BitwiseNot(blueMat, blueMat);
            ChannelMat blueChannelMat = new(Raylib.ColorFromHSV(0, 1, 1), blueMat);

            Mat greenMat = mats[1];     // G
            greenMat -= mats[2];
            greenMat -= mats[0];
            //CvInvoke.BitwiseNot(greenMat, greenMat);
            ChannelMat greenChannelMat = new(Raylib.ColorFromHSV(240, 1, 1), greenMat);

            Mat redMat = mats[2];       // R
            redMat -= mats[1];
            redMat -= mats[0];
            //CvInvoke.BitwiseNot(redMat, redMat);
            ChannelMat redChannelMat = new(Raylib.ColorFromHSV(120, 1, 1), redMat);

            Mat blackMat = mats[2];     // K
            blackMat += mats[0];
            blackMat += mats[1];
            CvInvoke.BitwiseNot(blackMat, blackMat);
            ChannelMat blackChannelMat = new(Raylib.ColorFromHSV(0, 0, 0), blackMat);

            // create the master mat
            ChannelMat masterMat = new();
            masterMat.Mat = new();
            masterMat.Create(HEIGHT, WIDTH, DepthType.Default, 3);

            // merge
            CvInvoke.Merge(new VectorOfMat(blueChannelMat.Mat, greenChannelMat.Mat, redChannelMat.Mat), masterMat.Mat);
            CvInvoke.CvtColor(blackChannelMat.Mat, blackChannelMat.Mat, ColorConversion.Gray2Bgr);
            masterMat.Mat += blackChannelMat.Mat;

            // TODO: FINISH LOGIC FOR DECODING PROCESS

            // Show blobs
            CvInvoke.NamedWindow("Main");
            CvInvoke.Imshow("Main", masterMat.Mat);
            CvInvoke.WaitKey(0);

            // cleanup 2
            Raylib.CloseWindow();
        }
    }
}
