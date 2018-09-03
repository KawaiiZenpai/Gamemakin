using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int win = 0;
        // this is a tic tac toe game with different colored circles
        // the time int keeps track of whose turn it is
        int time = 1;
        //thes ints keep track of which square has what in it so we can determine a win condition.
        int one = 0;
        int two = 0;
        int three = 0;
        int four = 0;
        int five = 0;
        int six = 0;
        int seven = 0;
        int eight = 0;
        int nine = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Update();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            int oof = (w / 3);
            int foo = (h / 3);
            e.Graphics.FillRectangle(Brushes.White, 0, 0, w, h);
            
            if (one == 1)
            {
                e.Graphics.FillRectangle(Brushes.Blue, 0, 0, oof, foo);
            }
            if (one == 2)
            {
                e.Graphics.FillRectangle(Brushes.Red, 0, 0, oof, foo);
            }
            if (two == 1)
            {
                e.Graphics.FillRectangle(Brushes.Blue, 0, foo, oof, foo);
            }
            if (two == 2)
            {
                e.Graphics.FillRectangle(Brushes.Red, 0, foo, oof, foo);
            }
            if (three == 1)
            {
                e.Graphics.FillRectangle(Brushes.Blue, 0, foo*2, oof, foo);
            }
            if (three == 2)
            {
                e.Graphics.FillRectangle(Brushes.Red, 0, foo * 2, oof, foo);
            }
            if (four == 1)
            {
                e.Graphics.FillRectangle(Brushes.Blue, oof, 0, oof, foo);
            }
            if (four == 2)
            {
                e.Graphics.FillRectangle(Brushes.Red, oof, 0, oof, foo);
            }
            if (five == 1)
            {
                e.Graphics.FillRectangle(Brushes.Blue, oof, foo, oof, foo);
            }
            if (five == 2)
            {
                e.Graphics.FillRectangle(Brushes.Red, oof, foo, oof, foo);
            }
            if (six == 1)
            {
                e.Graphics.FillRectangle(Brushes.Blue, oof, foo*2, oof, foo);
            }
            if(six == 2)
            {
                e.Graphics.FillRectangle(Brushes.Red, oof, foo * 2, oof, foo);
            }
            if (seven == 1)
            {
                e.Graphics.FillRectangle(Brushes.Blue, oof*2, 0, oof, foo);
            }
            if (seven == 2)
            {
                e.Graphics.FillRectangle(Brushes.Red, oof * 2, 0, oof, foo);
            }
            if (eight == 1)
            {
                e.Graphics.FillRectangle(Brushes.Blue, oof * 2, foo, oof, foo);
            }
            if (eight == 2)
            {
                e.Graphics.FillRectangle(Brushes.Red, oof * 2, foo, oof, foo);
            }
            if (nine == 1)
            {
                e.Graphics.FillRectangle(Brushes.Blue, oof * 2, foo*2, oof, foo);
            }
            if (nine == 2)
            {
                e.Graphics.FillRectangle(Brushes.Red, oof * 2, foo * 2, oof, foo);
            }
            e.Graphics.FillRectangle(Brushes.Black, oof, 0, 2, h);
            e.Graphics.FillRectangle(Brushes.Black, oof * 2, 0, 2, h);
            e.Graphics.FillRectangle(Brushes.Black, 0, foo, w, 2);
            e.Graphics.FillRectangle(Brushes.Black, 0, foo * 2, w, 2);
            //checking for win conditions
            if ((one == two)&& (two== three))
            {
                win = one;
            }
            else if ((four == five) && (five == six))
            {
                win = four;
            }
            else if ((seven == eight) && (eight == nine))
            {
                win = seven;
            }
            else if ((seven == one) && (one == four))
            {
                win = seven;
            }
            else if ((two == eight) && (two == five))
            {
                win = two;
            }
            else if ((six == three) && (three == nine))
            {
                win = six;
            }
            else if ((one == five) && (five == nine))
            {
                win = one;
            }
            else if ((five == three) && (seven == five))
            {
                win = five;
            }
            String w1 = "Blue Wins!";
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(
               fontFamily,
               100,
               FontStyle.Regular,
               GraphicsUnit.Pixel);
            String w2 = "Red Wins!";
            if (win == 1)
            {
                e.Graphics.DrawString(w1,font, new SolidBrush(Color.Black), oof/3,foo/3);
                
            }
            else if (win == 2)
            {
                e.Graphics.DrawString(w2, font, new SolidBrush(Color.Black), oof / 3, foo / 3);
                
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs f)
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            int i = f.X / (w/3);
            int j = f.Y / (h/3);
            Console.WriteLine(i);
            Console.WriteLine(f);
            if (i ==0)
            {
                if (j == 0)
                {
                    if (one == 0) one = time;
                    else return;
                }
                else if (j == 1)
                {
                    if (two == 0) two = time;
                    else return;
                    
                }
                else
                {
                    if (three == 0) three = time;
                    else return;
                }
            }
            else if (i == 1)
            {
                if (j == 0)
                {
                    if (four == 0) four = time;
                    else return;
                }
                else if (j == 1)
                {
                    if (five == 0) five = time;
                    else return;
                    
                }
                else
                {
                    if (six == 0) six = time;
                    else return;
                }
            }
            else
            {
                if (j == 0)
                {
                    if (seven == 0) seven = time;
                    else return;
                }
                else if (j == 1)
                {
                    if (eight == 0) eight = time;
                    else return;
                }
                else
                {
                    if (nine == 0) nine = time;
                    else return;
                }
            }
            if (time == 1)
            {
                time++;
            }
            else
            {
                time--;
            }
            if (win != 0)
            {
                System.Environment.Exit(0);
            }
            Refresh();
        }
    }
}
