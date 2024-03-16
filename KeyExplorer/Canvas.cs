using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyExplorer
{
    internal class Canvas
    {
        private Form _parent = null;
        private PictureBox _pictureBox = null;
        private Bitmap _bitmap = null;
        private Graphics _graphics = null;
        private Font _font = new Font("MS UI Gothic", 12);
        public Canvas(Form parent)
        {
            _pictureBox = new PictureBox();
            _pictureBox.Dock = DockStyle.Fill;
            _pictureBox.BackColor = System.Drawing.Color.Black;

            _parent = parent;
            _parent.Controls.Add(_pictureBox);
            _parent.Resize += (object sender, EventArgs e) =>
            {
                Resize();
            };
            Resize();
        }
        public void Resize()
        {
            _pictureBox.Size = _parent.Size;
            _bitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
            Debug.WriteLine(string.Format("w[{0}]h[{1}]", _bitmap.Width ,_bitmap.Height));
            _pictureBox.Image = _bitmap;
            _graphics = Graphics.FromImage(_bitmap);
            Draw();
        }
        public void Draw()
        {
            _graphics.Clear(Color.Black);
            _graphics.DrawString("test string.", _font, Brushes.White, 0, 0);
        }
    }
}
