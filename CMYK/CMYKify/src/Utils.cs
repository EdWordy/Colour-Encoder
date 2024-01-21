using Raylib_cs;
using Color = Raylib_cs.Color;

namespace CMYKify
{
    public static class Utils
    {
        public static void DrawStringCMYK(string input, int x, int y, int width, int interval, int margin)
        {
            for (int a = 0; a < input.Length; a++)
            {
                switch (input[a])
                {
                    case 'C':
                        Raylib.DrawCircleV(new System.Numerics.Vector2(x, interval * y), 3, Color.BLUE);
                        break;
                    case 'M':
                        Raylib.DrawCircleV(new System.Numerics.Vector2(x, interval * y), 3, Color.MAGENTA);
                        break;
                    case 'Y':
                        Raylib.DrawCircleV(new System.Numerics.Vector2(x, interval * y), 3, Raylib.ColorFromHSV(47, .86f, .84f));
                        break;
                    case 'K':
                        Raylib.DrawCircleV(new System.Numerics.Vector2(x, interval * y), 3, Color.BLACK);
                        break;
                    default:
                        break;
                }

                x += interval;
                if (x > width - margin)
                {
                    y++;
                    x %= width - margin;
                    if (x < margin)
                    {
                        x = margin;
                    }
                }
            }
        }

        public static void DrawStringRGB(string input, int x, int y, int width, int interval, int margin)
        {
            for (int a = 0; a < input.Length; a++)
            {
                switch (input[a])
                {
                    case 'R':
                        Raylib.DrawCircleV(new System.Numerics.Vector2(x, interval * y), 3, Raylib.ColorFromHSV(0, 1, 1));
                        break;
                    case 'G':
                        Raylib.DrawCircleV(new System.Numerics.Vector2(x, interval * y), 3, Raylib.ColorFromHSV(120, 1, 1));
                        break;
                    case 'B':
                        Raylib.DrawCircleV(new System.Numerics.Vector2(x, interval * y), 3, Raylib.ColorFromHSV(240, 1, 1));
                        break;
                    case 'K':
                        Raylib.DrawCircleV(new System.Numerics.Vector2(x, interval * y), 3, Raylib.ColorFromHSV(0, 0, 0));
                        break;
                    default:
                        break;
                }

                x += interval;
                if (x > width - margin)
                {
                    y++;
                    x %= width - margin;
                    if (x < margin)
                    {
                        x = margin;
                    }
                }
            }
        }
    }
}
