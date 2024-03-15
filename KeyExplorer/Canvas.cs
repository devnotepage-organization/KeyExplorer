using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyExplorer
{
    internal class Canvas
    {
        private PictureBox _pictureBox = null;
        private Bitmap _bitmap = null;
        private Graphics _graphics = null;
        private Font _font = null;
        public Canvas(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
            _bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = _bitmap;
            _graphics = Graphics.FromImage(_bitmap);
            _font = new Font("MS UI Gothic", 9);
        }
        public void Draw()
        {
            _graphics.DrawString("test string.", _font, Brushes.Blue, 0, 0);
        }
    }
}
