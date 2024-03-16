using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyExplorer.View
{
    public partial class MainForm : Form
    {
        private Paine paine = null;
        public MainForm()
        {
            InitializeComponent();
            paine = new Paine(this);
        }
    }
}
