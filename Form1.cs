using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTrain
{
    public partial class Form1 : Form
    {
        BufferedGraphicsContext currentContext;
        BufferedGraphics myBuffer;
        Graphics graphics;


        Player player;

        void InitializeGameComponent()
        {
            player = new Player(new Point(20, 20), new Size(50, 50));
        }


        public Form1()
        {
            InitializeComponent();
            currentContext = BufferedGraphicsManager.Current;
            myBuffer = currentContext.Allocate(panel1.CreateGraphics(), panel1.DisplayRectangle);
            graphics = myBuffer.Graphics;
            InitializeGameComponent();
        }




        int i = 0;
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            graphics.Clear(panel1.BackColor);
            graphics.DrawLine(new Pen(Color.FromArgb(132, 132, 0)), new Point(0, 0), new Point(50 + i, 50+ i));
            graphics.DrawEllipse(Pens.BlueViolet, new Rectangle(50, 50, 50+ i, 50 + i));
            




            myBuffer.Render();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            switch(e.KeyCode)
            {
                case Keys.Left: i++; break; ; //идти вправо
                case Keys.Right: i--; break; //идти влево
                case Keys.Up: break; //прыгнуть
                case Keys.Down: break; //присесть
                case Keys.LButton: break; //shoot
                default: break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:i--; break; ; //идти вправо
                case Keys.Right: i++; break; //идти влево
                case Keys.Up: break; //прыгнуть
                case Keys.Down: break; //присесть
                case Keys.LButton: break; //shoot
                default: break;
            }
        }
    }
}
