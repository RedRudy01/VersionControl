using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Abstractions
{
    public abstract class Toy : System.Windows.Forms.Label
    {
        public Toy()
        {
            AutoSize = false;
            Width = 50;
            Height = Width;
            Paint += Toy_Paint1;
        }

        private void Toy_Paint1(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected abstract void DrawImage(Graphics g);
        public void MoveToy()
        {
            Left += 1;
        }
    }
}
