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
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs f)
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            int i = f.X;
            int j = f.Y;
            Sprites.Scans(w, h, i, j);
            
            Refresh();    
        }
    }
}
