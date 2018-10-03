using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        private static int frame= 0;
        public static int Frame
        {
            get { return frame; }
        }
        public Form1()
        {
            InitializeComponent();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            e.Graphics.FillRectangle(Brushes.White, 0, 0, w, h);
            Sprites.Draws(e);
            Sprites.AnimeD(e);

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 16;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();

            void timer_Tick(object sender, EventArgs p)
            {
                frame++;
                Refresh();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs f)
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            int i = f.X;
            int j = f.Y;
            Sprites.Scans(w, h, i, j);
            
                
        }
    }
}
