using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;
//USe %
namespace project1
{
    class Sprites
    {

        public static int page = 0;
        public static int waifhp = 100;
        public static int skelehp = 10;
        public static int disp = 0;
        public static int skelef = 0;
        public static bool hit = false;
        public static int hj = 0;
        public static int hi = 0;
        public static int c = 0;
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
            Image Arrow = Image.FromFile("arrow.jpg");
            
            if (skelehp <= 0 && waifhp <= 0)
            {
                String win = ("Winner!");
                e.Graphics.DrawString(win, font, new SolidBrush(Color.Green), 0, 0);
            }
            else
            {
                if (page == 0)
                {
                    e.Graphics.DrawImage(Arrow, 250, 250, 100, 100);
                    e.Graphics.DrawImage(Waif, 0+disp, 0+disp, 250, 250);
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
                    e.Graphics.DrawImage(Arrow, 250, 250, 100, 100);
                    int y = 0;
                    if (Form1.Frame % 5 == 0&&y==0) y++;
                    else if (Form1.Frame % 5 == 0 && y == 1) y--;
                    if (y == 1) e.Graphics.DrawImage(Skeleton, 0, 0, 250, 250);
                    if (y == 0) e.Graphics.DrawImage(Skeleton, 250, 0, -250, 250);

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
        public static void AnimeD(PaintEventArgs e)
        {
            
            if (hit == true)
            {
                
                Image kirbyA = Image.FromFile("kirbysprites.png");
                int x = (kirbyA.Width / 5)+3;
                int y = kirbyA.Height;
                Rectangle sourceRect = new Rectangle(x * c, 0, x, y);
                if (Form1.Frame % 5 == 0 && c < 5) c++;
                else if (Form1.Frame % 5 == 0 && c == 5)
                {
                    c = 0;
                    hit = false;
                }
                e.Graphics.DrawImage(kirbyA,hi-(y/2),hj-(x/2), sourceRect, GraphicsUnit.Pixel);
                Console.WriteLine(c);

        
                

            }
            


        }
        public static void Scans(int w, int h,int i, int j)
        {
            hj = j;
            hi = i;
            if(page == 0)
            {
                if ((0 < i && i < 250) && (0 < j && j < 250))
                {
                    waifhp -= 1;
                    hit = true;
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
                    hit = true;
                    
                }
                if ((250 < i && i < 350) && (250 < j && j < 350))
                {
                    page = 0;
                    
                }
            }
        }
    }
}
