﻿using System;
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
    internal class Paine
    {
        private Form _parent = null;
        private PictureBox _pictureBox = null;
        private Bitmap _bitmap = null;
        private Graphics _graphics = null;
        private Font _font = new Font("MS UI Gothic", 12);
        private Color _backGround = Color.Black;
        private Brush _foreGround = Brushes.White;
        public Paine(Form parent)
        {
            _pictureBox = new PictureBox();
            _pictureBox.Dock = DockStyle.Fill;
            _pictureBox.BackColor = _backGround;

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
            _bitmap = new Bitmap(Util.Max(_pictureBox.Width, 1), Util.Max(_pictureBox.Height, 1));
            _pictureBox.Image = _bitmap;
            _graphics = Graphics.FromImage(_bitmap);
            Draw();
            Debug.WriteLine(string.Format("size{0},{1}", _bitmap.Width, _bitmap.Height));
        }
        public void Draw()
        {
            IEnumerable<string> drives = Util.GetDrives();
            _graphics.DrawString(string.Join(Environment.NewLine, drives), _font, _foreGround, 0, 0);
        }
    }
}