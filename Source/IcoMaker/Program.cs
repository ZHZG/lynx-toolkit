﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Lynx Toolkit">
//   The MIT License (MIT)
//   
//   Copyright (c) 2012 Oystein Bjorke
//   
//   Permission is hereby granted, free of charge, to any person obtaining a
//   copy of this software and associated documentation files (the
//   "Software"), to deal in the Software without restriction, including
//   without limitation the rights to use, copy, modify, merge, publish,
//   distribute, sublicense, and/or sell copies of the Software, and to
//   permit persons to whom the Software is furnished to do so, subject to
//   the following conditions:
//   
//   The above copyright notice and this permission notice shall be included
//   in all copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
//   OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//   MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
//   IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
//   CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//   TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
//   SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace IcoMaker
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LynxToolkit.Utilities.ApplicationHeader);

            var ico = new Icon();
            string iconFilename = null;
            foreach (var arg in args)
            {
                if (arg.Contains(".ico"))
                {
                    iconFilename = arg;
                }

                if (arg.Contains(".png"))
                {
                    ico.AddImage(arg);
                }

                if (arg.Contains(".bmp"))
                {
                    ico.AddBitmap(arg);
                }
            }

            if (ico.Entries.Count > 0)
            {
                if (iconFilename == null)
                {
                    iconFilename = "default.ico";
                }

                Console.WriteLine("Exporting to " + iconFilename);
                ico.Save(iconFilename);
            }
            else if (iconFilename != null)
            {
                Console.WriteLine("Loading " + iconFilename);
                ico.Load(iconFilename);
                Console.WriteLine();
                Console.WriteLine("Image type: {0}", ico.ImageType);
                Console.WriteLine("Images: {0}", ico.Entries.Count);
                Console.WriteLine();
                foreach (var entry in ico.Entries)
                {
                    Console.WriteLine("{0}x{1} {2}c {4}cp {5}bpp {6}b {8}", entry.Width, entry.Height, entry.Colors, entry.Reserved, entry.ColorPlanes, entry.BitsPerPixel, entry.Size, entry.Offset, entry.Format);
                }

                Console.ReadKey();
            }
        }
    }

    public enum ImageType { Icon = 1, Cursor = 2 }

    public class Icon
    {
        public IList<Entry> Entries { get; private set; }

        public ImageType ImageType { get; set; }

        public Icon()
        {
            this.Entries = new List<Entry>();
        }

        public enum ImageFormat { Unknown, PNG, BMP }

        public class Entry
        {
            public byte Width { get; set; }
            public byte Height { get; set; }
            public byte Colors { get; set; }
            public byte Reserved { get; set; }
            public ushort ColorPlanes { get; set; }
            public ushort BitsPerPixel { get; set; }
            public uint Size { get; set; }
            public uint Offset { get; set; }
            public byte[] ImageData { get; set; }

            public Image Image { get; set; }
            public IcoMaker.Bitmap Bitmap { get; set; }

            public ImageFormat Format
            {
                get
                {
                    if (ImageData == null || ImageData.Length < 4)
                        return ImageFormat.Unknown;
                    if ((ImageData[0] == 137) && (ImageData[1] == 80) && (ImageData[2] == 78) && (ImageData[3] == 71))
                        return ImageFormat.PNG;
                    return ImageFormat.BMP;
                }
            }
        }

        public void Load(string path)
        {
            using (var stream = File.OpenRead(path))
            {
                using (var r = new BinaryReader(stream))
                {
                    var reserved = r.ReadUInt16();
                    if (reserved != 0)
                    {
                        throw new InvalidOperationException();
                    }

                    this.ImageType = (ImageType)r.ReadUInt16();
                    var n = r.ReadUInt16();
                    for (int i = 0; i < n; i++)
                    {
                        var entry = new Entry
                            {
                                Width = r.ReadByte(),
                                Height = r.ReadByte(),
                                Colors = r.ReadByte(),
                                Reserved = r.ReadByte(),
                                ColorPlanes = r.ReadUInt16(),
                                BitsPerPixel = r.ReadUInt16(),
                                Size = r.ReadUInt32(),
                                Offset = r.ReadUInt32()
                            };
                        this.Entries.Add(entry);
                    }

                    for (int i = 0; i < n; i++)
                    {
                        var entry = this.Entries[i];
                        r.BaseStream.Seek(entry.Offset, SeekOrigin.Begin);
                        entry.ImageData = r.ReadBytes((int)entry.Size);

                        using (var ms = new MemoryStream(entry.ImageData))
                        {
                            switch (entry.Format)
                            {
                                case ImageFormat.PNG:
                                    entry.Image = Image.FromStream(ms);
                                    break;
                                case ImageFormat.BMP:
                                    // Recall that if an image is stored in BMP format, it must exclude the opening BITMAPFILEHEADER.
                                    entry.Bitmap = IcoMaker.Bitmap.Load(ms, true);
                                    break;
                            }
                        }
                    }
                }
            }

        }

        public void Save(string path)
        {
            // http://en.wikipedia.org/wiki/ICO_(file_format)
            using (var s = File.Create(path))
            {
                using (var w = new BinaryWriter(s))
                {
                    w.Write((short)0);
                    w.Write((short)1);
                    w.Write((short)this.Entries.Count);
                    int offset = 6 + this.Entries.Count * 16;
                    var buffers = new List<byte[]>();
                    foreach (var e in this.Entries)
                    {
                        w.Write(e.Width);        // Specifies image width in pixels. Can be any number between 0 and 255. Value 0 means image width is 256 pixels.
                        w.Write(e.Height);       // Specifies image height in pixels. Can be any number between 0 and 255. Value 0 means image height is 256 pixels.
                        w.Write(e.Colors);       // Specifies number of colors in the color palette. Should be 0 if the image does not use a color palette.
                        w.Write((byte)0);        // Reserved
                        w.Write(e.ColorPlanes);  // Specifies color planes. Should be 0 or 1
                        w.Write(e.BitsPerPixel); // Specifies bits per pixel.

                        byte[] bytes = null;
                        switch (e.Format)
                        {
                            case ImageFormat.PNG:
                                bytes = this.ImageToByteArray(e.Image);
                                break;
                            case ImageFormat.BMP:
                                bytes = this.BitmapToByteArray(e.Bitmap, true);
                                break;
                        }

                        buffers.Add(bytes);
                        var size = bytes != null ? bytes.Length : 0;
                        w.Write((uint)size); // Specifies the size of the image's data in bytes
                        w.Write((uint)offset); // Specifies the offset of BMP or PNG data from the beginning of the ICO/CUR file
                        offset += size;
                    }

                    // All image data referenced by entries in the image directory proceed directly after the image directory.
                    // It is customary practice to store them in the same order as defined in the image directory.
                    foreach (var b in buffers)
                    {
                        // Recall that if an image is stored in BMP format, it must exclude the opening BITMAPFILEHEADER structure,
                        // whereas if it is stored in PNG format, it must be stored in its entirety.
                        w.Write(b);
                    }
                }
            }
        }

        private byte[] BitmapToByteArray(IcoMaker.Bitmap bitmap, bool excludeFileHeader)
        {
            using (var ms = new MemoryStream())
            {
                bitmap.Save(ms, excludeFileHeader);
                return ms.GetBuffer();
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.GetBuffer();
            }
        }

        public void AddImage(string filename)
        {
            var image = Image.FromFile(filename);
            var entry = new Entry
                {
                    Image = image,
                    Width = (byte)image.Width,
                    Height = (byte)image.Height,
                    Colors = (byte)image.Height,
                    ColorPlanes = 1,
                    BitsPerPixel = 0
                };
            this.Entries.Add(entry);
        }

        public void AddBitmap(string filename)
        {
            var bitmap = IcoMaker.Bitmap.LoadFromFile(filename);
            var entry = new Entry
                {
                    Bitmap = bitmap,
                    Width = (byte)bitmap.Width,
                    Height = (byte)bitmap.Height,
                    Colors = (byte)bitmap.Height,
                    ColorPlanes = 1,
                    BitsPerPixel = 0
                };
            this.Entries.Add(entry);

        }
    }
}