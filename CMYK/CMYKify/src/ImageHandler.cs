

namespace CMYKify
{
    public class ImageHandler
    {
        public static Image LoadImage(string filename)
        {
            Image image = Image.Load(filename);
            return image;
        }

        public static bool SaveImageBMP(string filename, string path) 
        {
            Image image = Image.Load(filename);

            image.SaveAsBmp(path);

            return true;
        }
    }
}

