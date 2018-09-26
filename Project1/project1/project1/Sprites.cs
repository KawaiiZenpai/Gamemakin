using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;

namespace project1
{
    class Sprites
    {

        public static int page = 0;
        public static int waifhp = 100;
        public static int skelehp = 10;
        public static void Draws(PaintEventArgs e)
        {
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(
               fontFamily,
               80,
               FontStyle.Regular,
               GraphicsUnit.Pixel);
            Image XX = Image.FromFile("X.png");
            String w = ("Dead!");
            Image Skeleton = Image.FromFile("Skeleton.jpg");
            Image Waif = Image.FromFile("002.png");
            Image newImage = Image.FromFile("arrow.jpg");
            if (skelehp <= 0 && waifhp <= 0)
            {
                String win = ("Winner!");
                e.Graphics.DrawString(win, font, new SolidBrush(Color.Green), 0, 0);
            }
            else
            {
                if (page == 0)
                {
                    e.Graphics.DrawImage(newImage, 250, 250, 100, 100);
                    e.Graphics.DrawImage(Waif, 0, 0, 250, 250);
                    String waifhptxt = ("Hp" + waifhp);
                    if (waifhp > 0)
                    {
                        e.Graphics.DrawString(waifhptxt, font, new SolidBrush(Color.Black), 0, 250);
                    }
                    else
                    {
                        e.Graphics.DrawString(w, font, new SolidBrush(Color.Black), 0, 250);
                        e.Graphics.DrawImage(XX, 0, 0, 250, 250);
                    }

                }
                if (page == 1)
                {
                    e.Graphics.DrawImage(newImage, 250, 250, 100, 100);
                    e.Graphics.DrawImage(Skeleton, 0, 0, 250, 250);
                    String skelehptxt = ("Hp" + skelehp);
                    if (skelehp > 0)
                    {
                        e.Graphics.DrawString(skelehptxt, font, new SolidBrush(Color.Black), 0, 250);
                    }
                    else
                    {
                        e.Graphics.DrawString(w, font, new SolidBrush(Color.Black), 0, 250);
                        e.Graphics.DrawImage(XX, 0, 0, 250, 250);
                    }
                }
            }
        }
        public static void Scans(int w, int h,int i, int j)
        {
            if(page == 0)
            {
                if ((0 < i && i < 250) && (0 < j && j < 250))
                {
                    waifhp -= 1;

                }

                if ((250 < i && i < 350) && (250 < j && j < 350))
                {
                    page += 1;
                    
                }
            }
            else if(page == 1)
            {
                if ((0 < i && i < 250) && (0 < j && j < 250))
                {
                    skelehp -= 1;

                }
                if ((250 < i && i < 350) && (250 < j && j < 350))
                {
                    page = 0;
                    
                }
            }
        }
    }
}
