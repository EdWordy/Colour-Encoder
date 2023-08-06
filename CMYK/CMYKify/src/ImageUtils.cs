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
        public static Mat OpenFile(string filename)
        {
            Mat img = CvInvoke.Imread(filename, ImreadModes.AnyColor);
            return img;
        }

        public static Mat[] FindMats(string filename) 
        {
            // find
            Mat img = CvInvoke.Imread(filename, ImreadModes.AnyColor);
            Mat[] mats = img.Split();
            return mats;
        }

        public static void FindPointsAndDraw(string filename)
        {
            // find
            Mat img = CvInvoke.Imread(filename, ImreadModes.AnyColor);
            Mat[] mats = img.Split();

            // loop the channels
            foreach (Mat mat in mats)
            {
                // detect in each
                SimpleBlobDetector detector = new ();
                MKeyPoint[] points = detector.Detect(mat);

                // helper func here
                // ...

                // draw
                foreach (MKeyPoint point in points)
                {
                    CvInvoke.Circle(img, new System.Drawing.Point((int)point.Point.X, (int)point.Point.Y), 3, new MCvScalar(0, 0, 0));
                }
            }

            // Show blobs
            CvInvoke.NamedWindow("Main");
            CvInvoke.Imshow("Main", img);
            CvInvoke.WaitKey(0);
        }
    }

}
