# Colour-Encoder
An encoding schema using colour coding for the efficient storage of short and medium length data.

## Features

- Can encode binary but uses half as many units.
- Can be printed onto paper and read back using provided encoder/decoder program (built on OpenCV).
- 9000 Character capacity at print size A7 (image size 1200 x 800 px).

## Directory
- CMYKify is the base application, including the encoder and decoder.
- Viewfinder is a debugging tool for viewing generated textures.
- CMYKread is the android app for efficient encoding and decoding (TO DO).

## Screenshots
Image Encoding Process

![The image encoding process, from png to text and back again](https://github.com/EdWordy/Colour-Encoder/blob/main/images/Colour-Encoder_Chart.png)

Encoded Image

![The encoded image, in RGBK dots](https://github.com/EdWordy/Colour-Encoder/blob/main/images/Colour-Encoder_SS1.png)

## Version
0.1.0

---
TODO:

-Complete support for ASCII (just punct left)

-Finish CMYK decoding; RGBK is done.

-Reader app
