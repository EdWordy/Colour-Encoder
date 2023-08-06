namespace CMYKify
{
    public class Cipher
    {
        // CMYK 

        public static string BinaryToCMYK(string msg, int key, bool format)
        {
            // vars
            string encoded = "";

            for (int i = 0; i < msg.Length - 1; i += 2)
            {
                if (format)
                {
                    // produce more readable output
                    if (i != 0 && i % 8 == 0)
                    {
                        encoded += " ";
                    }
                }

                // get the values
                char c = msg[i];
                char d = msg[i + 1];

                // encode
                if (c == '0' && d == '0')          // C
                {
                    encoded += "C";
                }
                else if (c == '0' && d == '1')     // M
                {
                    encoded += "M";
                }
                else if (c == '1' && d == '0')     // Y
                {
                    encoded += "Y";
                }
                else if (c == '1' && d == '1')     // K
                {
                    encoded += "K";
                }
                else                                // Unknown
                {
                    encoded += "?";
                }

            }
            return encoded;
        }

        public static string TextToCMYK(string text, int key, bool format)
        {
            // step 1 - text

            // setup
            text = text.ToLower();

            // vars
            string msg = "";

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        msg += "01100001";
                        break;
                    case 'b':
                        msg += "01100010";
                        break;
                    case 'c':
                        msg += "01100011";
                        break;
                    case 'd':
                        msg += "01100100";
                        break;
                    case 'e':
                        msg += "01100101";
                        break;
                    case 'f':
                        msg += "01100110";
                        break;
                    case 'g':
                        msg += "01100111";
                        break;
                    case 'h':
                        msg += "01101000";
                        break;
                    case 'i':
                        msg += "01101001";
                        break;
                    case 'j':
                        msg += "01101010";
                        break;
                    case 'k':
                        msg += "01101011";
                        break;
                    case 'l':
                        msg += "01101100";
                        break;
                    case 'm':
                        msg += "01101101";
                        break;
                    case 'n':
                        msg += "01101110";
                        break;
                    case 'o':
                        msg += "01101111";
                        break;
                    case 'p':
                        msg += "01110000";
                        break;
                    case 'q':
                        msg += "01110001";
                        break;
                    case 'r':
                        msg += "01110010";
                        break;
                    case 's':
                        msg += "01110011";
                        break;
                    case 't':
                        msg += "01110100";
                        break;
                    case 'u':
                        msg += "01110101";
                        break;
                    case 'v':
                        msg += "01110110";
                        break;
                    case 'w':
                        msg += "01110111";
                        break;
                    case 'x':
                        msg += "01111000";
                        break;
                    case 'y':
                        msg += "01111001";
                        break;
                    case 'z':
                        msg += "01111010";
                        break;
                    default:
                        break;
                }
            }
            // binary to cmyk
            return BinaryToCMYK(msg, 2, false);
        }

        public static string HexToCMYK(string msg, int key, bool format)
        {
            string encoded = "";

            // TO DO
            // ...


            return encoded;
        }

        // RGB+

        public static string BinaryToRGB(string msg, int key)
        {
            // vars
            string encoded = "";

            for (int i = 0; i < msg.Length - 1; i += 2)
            { 
                // get the values
                char c = msg[i];
                char d = msg[i + 1];

                // encode
                if (c == '0' && d == '0')          // R
                {
                    encoded += "R";
                }
                else if (c == '0' && d == '1')     // G
                {
                    encoded += "G";
                }
                else if (c == '1' && d == '0')     // B
                {
                    encoded += "B";
                }
                else if (c == '1' && d == '1')     // Space
                {
                    encoded += " ";
                }
                else                                // Unknown
                {
                    encoded += "?";
                }

            }
            return encoded;
        }

        public static string TextToRGB(string text, int key)
        {
            // step 1 - text

            // setup
            text = text.ToLower();

            // vars
            string msg = "";

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        msg += "01100001";
                        break;
                    case 'b':
                        msg += "01100010";
                        break;
                    case 'c':
                        msg += "01100011";
                        break;
                    case 'd':
                        msg += "01100100";
                        break;
                    case 'e':
                        msg += "01100101";
                        break;
                    case 'f':
                        msg += "01100110";
                        break;
                    case 'g':
                        msg += "01100111";
                        break;
                    case 'h':
                        msg += "01101000";
                        break;
                    case 'i':
                        msg += "01101001";
                        break;
                    case 'j':
                        msg += "01101010";
                        break;
                    case 'k':
                        msg += "01101011";
                        break;
                    case 'l':
                        msg += "01101100";
                        break;
                    case 'm':
                        msg += "01101101";
                        break;
                    case 'n':
                        msg += "01101110";
                        break;
                    case 'o':
                        msg += "01101111";
                        break;
                    case 'p':
                        msg += "01110000";
                        break;
                    case 'q':
                        msg += "01110001";
                        break;
                    case 'r':
                        msg += "01110010";
                        break;
                    case 's':
                        msg += "01110011";
                        break;
                    case 't':
                        msg += "01110100";
                        break;
                    case 'u':
                        msg += "01110101";
                        break;
                    case 'v':
                        msg += "01110110";
                        break;
                    case 'w':
                        msg += "01110111";
                        break;
                    case 'x':
                        msg += "01111000";
                        break;
                    case 'y':
                        msg += "01111001";
                        break;
                    case 'z':
                        msg += "01111010";
                        break;
                    default:
                        break;
                }
            }
            // binary to cmyk
            return BinaryToRGB(msg, 2);
        }
    }
}