namespace CMYKify
{
    public class ImageEncoder
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

        // RGBK

        public static string TextToRGB(string text, int key)
        {
            // step 1 - blank string

            // vars
            string msg = "";

            // iterate the message length
            for (int i = 0; i < text.Length; i++)
            {
                // test
                switch (text[i])
                {
                    // lower case
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
                    // capitals
                    case 'A':
                        msg += "01000001";
                        break;
                    case 'B':
                        msg += "01000010";
                        break;
                    case 'C':
                        msg += "01000011";
                        break;
                    case 'D':
                        msg += "01000100";
                        break;
                    case 'E':
                        msg += "01000101";
                        break;
                    case 'F':
                        msg += "01000110";
                        break;
                    case 'G':
                        msg += "01000111";
                        break;
                    case 'H':
                        msg += "01001000";
                        break;
                    case 'I':
                        msg += "01001001";
                        break;
                    case 'J':
                        msg += "01001010";
                        break;
                    case 'K':
                        msg += "01001011";
                        break;
                    case 'L':
                        msg += "01001100";
                        break;
                    case 'M':
                        msg += "01001101";
                        break;
                    case 'N':
                        msg += "01001110";
                        break;
                    case 'O':
                        msg += "01001111";
                        break;
                    case 'P':
                        msg += "01010000";
                        break;
                    case 'Q':
                        msg += "01010001";
                        break;
                    case 'R':
                        msg += "01010010";
                        break;
                    case 'S':
                        msg += "01010011";
                        break;
                    case 'T':
                        msg += "01010100";
                        break;
                    case 'U':
                        msg += "01010101";
                        break;
                    case 'V':
                        msg += "01010110";
                        break;
                    case 'W':
                        msg += "01010111";
                        break;
                    case 'X':
                        msg += "01011000";
                        break;
                    case 'Y':
                        msg += "01011001";
                        break;
                    case 'Z':
                        msg += "01011010";
                        break;
                    // punctuation
                    case ' ':
                        msg += "00100000";
                        break;
                    case ',':
                        msg += "00101100";
                        break;
                    case '.':
                        msg += "00101110";
                        break;
                    case '!':
                        msg += "00100001";
                        break;
                    case '?':
                        msg += "00111111";
                        break;
                    case ';':
                        msg += "00111011";
                        break;
                    case ':':
                        msg += "00111010";
                        break;
                    case '\'':
                        msg += "00100111";
                        break;
                    case '\"':
                        msg += "00100010";
                        break;
                    default:
                        // do nothing
                        break;
                }
            }
            // binary to cmyk
            return BinaryToRGB(msg, 2);
        }

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

    }
}