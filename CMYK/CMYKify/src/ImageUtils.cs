using Emgu;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace CMYKify
{
    internal class ImageUtils
    {
        public static MKeyPoint[] FindPointsAndDraw(string filename)
        {
            // find
            Mat img = CvInvoke.Imread(filename, ImreadModes.Color);
            SimpleBlobDetector detector = new SimpleBlobDetector();
            MKeyPoint[] points = detector.Detect(img);
       
            // draw
            foreach (MKeyPoint point in points) 
            {
                CvInvoke.Circle(img, new System.Drawing.Point((int)point.Point.X, (int)point.Point.Y), 3, new MCvScalar(0, 255, 0));
            }

            // Show blobs
            CvInvoke.NamedWindow("Main");
            CvInvoke.Imshow("Main", img);
            CvInvoke.WaitKey(0);

            return points;
        }
    }
}
