using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Text;

public static class ImageDecoder
{
    private const int Interval = 10; // Horizontal interval between circles

    public static string DecodeImage(string imagePath)
    {
        Image<Bgr, byte> img = new Image<Bgr, byte>(imagePath);
        StringBuilder binarySequence = new StringBuilder();

        // Start from the defined margin
        for (int y = 20; y < img.Height; y += Interval)
        {
            for (int x = 30; x < img.Width; x += Interval)
            {
                Bgr color = img[y, x];
                string binaryPair = ColorToBinary(color);
                if (binaryPair != null)
                {
                    binarySequence.Append(binaryPair);
                }
            }
        }

        return BinaryToString(binarySequence.ToString());
    }

    private static string ColorToBinary(Bgr color)
    {
        // Adjust the color detection as per your specific encoding
        if (color.Equals(new Bgr(0, 0, 255))) // Red in BGR
            return "00";
        if (color.Equals(new Bgr(0, 255, 0))) // Green
            return "01";
        if (color.Equals(new Bgr(255, 0, 0))) // Blue
            return "10";
        if (color.Equals(new Bgr(0, 0, 0))) // Black
            return "11";

        return null; // No match found
    }

    private static string BinaryToString(string binary)
    {
        StringBuilder text = new StringBuilder();

        for (int i = 0; i < binary.Length; i += 8)
        {
            string byteString = binary.Substring(i, 8);
            text.Append(Convert.ToChar(Convert.ToInt32(byteString, 2)));
        }

        return text.ToString();
    }
}