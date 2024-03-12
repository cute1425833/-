using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                       c = 0;
            timer1.Enabled = true;
            timer2.Enabled = true;
          
            b += 1;
            
            label7.Text = c.ToString();
        }
        int a;
        int w;
        int h;
        int b=0;
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a = Convert.ToInt32(label4.Text);
            a -= 1;
            label4.Text = a.ToString();

           
            
            if (a == 0)
            { timer1.Enabled = false;
                a = 30;
                label4.Text = a.ToString();
                timer2.Enabled = false;
                b -= 1;
         
                                MessageBox.Show("時間到");
               
             
                
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
             w =this.Size.Width;
             h =this. Size.Height;

        }
        int x, y;
        Random r = new Random();
        private void timer2_Tick(object sender, EventArgs e)
        {
            
             x = r.Next(0, w);
             y = r.Next(127,( pictureBox1.Top+pictureBox1.Size.Height));
            pictureBox1.Location =new Point (x, y);
           

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if (b==1)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        if (pictureBox2.Top >= 0)
                            pictureBox2.Location = new Point(pictureBox2.Location.X, (pictureBox2.Location.Y) - 20);
                        break;
                    case Keys.S:
                        if (pictureBox2.Top + pictureBox2.Height < h) pictureBox2.Top += 20;

                        break;
                    case Keys.A:
                        if (pictureBox2.Left > 0) pictureBox2.Left -= 20;

                        break;
                    case Keys.D:
                        if (pictureBox2.Left + pictureBox2.Width < w) pictureBox2.Left += 20;

                        break;
                    
                }
               


            }
            if((pictureBox2.Location.X-pictureBox2.Width/2>=pictureBox1.Location.X - pictureBox1.Width / 2 && pictureBox2.Location.X - pictureBox2.Width / 2<=pictureBox1.Location.X+pictureBox1.Width/2)&&(pictureBox2.Location.Y-pictureBox2.Height/2<=pictureBox1.Location.Y+pictureBox1.Height/2&& pictureBox2.Location.Y - pictureBox2.Height/2>=pictureBox1.Location.Y-pictureBox1.Height/2))
            
            {
                c += 1;
                x = r.Next(0, w);
                y = r.Next(127, (pictureBox1.Top + pictureBox1.Size.Height));
                pictureBox1.Location = new Point(x, y);
                label7.Text = c.ToString();


            }
           else
           if((pictureBox2.Location.X + pictureBox2.Width / 2 >= pictureBox1.Location.X - pictureBox1.Width / 2 && pictureBox2.Location.X + pictureBox2.Width / 2 <= pictureBox1.Location.X + pictureBox1.Width / 2) && (pictureBox2.Location.Y - pictureBox2.Height / 2 <= pictureBox1.Location.Y + pictureBox1.Height / 2 && pictureBox2.Location.Y - pictureBox2.Height / 2 >= pictureBox1.Location.Y - pictureBox1.Height / 2))
            {
                c += 1;
                x = r.Next(0, w);
                y = r.Next(127, (pictureBox1.Top + pictureBox1.Size.Height));
                pictureBox1.Location = new Point(x, y);
                label7.Text = c.ToString();
                            }
            else
                if ((pictureBox2.Location.X - pictureBox2.Width / 2 >= pictureBox1.Location.X - pictureBox1.Width / 2 && pictureBox2.Location.X - pictureBox2.Width / 2 <= pictureBox1.Location.X + pictureBox1.Width / 2) && (pictureBox2.Location.Y + pictureBox2.Height / 2 <= pictureBox1.Location.Y + pictureBox1.Height / 2 && pictureBox2.Location.Y + pictureBox2.Height / 2 >= pictureBox1.Location.Y - pictureBox1.Height / 2))
            {
                c += 1;
                x = r.Next(0, w);
                y = r.Next(127, (pictureBox1.Top + pictureBox1.Size.Height));
                pictureBox1.Location = new Point(x, y);
                label7.Text = c.ToString();
            }
            else
                if ((pictureBox2.Location.X + pictureBox2.Width / 2 >= pictureBox1.Location.X - pictureBox1.Width / 2 && pictureBox2.Location.X + pictureBox2.Width / 2 <= pictureBox1.Location.X + pictureBox1.Width / 2) && (pictureBox2.Location.Y + pictureBox2.Height / 2 <= pictureBox1.Location.Y + pictureBox1.Height / 2 && pictureBox2.Location.Y + pictureBox2.Height / 2 >= pictureBox1.Location.Y - pictureBox1.Height / 2))
            {
                c += 1;
                x = r.Next(0, w);
                y = r.Next(127, (pictureBox1.Top + pictureBox1.Size.Height));
                pictureBox1.Location = new Point(x, y);
                label7.Text = c.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                        if (pictureBox2.Top >= 0)
                pictureBox2.Location = new Point(pictureBox2.Location.X, (pictureBox2.Location.Y) - 20);
            break;
                    case Keys.Down:
                        if (pictureBox2.Top + pictureBox2.Height < h) pictureBox2.Top += 20;

            break;
                    case Keys.Left:
                        if (pictureBox2.Left > 0) pictureBox2.Left -= 20;

            break;
                    case Keys.Right:
                        if (pictureBox2.Left + pictureBox2.Width < w) pictureBox2.Left += 20;

            break;
            }
            if ((pictureBox2.Location.X - pictureBox2.Width / 2 >= pictureBox1.Location.X - pictureBox1.Width / 2 && pictureBox2.Location.X - pictureBox2.Width / 2 <= pictureBox1.Location.X + pictureBox1.Width / 2) && (pictureBox2.Location.Y - pictureBox2.Height / 2 <= pictureBox1.Location.Y + pictureBox1.Height / 2 && pictureBox2.Location.Y - pictureBox2.Height / 2 >= pictureBox1.Location.Y - pictureBox1.Height / 2))

            {
                c += 1;
                x = r.Next(0, w);
                y = r.Next(127, (pictureBox1.Top + pictureBox1.Size.Height));
                pictureBox1.Location = new Point(x, y);
                label7.Text = c.ToString();


            }
            else
           if ((pictureBox2.Location.X + pictureBox2.Width / 2 >= pictureBox1.Location.X - pictureBox1.Width / 2 && pictureBox2.Location.X + pictureBox2.Width / 2 <= pictureBox1.Location.X + pictureBox1.Width / 2) && (pictureBox2.Location.Y - pictureBox2.Height / 2 <= pictureBox1.Location.Y + pictureBox1.Height / 2 && pictureBox2.Location.Y - pictureBox2.Height / 2 >= pictureBox1.Location.Y - pictureBox1.Height / 2))
            {
                c += 1;
                x = r.Next(0, w);
                y = r.Next(127, (pictureBox1.Top + pictureBox1.Size.Height));
                pictureBox1.Location = new Point(x, y);
                label7.Text = c.ToString();
            }
            else
                if ((pictureBox2.Location.X - pictureBox2.Width / 2 >= pictureBox1.Location.X - pictureBox1.Width / 2 && pictureBox2.Location.X - pictureBox2.Width / 2 <= pictureBox1.Location.X + pictureBox1.Width / 2) && (pictureBox2.Location.Y + pictureBox2.Height / 2 <= pictureBox1.Location.Y + pictureBox1.Height / 2 && pictureBox2.Location.Y + pictureBox2.Height / 2 >= pictureBox1.Location.Y - pictureBox1.Height / 2))
            {
                c += 1;
                x = r.Next(0, w);
                y = r.Next(127, (pictureBox1.Top + pictureBox1.Size.Height));
                pictureBox1.Location = new Point(x, y);
                label7.Text = c.ToString();
            }
            else
                if ((pictureBox2.Location.X + pictureBox2.Width / 2 >= pictureBox1.Location.X - pictureBox1.Width / 2 && pictureBox2.Location.X + pictureBox2.Width / 2 <= pictureBox1.Location.X + pictureBox1.Width / 2) && (pictureBox2.Location.Y + pictureBox2.Height / 2 <= pictureBox1.Location.Y + pictureBox1.Height / 2 && pictureBox2.Location.Y + pictureBox2.Height / 2 >= pictureBox1.Location.Y - pictureBox1.Height / 2))
            {
                c += 1;
                x = r.Next(0, w);
                y = r.Next(127, (pictureBox1.Top + pictureBox1.Size.Height));
                pictureBox1.Location = new Point(x, y);
                label7.Text = c.ToString();
            }
        
    }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

       
        }
    }
}
