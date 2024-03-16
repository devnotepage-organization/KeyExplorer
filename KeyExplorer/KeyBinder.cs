using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyExplorer
{
    internal class KeyBinder
    {
        Form _parent = null;
        public KeyBinder(Form parent)
        {
            _parent = parent;
            _parent.KeyPress += (object sender, KeyPressEventArgs e) =>
            {
                InputKey(sender, e);
            };
        }
        private void InputKey(object sender, KeyPressEventArgs e)
        {

        }
    }
}
