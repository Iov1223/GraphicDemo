using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicDemo
{
    public partial class Form1 : Form
    {
        private int x = 10;
        private int y = 50;
        private Timer _timer = new Timer();
        private bool move_right;
        public Form1()
        {
            InitializeComponent();
            _timer.Enabled = true;
            _timer.Interval = 30;
            _timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += Hello_World;
            var _size = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.MaximumSize = new Size((int)((double)_size.Width / 1.73), (int)((double)_size.Height / 1.5));
            this.MinimumSize = new Size((int)((double)_size.Width / 1.73), (int)((double)_size.Height / 1.5));
        }
        private void Hello_World(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point lt = new Point(x, y);
            Point rb = new Point(x + 300, y + 150);
            Rectangle rect = new Rectangle(x, y, 50, 50);
            var myBrush = new LinearGradientBrush(lt,rb, Color.LightPink, Color.Red);
            g.FillEllipse(myBrush, rect);
        }
        private void FromEdgeToEdge()
        {
            move_right = true;
            _timer.Tick += (object sender2, EventArgs e2) =>
            {
                int xStep = 10;

                if ((x < 810) & (move_right))
                {
                    x += xStep;
                    this.Refresh();
                    this.Paint += Hello_World;
                    Text = $"X = {x}, Y = 50";
                }
                else
                {
                    move_right = false;
                }
                if ((x > 10) & (!move_right))
                {
                    x -= xStep;
                    this.Refresh();
                    this.Paint += Hello_World;
                    Text = $"X = {x}, Y = 50";
                }
                else
                {
                    move_right = true;
                }
            };
        }

        private void Sinusoid()
        {
            move_right = true;
            _timer.Tick += (object sender2, EventArgs e2) =>
            {
                int xStep = 5;
                int yStep = 10;

                if ((x < 200 && y < 450) & (move_right))
                {
                    x += xStep;
                    y += yStep;
                    this.Refresh();
                    this.Paint += Hello_World;
                    Text = $"X = {x}, Y = {y}";
                }
                else if ((x < 400 && y > 50) & (move_right))
                {
                    x += xStep;
                    y -= yStep;
                    this.Refresh();
                    this.Paint += Hello_World;
                    Text = $"X = {x}, Y = {y}";
                }
                else if ((x < 600 && y < 450) & (move_right))
                {
                    x += xStep;
                    y += yStep;
                    this.Refresh();
                    this.Paint += Hello_World;
                    Text = $"X = {x}, Y = {y}";
                }
                else if ((x < 800 && y > 50) & (move_right))
                {
                    x += xStep;
                    y -= yStep;
                    this.Refresh();
                    this.Paint += Hello_World;
                    Text = $"X = {x}, Y = {y}";
                }
                else
                {
                    move_right = false;
                }

                if ((x > 600 && y < 450) & (!move_right))
                {
                    x -= xStep;
                    y += yStep;
                    this.Refresh();
                    this.Paint += Hello_World;
                    Text = $"X = {x}, Y = {y}";
                }
                else if ((x > 400 && y > 50) & (!move_right))
                {
                    x -= xStep;
                    y -= yStep;
                    this.Refresh();
                    this.Paint += Hello_World;
                    Text = $"X = {x}, Y = {y}";
                }
                else if ((x > 200 && y < 450) & (!move_right))
                {
                    x -= xStep;
                    y += yStep;
                    this.Refresh();
                    this.Paint += Hello_World;
                    Text = $"X = {x}, Y = {y}";
                }
                else if ((x > 10 && y > 50) & (!move_right))
                {
                    x -= xStep;
                    y -= yStep;
                    this.Refresh();
                    this.Paint += Hello_World;
                    Text = $"X = {x}, Y = {y}";
                }
                else 
                {
                    move_right = true;
                }
                
            };
        }
        private void Perimetr()
        {
            _timer.Tick += (object sender2, EventArgs e2) =>
            {
                int xStep = 10;
                int yStep = 10;
                if (x < 810 && y == 50)
                {
                    x += xStep;
                    this.Refresh();
                    this.Paint += Hello_World;
                    Text = $"X = {x}, Y = {y}";
                }
                else if (x == 810 && y < 450)
                {
                    y += yStep;
                    this.Refresh();
                    this.Paint += Hello_World;
                    Text = $"X = {x}, Y = {y}";
                }
                else if (x > 10 && y == 450)
                {
                    x -= yStep;
                    this.Refresh();
                    this.Paint += Hello_World;
                    Text = $"X = {x}, Y = {y}";
                }
                else if (x == 10 && y > 50)
                {
                    y -= yStep;
                    this.Refresh();
                    this.Paint += Hello_World;
                    Text = $"X = {x}, Y = {y}";
                }
               
            };
        }
        private void comboBoxChoiseDir_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxChoiseDir.Text)
            {
                case "От края до края":
                    FromEdgeToEdge();
                    break;
                case "Синусойдный":
                    Sinusoid();
                    break;
                case "По периметру":
                    Perimetr();
                    break;
                default:
                    break;
            }
        }
    }
}
