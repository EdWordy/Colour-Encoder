using Emgu.CV;
using Raylib_cs;

namespace CMYKify
{
    internal class ChannelMat : Mat
    {
        public Raylib_cs.Color Color { get; set; }
        public Mat Mat { get; set; }

        public ChannelMat() { }

        public ChannelMat(Raylib_cs.Color color, Mat mat)
        {
            Color = color;
            Mat = mat;
        }
    }
}
