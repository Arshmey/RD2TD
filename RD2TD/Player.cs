using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RD2TD
{
    internal class Player
    {

        KeyBoard keyBoard;
        System.Timers.Timer handlerMove;


        private int X;
        private int Y;
        private int Width;
        private int Height;
        private int point;

        public Player(KeyBoard keyBoard, int X, int Y, int Width, int Height)
        {
            this.keyBoard = keyBoard;
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;

            handlerMove = new System.Timers.Timer { Enabled = true, AutoReset = true, Interval = 35 };
            handlerMove.Elapsed += Move;
        }

        private void Move(object sender, EventArgs e)
        {
            if (keyBoard.getKey((int)Keys.W))
            {
                Y -= 1;
            }
            if (keyBoard.getKey((int)Keys.S))
            {
                Y += 1;
            }
            if (keyBoard.getKey((int)Keys.A))
            {
                X -= 1;
            }
            if (keyBoard.getKey((int)Keys.D))
            {
                X += 1;
            }

            if (keyBoard.getKey((int)Keys.E))
            {
                point++;
            }
        }

        public int getX()
        {
            return X;
        }

        public int getY()
        {
            return Y;
        }

        public int getWidth() 
        {
            return Width;
        }

        public int getHeight()
        {
            return Height;
        }

        public int getPoint()
        {
            return point;
        }

    }
}
