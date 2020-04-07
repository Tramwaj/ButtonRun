using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ButtonRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int xDirection;
        int yDirection;
        int[] _vectors = { -1, 1 };
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            xDirection = _vectors[random.Next(0, 2)];
            yDirection = _vectors[random.Next(0, 2)];
            var position = new Point(button1.Location.X + xDirection * button1.Width, button1.Location.Y + yDirection * button1.Height);
            if (position.X < 0)
            {
                position.X += 110;                
            }
            if (position.Y < 0)
            {
                position.Y += 80;
            }
            if (position.X > this.Width-20)
            {
                position.X -= 110;
            }
            if (position.Y > this.Height-40)
            {
                position.Y -= -80;
            }
            button1.Location = position;            
        }        
    }
}
