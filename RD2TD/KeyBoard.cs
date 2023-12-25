using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RD2TD
{
    internal class KeyBoard
    {

        bool[] chars = new bool[256];

        public KeyBoard(Form1 form) 
        {
            form.KeyDown += new KeyEventHandler(PressDownKey);
            form.KeyUp += new KeyEventHandler(PressUpKey);
        }

        private void PressDownKey(object sender, KeyEventArgs e)
        {
            int key = e.KeyValue;
            if (!chars[key]) { chars[key] = true; }
        }

        private void PressUpKey(object sender, KeyEventArgs e) 
        {
            int key = e.KeyValue;
            if (chars[key]) { chars[key] = false; }
        }

        public bool getKey(int KeyValue)
        {
            if (chars[KeyValue]) { return true; }
            return false;
        }

    }
}
