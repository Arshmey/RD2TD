using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RD2TD
{
    public partial class Form1 : Form
    {

        KeyBoard keyBoard;
        Player player;
        
        public Form1()
        {
            InitializeComponent();
            keyBoard = new KeyBoard(this);
            player = new Player(keyBoard, playerPicture.Location.X, playerPicture.Location.Y, playerPicture.Width, playerPicture.Height);

            Thread.Sleep(10);
            new Thread(UpdateItems).Start();
        }

        private void UpdateItems()
        {
            while (true)
            {
                playerPicture.Invoke(new Action(() => { playerPicture.Location = new Point(player.getX(), player.getY()); }));
                counter.Invoke(new Action(() => { counter.Text = "Pressed E: " + player.getPoint(); }));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
