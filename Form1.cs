using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba7_2_
{
    public partial class Form1 : Form
    {
        bool block = true;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Gray;
            pictureBox2.BackColor = Color.Gray;
            pictureBox3.BackColor = Color.Gray;
            pictureBox4.BackColor = Color.Gray;
            pictureBox5.BackColor = Color.Gray;
            pictureBox6.BackColor = Color.Gray;
            pictureBox7.BackColor = Color.Gray;
            pictureBox8.BackColor = Color.Gray;
            pictureBox9.BackColor = Color.Gray;
            groupBox1.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            block = false;
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            pictureBox5.BackColor = Color.White;
            pictureBox6.BackColor = Color.White;
            pictureBox7.BackColor = Color.White;
            pictureBox8.BackColor = Color.White;
            pictureBox9.BackColor = Color.White;
        }
        bool a = true;
        bool chel1 = true;
        bool chel2 = true;
        int b1 = 10;
        int b2 = 10;
        int b3 = 10;
        int b4 = 10;
        int b5 = 10;
        int b6 = 10;
        int b7 = 10;
        int b8 = 10;
        int b9 = 10;
        int r;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {     
                if (chel1 == true && chel2 == true)
                {
                    if (block == false)
                    {
                        if (pictureBox1.Image == null)
                        {
                            if (a)
                            {
                                g.DrawLine(Pens.Black, 0, 0, 100, 100);
                                g.DrawLine(Pens.Black, 100, 0, 0, 100);
                                pictureBox1.Image = bmp;
                                b1 = 1;
                            }
                            else
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox1.Image = bmp;
                                b1 = 0;
                            }
                            if ((b1 == 1 && b2 == 1 && b3 == 1) || (b1 == 1 && b4 == 1 && b7 == 1) || (b1 == 1 && b5 == 1 && b9 == 1))
                            {
                                a = true;
                                MessageBox.Show("Победили крестики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if ((b1 == 0 && b2 == 0 && b3 == 0) || (b1 == 0 && b4 == 0 && b7 == 0) || (b1 == 0 && b5 == 0 && b9 == 0))
                            {
                                a = false;
                                MessageBox.Show("Победили нолики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if (b1 != 10 && b2 != 10 && b3 != 10 && b4 != 10 && b5 != 10 && b6 != 10 && b7 != 10 && b8 != 10 && b9 != 10)
                            {
                                a = false;
                                MessageBox.Show("Ничья");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            if (a == true)
                            {
                                a = false;
                            }
                            else
                            {
                                a = true;
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
                if (chel2 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox1.Image == null)
                        {
                            if (b5==1) {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox1.Image = bmp;
                                b1 = 0;
                            }
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1==1 && b5==1 && b9==10)
                                {
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1==10)
                                {
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2==1 && b5==1 && b8==10)
                                {
                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9==1 && b5==1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3==1 && b5==1 && b7==10)
                                {
                                    
                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {
                                  
                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4==1 && b5==1 && b6==10)
                                {
                                    
                                    b6 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {
                                   
                                    b4 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {
                                    
                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {
                                    
                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {
                                    
                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                } 
                                else if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b1 == 10)
                                {
                                   
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3==0 && b2 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox2.Image = bmp1;
                                    b2 = 1;
                                }
                                else if(b7==0 && b4 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox4.Image = bmp1;
                                    b4 = 1;
                                }
                                else if (b2==10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox2.Image = bmp1;
                                    b2 = 1;
                                }
                                else if(b4==10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox4.Image = bmp1;
                                    b4 = 1;
                                }
                                else if(b2!=10 && b4 != 10 && block==false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
                if (chel1 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox1.Image == null)
                        {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox1.Image = bmp;
                                b1 = 0;
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b9 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b7 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b8 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b6 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 10 && b5 == 1 && b8 == 1)
                                {
                                    b2 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {

                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {

                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {

                                    b6 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {

                                    b4 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {

                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 0 && b2 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox2.Image = bmp1;
                                    b2 = 1;
                                }
                                else if (b2 == 0 && b3 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox3.Image = bmp1;
                                    b3 = 1;
                                }
                                else if (b5 == 0 && b9 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox9.Image = bmp1;
                                    b9 = 1;
                                }
                                else if (b9 == 0 && b5 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b7 == 0 && b4 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox4.Image = bmp1;
                                    b4 = 1;
                                }
                                else if (b4 == 0 && b7 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox7.Image = bmp1;
                                    b7 = 1;
                                }
                                else if (b5 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b2 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox2.Image = bmp1;
                                    b2 = 1;
                                }
                                else if (b4 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox4.Image = bmp1;
                                    b4 = 1;
                                }
                                else if (b2 != 10 && b4 != 10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                if (chel1 == true && chel2 == true)
                {
                    if (block == false)
                    {
                        if (pictureBox2.Image == null)
                        {
                            if (a)
                            {
                                g.DrawLine(Pens.Black, 0, 0, 100, 100);
                                g.DrawLine(Pens.Black, 100, 0, 0, 100);
                                pictureBox2.Image = bmp;
                                b2 = 1;
                            }
                            else
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox2.Image = bmp;
                                b2 = 0;
                            }
                            if ((b1 == 1 && b2 == 1 && b3 == 1) || (b2 == 1 && b5 == 1 && b8 == 1))
                            {
                                a = true;
                                MessageBox.Show("Победили крестики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if ((b1 == 0 && b2 == 0 && b3 == 0) || (b2 == 0 && b5 == 0 && b8 == 0))
                            {
                                a = false;
                                MessageBox.Show("Победили нолики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if (b1 != 10 && b2 != 10 && b3 != 10 && b4 != 10 && b5 != 10 && b6 != 10 && b7 != 10 && b8 != 10 && b9 != 10)
                            {
                                a = false;
                                MessageBox.Show("Ничья");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                        }
                        if (a == true)
                        {
                            a = false;
                        }
                        else
                        {
                            a = true;
                        }
                        if (block == true)
                        {
                            pictureBox1.BackColor = Color.Gray;
                            pictureBox2.BackColor = Color.Gray;
                            pictureBox3.BackColor = Color.Gray;
                            pictureBox4.BackColor = Color.Gray;
                            pictureBox5.BackColor = Color.Gray;
                            pictureBox6.BackColor = Color.Gray;
                            pictureBox7.BackColor = Color.Gray;
                            pictureBox8.BackColor = Color.Gray;
                            pictureBox9.BackColor = Color.Gray;
                            b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                        }
                    }
                }
                if (chel2 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox2.Image == null)
                        {
                            if (b5 == 1)
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox2.Image = bmp;
                                b2 = 0;
                            }
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                   
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                   
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {
                                   
                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b5 == 10)
                                {
                                    
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {
                                    
                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {
                                    
                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {
                                 
                                    b6 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {
                                   
                                    b4 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {
                                   
                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {
                                    
                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {
                                   
                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b1 == 10)
                                {
                                  
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                if (b7 == 0 && b1 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox1.Image = bmp1;
                                    b1 = 1;
                                }
                                else if (b9 == 0 && b3 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox3.Image = bmp1;
                                    b3 = 1;
                                }
                                else if (b3 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox3.Image = bmp1;
                                    b3 = 1;
                                }
                                else if (b1 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox1.Image = bmp1;
                                    b1 = 1;
                                }
                                else if (b1!=10 && b3!=10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
                if (chel1 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox2.Image == null)
                        {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox2.Image = bmp;
                                b2 = 0;
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b9 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b7 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b8 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b6 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 10 && b5 == 1 && b8 == 1)
                                {
                                    b2 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {

                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {

                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {

                                    b6 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {

                                    b4 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {

                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 0 && b3 == 10 && block == false)//b2 должно быть
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox3.Image = bmp1;
                                    b3 = 1;
                                }
                                else if (b3 == 0 && b1 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox1.Image = bmp1;
                                    b1 = 1;
                                }
                                else if (b5 == 0 && b8 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox8.Image = bmp1;
                                    b8 = 1;
                                }
                                else if (b8 == 0 && b5 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b3 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox3.Image = bmp1;
                                    b3 = 1;
                                }
                                else if (b1 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox1.Image = bmp1;
                                    b1 = 1;
                                }
                                else if (b5 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b1 != 10 && b3 != 10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox3.Width, pictureBox3.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                if (chel1 == true && chel2 == true)
            {
                if (block == false)
                {
                    if (pictureBox3.Image == null)
                    {
                       
                            if (a)
                            {
                                g.DrawLine(Pens.Black, 0, 0, 100, 100);
                                g.DrawLine(Pens.Black, 100, 0, 0, 100);
                                pictureBox3.Image = bmp;
                                b3 = 1;
                            }
                            else
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox3.Image = bmp;
                                b3 = 0;
                            }
                            if ((b1 == 1 && b2 == 1 && b3 == 1) || (b3 == 1 && b6 == 1 && b9 == 1) || (b3 == 1 && b5 == 1 && b7 == 1))
                            {
                                a = true;
                                MessageBox.Show("Победили крестики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if ((b1 == 0 && b2 == 0 && b3 == 0) || (b3 == 0 && b6 == 0 && b9 == 0) || (b3 == 0 && b5 == 0 && b7 == 0))
                            {
                                a = false;
                                MessageBox.Show("Победили нолики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if (b1 != 10 && b2 != 10 && b3 != 10 && b4 != 10 && b5 != 10 && b6 != 10 && b7 != 10 && b8 != 10 && b9 != 10)
                            {
                                a = false;
                                MessageBox.Show("Ничья");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                        }
                        if (a == true)
                        {
                            a = false;
                        }
                        else
                        {
                            a = true;
                        }
                        if (block == true)
                        {
                            pictureBox1.BackColor = Color.Gray;
                            pictureBox2.BackColor = Color.Gray;
                            pictureBox3.BackColor = Color.Gray;
                            pictureBox4.BackColor = Color.Gray;
                            pictureBox5.BackColor = Color.Gray;
                            pictureBox6.BackColor = Color.Gray;
                            pictureBox7.BackColor = Color.Gray;
                            pictureBox8.BackColor = Color.Gray;
                            pictureBox9.BackColor = Color.Gray;
                            b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                        }
                    }
                }

                if (chel2 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox3.Image == null)
                        {
                            if (b5 == 1)
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox3.Image = bmp;
                                b3 = 0;
                            }
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {

                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {

                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {

                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b5 == 10)
                                {

                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {

                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {

                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {

                                    b6 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {

                                    b4 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {

                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {

                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {

                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b5 == 1 && b9 == 10)
                                {

                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b1 == 10)
                                {

                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                if (b1 == 0 && b2 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox2.Image = bmp1;
                                    b2 = 1;
                                }
                                else if (b9 == 0 && b6 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox6.Image = bmp1;
                                    b6 = 1;
                                }
                                else if (b2 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox2.Image = bmp1;
                                    b2 = 1;
                                }
                                else if (b6 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox6.Image = bmp1;
                                    b6 = 1;
                                }
                                else if (b2 != 10 && b6 != 10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
                if (chel1 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox3.Image == null)
                        {
                            g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                            pictureBox3.Image = bmp;
                            b3 = 0;
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b9 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b7 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b8 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b6 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 10 && b5 == 1 && b8 == 1)
                                {
                                    b2 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {

                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {

                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {

                                    b6 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {

                                    b4 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {

                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 0 && b2 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox2.Image = bmp1;
                                    b2 = 1;
                                }
                                else if (b2 == 0 && b1 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox1.Image = bmp1;
                                    b1 = 1;
                                }
                                else if (b7 == 0 && b5 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b5 == 0 && b7 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox7.Image = bmp1;
                                    b7 = 1;
                                }
                                else if (b9 == 0 && b6 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox6.Image = bmp1;
                                    b6 = 1;
                                }
                                else if (b6 == 0 && b9 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox9.Image = bmp1;
                                    b9 = 1;
                                }
                                else if (b5 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b2 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox2.Image = bmp1;
                                    b2 = 1;
                                }
                                else if (b6 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox4.Image = bmp1;
                                    b4 = 1;
                                }
                                else if (b2 != 10 && b4 != 10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                if (chel1 == true && chel2 == true)
                {
                    if (block == false)
                    {
                        if (pictureBox4.Image == null)
                        {
                            if (a)
                            {
                                g.DrawLine(Pens.Black, 0, 0, 100, 100);
                                g.DrawLine(Pens.Black, 100, 0, 0, 100);
                                pictureBox4.Image = bmp;
                                b4 = 1;
                            }
                            else
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox4.Image = bmp;
                                b4 = 0;
                            }
                            if ((b1 == 1 && b4 == 1 && b7 == 1) || (b4 == 1 && b5 == 1 && b6 == 1))
                            {
                                a = true;
                                MessageBox.Show("Победили крестики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if ((b1 == 0 && b4 == 0 && b7 == 0) || (b4 == 0 && b5 == 0 && b6 == 0))
                            {
                                a = false;
                                MessageBox.Show("Победили нолики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if (b1 != 10 && b2 != 10 && b3 != 10 && b4 != 10 && b5 != 10 && b6 != 10 && b7 != 10 && b8 != 10 && b9 != 10)
                            {
                                a = false;
                                MessageBox.Show("Ничья");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                        }
                        if (a == true)
                        {
                            a = false;
                        }
                        else
                        {
                            a = true;
                        }
                        if (block == true)
                        {
                            pictureBox1.BackColor = Color.Gray;
                            pictureBox2.BackColor = Color.Gray;
                            pictureBox3.BackColor = Color.Gray;
                            pictureBox4.BackColor = Color.Gray;
                            pictureBox5.BackColor = Color.Gray;
                            pictureBox6.BackColor = Color.Gray;
                            pictureBox7.BackColor = Color.Gray;
                            pictureBox8.BackColor = Color.Gray;
                            pictureBox9.BackColor = Color.Gray;
                            b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                        }
                    }
                }
                if (chel2 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox4.Image == null)
                        {
                            if (b5 == 1)
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox4.Image = bmp;
                                b4 = 0;
                            }
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {

                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b5 == 10)
                                {

                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {

                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {

                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {

                                    b6 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {
                                    ;
                                    b4 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {

                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {

                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {

                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b5 == 1 && b9 == 10)
                                {

                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b1 == 10)
                                {

                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                if (b3 == 0 && b1 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox1.Image = bmp1;
                                    b1 = 1;
                                }
                                else if (b9 == 0 && b7 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox7.Image = bmp1;
                                    b7 = 1;
                                }
                                else if (b1 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox1.Image = bmp1;
                                    b1 = 1;
                                }
                                else if (b7 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox7.Image = bmp1;
                                    b7 = 1;
                                }
                                else if (b1 != 10 && b7 != 10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
                if (chel1 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox4.Image == null)
                        {
                            g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                            pictureBox4.Image = bmp;
                            b4 = 0;
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b9 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b7 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b8 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b6 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 10 && b5 == 1 && b8 == 1)
                                {
                                    b2 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {

                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {

                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {

                                    b6 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {

                                    b4 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {

                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if(b1 == 10 && b7 == 0 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox1.Image = bmp1;
                                    b1 = 1;
                                }
                                else if (b7 == 10 && b1 == 0 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox7.Image = bmp1;
                                    b7 = 1;
                                }
                                else if (b6 == 10 && b5 == 0 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox6.Image = bmp1;
                                    b6 = 1;
                                }
                                else if (b5 == 10 && b6 == 0 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b5 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b2 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox2.Image = bmp1;
                                    b2 = 1;
                                }
                                else if (b7 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox7.Image = bmp1;
                                    b7 = 1;
                                }
                                else if (b1 != 10 && b7 != 10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox5.Width, pictureBox5.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                if (chel1 == true && chel2 == true)
                {
                    if (block == false)
                    {
                        if (pictureBox5.Image == null)
                        {
                            if (a)
                            {
                                g.DrawLine(Pens.Black, 0, 0, 100, 100);
                                g.DrawLine(Pens.Black, 100, 0, 0, 100);
                                pictureBox5.Image = bmp;
                                b5 = 1;
                            }
                            else
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox5.Image = bmp;
                                b5 = 0;
                            }
                            if ((b1 == 1 && b5 == 1 && b9 == 1) || (b3 == 1 && b5 == 1 && b7 == 1) || (b2 == 1 && b5 == 1 && b8 == 1) || (b4 == 1 && b5 == 1 && b6 == 1))
                            {
                                a = true;
                                MessageBox.Show("Победили крестики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if ((b1 == 0 && b5 == 0 && b9 == 0) || (b3 == 0 && b5 == 0 && b7 == 0) || (b2 == 0 && b5 == 0 && b8 == 0) || (b4 == 0 && b5 == 0 && b6 == 0))
                            {
                                a = false;
                                MessageBox.Show("Победили нолики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if (b1 != 10 && b2 != 10 && b3 != 10 && b4 != 10 && b5 != 10 && b6 != 10 && b7 != 10 && b8 != 10 && b9 != 10)
                            {
                                a = false;
                                MessageBox.Show("Ничья");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                        }
                        if (a == true)
                        {
                            a = false;
                        }
                        else
                        {
                            a = true;
                        }
                        if (block == true)
                        {
                            pictureBox1.BackColor = Color.Gray;
                            pictureBox2.BackColor = Color.Gray;
                            pictureBox3.BackColor = Color.Gray;
                            pictureBox4.BackColor = Color.Gray;
                            pictureBox5.BackColor = Color.Gray;
                            pictureBox6.BackColor = Color.Gray;
                            pictureBox7.BackColor = Color.Gray;
                            pictureBox8.BackColor = Color.Gray;
                            pictureBox9.BackColor = Color.Gray;
                            b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                        }
                    }
                }
                if (chel1 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox5.Image == null)
                        {
                            g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                            pictureBox5.Image = bmp;
                            b5 = 0;
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b9 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b7 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b8 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b6 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 10 && b5 == 1 && b8 == 1)
                                {
                                    b2 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {

                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {

                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {

                                    b6 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {

                                    b4 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {

                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 0 && b3 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox3.Image = bmp1;
                                    b3 = 1;
                                }
                                else if (b6 == 0 && b9 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox9.Image = bmp1;
                                    b9 = 1;
                                }
                                else if (b8 == 0 && b7 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox7.Image = bmp1;
                                    b7 = 1;
                                }
                                else if (b4 == 0 && b1 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox1.Image = bmp1;
                                    b1 = 1;
                                }
                                else if (b1 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox1.Image = bmp1;
                                    b1 = 1;
                                }
                                else if (b3 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox3.Image = bmp1;
                                    b3 = 1;
                                }
                                else if (b9 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox9.Image = bmp1;
                                    b9 = 1;
                                }
                                else if (b7 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox7.Image = bmp1;
                                    b7 = 1;
                                }
                                else if (b2 != 10 && b4 != 10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox6.Width, pictureBox6.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                if (chel1 == true && chel2 == true)
                {
                    if (block == false)
                    {
                        if (pictureBox6.Image == null)
                        {
                            if (a)
                            {
                                g.DrawLine(Pens.Black, 0, 0, 100, 100);
                                g.DrawLine(Pens.Black, 100, 0, 0, 100);
                                pictureBox6.Image = bmp;
                                b6 = 1;
                            }
                            else
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox6.Image = bmp;
                                b6 = 0;
                            }
                            if ((b4 == 1 && b5 == 1 && b6 == 1) || (b3 == 1 && b6 == 1 && b9 == 1))
                            {
                                a = true;
                                MessageBox.Show("Победили крестики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if ((b4 == 0 && b5 == 0 && b6 == 0) || (b3 == 0 && b6 == 0 && b9 == 0))
                            {
                                a = false;
                                MessageBox.Show("Победили нолики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if (b1 != 10 && b2 != 10 && b3 != 10 && b4 != 10 && b5 != 10 && b6 != 10 && b7 != 10 && b8 != 10 && b9 != 10)
                            {
                                a = false;
                                MessageBox.Show("Ничья");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                        }
                        if (a == true)
                        {
                            a = false;
                        }
                        else
                        {
                            a = true;
                        }
                        if (block == true)
                        {
                            pictureBox1.BackColor = Color.Gray;
                            pictureBox2.BackColor = Color.Gray;
                            pictureBox3.BackColor = Color.Gray;
                            pictureBox4.BackColor = Color.Gray;
                            pictureBox5.BackColor = Color.Gray;
                            pictureBox6.BackColor = Color.Gray;
                            pictureBox7.BackColor = Color.Gray;
                            pictureBox8.BackColor = Color.Gray;
                            pictureBox9.BackColor = Color.Gray;
                            b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                        }
                    }
                }
                if (chel2 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox6.Image == null)
                        {
                            if (b5 == 1)
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox6.Image = bmp;
                                b6 = 0;
                            }
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                    
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {
                                    
                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b5 == 10)
                                {
                                    
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {
                                    
                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {
                                    
                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {
                                    
                                    b6 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {
                                    
                                    b4 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {
                                    
                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {
                                    
                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {
                                    
                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b1 == 10)
                                {
                                    
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                if (b1 == 0 && b3 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox3.Image = bmp1;
                                    b3 = 1;
                                }
                                else if (b7 == 0 && b9 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox9.Image = bmp1;
                                    b9 = 1;
                                }
                                else if (b3 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox3.Image = bmp1;
                                    b3 = 1;
                                }
                                else if (b9 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox9.Image = bmp1;
                                    b9 = 1;
                                }
                                else if (b3!=10&& b9!=10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
                if (chel1 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox6.Image == null)
                        {
                            g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                            pictureBox6.Image = bmp;
                            b6 = 0;
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b9 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b7 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b8 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b6 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 10 && b5 == 1 && b8 == 1)
                                {
                                    b2 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {

                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {

                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {

                                    b6 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {

                                    b4 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {

                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 0 && b3 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox3.Image = bmp1;
                                    b3 = 1;
                                }
                                else if (b3 == 0 && b9 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox9.Image = bmp1;
                                    b9 = 1;
                                }
                                else if (b4 == 0 && b5 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b5 == 0 && b4 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox4.Image = bmp1;
                                    b4 = 1;
                                }
                                else if (b3 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox3.Image = bmp1;
                                    b3 = 1;
                                }
                                else if (b9 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox9.Image = bmp1;
                                    b9 = 1;
                                }
                                else if (b2 != 10 && b4 != 10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox7.Width, pictureBox7.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                if (chel1 == true && chel2 == true)
                {
                    if (block == false)
                    {
                        if (pictureBox7.Image == null)
                        {
                            if (a)
                            {
                                g.DrawLine(Pens.Black, 0, 0, 100, 100);
                                g.DrawLine(Pens.Black, 100, 0, 0, 100);
                                pictureBox7.Image = bmp;
                                b7 = 1;
                            }
                            else
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox7.Image = bmp;
                                b7 = 0;
                            }
                            if ((b1 == 1 && b4 == 1 && b7 == 1) || (b7 == 1 && b8 == 1 && b9 == 1) || (b3 == 1 && b5 == 1 && b7 == 1))
                            {
                                a = true;
                                MessageBox.Show("Победили крестики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if ((b1 == 0 && b4 == 0 && b7 == 0) || (b7 == 0 && b8 == 0 && b9 == 0) || (b3 == 0 && b5 == 0 && b7 == 0))
                            {
                                a = false;
                                MessageBox.Show("Победили нолики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if (b1 != 10 && b2 != 10 && b3 != 10 && b4 != 10 && b5 != 10 && b6 != 10 && b7 != 10 && b8 != 10 && b9 != 10)
                            {
                                a = false;
                                MessageBox.Show("Ничья");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                        }
                        if (a == true)
                        {
                            a = false;
                        }
                        else
                        {
                            a = true;
                        }
                        if (block == true)
                        {
                            pictureBox1.BackColor = Color.Gray;
                            pictureBox2.BackColor = Color.Gray;
                            pictureBox3.BackColor = Color.Gray;
                            pictureBox4.BackColor = Color.Gray;
                            pictureBox5.BackColor = Color.Gray;
                            pictureBox6.BackColor = Color.Gray;
                            pictureBox7.BackColor = Color.Gray;
                            pictureBox8.BackColor = Color.Gray;
                            pictureBox9.BackColor = Color.Gray;
                            b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                        }
                    }
                }
                if (chel2 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox7.Image == null)
                        {
                            if (b5 == 1)
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox7.Image = bmp;
                                b7 = 0;
                            }
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    
                                    b9 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                    
                                    b1 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {
                                   
                                    b8 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b5 == 10)
                                {
                                    
                                    b5 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {
                                    
                                    b7 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {
                                    
                                    b3 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {
                                    
                                    b6 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {
                                    
                                    b4 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {
                                    
                                    b3 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {
                                    
                                    b7 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {
                                    
                                    b8 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    
                                    b9 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b1 == 10)
                                {
                                    
                                    b1 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                if (b9 == 0 && b8 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox8.Image = bmp1;
                                    b8 = 1;
                                }
                                else if (b1== 0 && b4 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox4.Image = bmp1;
                                    b4 = 1;
                                }
                                else if (b4 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox4.Image = bmp1;
                                    b4 = 1;
                                }
                                else if (b8 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox8.Image = bmp1;
                                    b8 = 1;
                                }
                                else if (b4!=10 && b8!=10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
                if (chel1 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox7.Image == null)
                        {
                            g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                            pictureBox7.Image = bmp;
                            b7 = 0;
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b9 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b7 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b8 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b6 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 10 && b5 == 1 && b8 == 1)
                                {
                                    b2 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {

                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {

                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {

                                    b6 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {

                                    b4 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {

                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 0 && b4 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox4.Image = bmp1;
                                    b4 = 1;
                                }
                                else if (b4 == 0 && b1 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox1.Image = bmp1;
                                    b1 = 1;
                                }
                                else if (b9 == 0 && b8 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox8.Image = bmp1;
                                    b8 = 1;
                                }
                                else if (b8 == 0 && b9 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox9.Image = bmp1;
                                    b9 = 1;
                                }
                                else if (b3 == 0 && b5 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b5 == 0 && b3 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox3.Image = bmp1;
                                    b3 = 1;
                                }
                                else if (b5 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b4 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox4.Image = bmp1;
                                    b4 = 1;
                                }
                                else if (b8 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox8.Image = bmp1;
                                    b8 = 1;
                                }
                                else if (b2 != 10 && b4 != 10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
            }
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox8.Width, pictureBox8.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                if (chel1 == true && chel2 == true)
                {
                    if (block == false)
                    {
                        if (pictureBox8.Image == null)
                        {
                            if (a)
                            {
                                g.DrawLine(Pens.Black, 0, 0, 100, 100);
                                g.DrawLine(Pens.Black, 100, 0, 0, 100);
                                pictureBox8.Image = bmp;
                                b8 = 1;
                            }
                            else
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox8.Image = bmp;
                                b8 = 0;
                            }
                            if ((b2 == 1 && b5 == 1 && b8 == 1) || (b7 == 1 && b8 == 1 && b9 == 1))
                            {
                                a = true;
                                MessageBox.Show("Победили крестики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if ((b2 == 0 && b5 == 0 && b8 == 0) || (b7 == 0 && b8 == 0 && b9 == 0))
                            {
                                a = false;
                                MessageBox.Show("Победили нолики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if (b1 != 10 && b2 != 10 && b3 != 10 && b4 != 10 && b5 != 10 && b6 != 10 && b7 != 10 && b8 != 10 && b9 != 10)
                            {
                                a = false;
                                MessageBox.Show("Ничья");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                        }
                        if (a == true)
                        {
                            a = false;
                        }
                        else
                        {
                            a = true;
                        }
                        if (block == true)
                        {
                            pictureBox1.BackColor = Color.Gray;
                            pictureBox2.BackColor = Color.Gray;
                            pictureBox3.BackColor = Color.Gray;
                            pictureBox4.BackColor = Color.Gray;
                            pictureBox5.BackColor = Color.Gray;
                            pictureBox6.BackColor = Color.Gray;
                            pictureBox7.BackColor = Color.Gray;
                            pictureBox8.BackColor = Color.Gray;
                            pictureBox9.BackColor = Color.Gray;
                            b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                        }
                    }
                }
                if (chel2 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox8.Image == null)
                        {
                            if (b5 == 1)
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox8.Image = bmp;
                                b8 = 0;
                            }
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    
                                    b9 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                    
                                    b1 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {
                                    
                                    b8 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b5 == 10)
                                {
                                    
                                    b5 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {
                                    
                                    b7 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {
                                    
                                    b3 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {
                                    
                                    b6 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {
                                    
                                    b4 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {
                                    
                                    b3 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {
                                    
                                    b7 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {
                                    
                                    b8 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    
                                    b9 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b1 == 10)
                                {
                                    
                                    b1 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 0 && b7 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox7.Image = bmp1;
                                    b7 = 1;
                                }
                                else if (b3 == 0 && b9 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox9.Image = bmp1;
                                    b9 = 1;
                                }
                                else if (b7 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox7.Image = bmp1;
                                    b7 = 1;
                                }
                                else if (b9 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox9.Image = bmp1;
                                    b9 = 1;
                                }
                                else if (b7!=10 && b9!=10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
                if (chel1 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox8.Image == null)
                        {
                            g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                            pictureBox8.Image = bmp;
                            b8 = 0;
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b9 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b7 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b8 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b6 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 10 && b5 == 1 && b8 == 1)
                                {
                                    b2 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {

                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {

                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {

                                    b6 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {

                                    b4 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {

                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 0 && b7 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox7.Image = bmp1;
                                    b7 = 1;
                                }
                                else if (b7 == 0 && b9 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox9.Image = bmp1;
                                    b9 = 1;
                                }
                                else if (b2== 0 && b5 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b5 == 0 && b2 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox2.Image = bmp1;
                                    b2 = 1;
                                }
                                else if (b5 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b7 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox7.Image = bmp1;
                                    b7 = 1;
                                }
                                else if (b9 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox9.Image = bmp1;
                                    b9 = 1;
                                }
                                else if (b2 != 10 && b4 != 10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
            }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox9.Width, pictureBox9.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                if (chel1 == true && chel2 == true)
                {
                    if (block == false)
                    {
                        if (pictureBox9.Image == null)
                        {
                            if (a)
                            {
                                g.DrawLine(Pens.Black, 0, 0, 100, 100);
                                g.DrawLine(Pens.Black, 100, 0, 0, 100);
                                pictureBox9.Image = bmp;
                                b9 = 1;
                            }
                            else
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox9.Image = bmp;
                                b9 = 0;
                            }
                            if ((b3 == 1 && b6 == 1 && b9 == 1) || (b7 == 1 && b8 == 1 && b9 == 1) || (b1 == 1 && b5 == 1 && b9 == 1))
                            {
                                a = true;
                                MessageBox.Show("Победили крестики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if ((b3 == 0 && b6 == 0 && b9 == 0) || (b7 == 0 && b8 == 0 && b9 == 0) || (b1 == 0 && b5 == 0 && b9 == 0))
                            {
                                a = false;
                                MessageBox.Show("Победили нолики");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                            else if (b1 != 10 && b2 != 10 && b3 != 10 && b4 != 10 && b5 != 10 && b6 != 10 && b7 != 10 && b8 != 10 && b9 != 10)
                            {
                                a = false;
                                MessageBox.Show("Ничья");
                                foreach (var pb in Controls.OfType<PictureBox>())
                                {
                                    pb.Image = null;
                                }
                                block = true;
                            }
                        }
                        if (a == true)
                        {
                            a = false;
                        }
                        else
                        {
                            a = true;
                        }
                        if (block == true)
                        {
                            pictureBox1.BackColor = Color.Gray;
                            pictureBox2.BackColor = Color.Gray;
                            pictureBox3.BackColor = Color.Gray;
                            pictureBox4.BackColor = Color.Gray;
                            pictureBox5.BackColor = Color.Gray;
                            pictureBox6.BackColor = Color.Gray;
                            pictureBox7.BackColor = Color.Gray;
                            pictureBox8.BackColor = Color.Gray;
                            pictureBox9.BackColor = Color.Gray;
                            b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                        }
                    }
                }
                if (chel2 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox9.Image == null)
                        {
                            if (b5 == 1)
                            {
                                g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                                pictureBox9.Image = bmp;
                                b9 = 0;
                            }
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    
                                    b9 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                    
                                    b1 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {
                                    
                                    b8 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b5 == 10)
                                {
                                    
                                    b5 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {
                                    ;
                                    b7 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {
                                    
                                    b3 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {
                                    
                                    b6 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {
                                    
                                    b4 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {
                                    
                                    b3 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {
                                    
                                    b7 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {
                                    
                                    b8 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    
                                    b9 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b9 == 1 && b5 == 1 && b1 == 10)
                                {
                                    
                                    b1 = 1;
                                    a = true;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                if (b3 == 0 && b6 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox6.Image = bmp1;
                                    b6 = 1;
                                }
                                else if (b7 == 0 && b8 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox8.Image = bmp1;
                                    b8 = 1;
                                }
                                else if (b6 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox6.Image = bmp1;
                                    b6 = 1;
                                }
                                else if (b8 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox8.Image = bmp1;
                                    b8 = 1;
                                }
                                else if (b6!=10 && b8!=10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;   
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
                if (chel1 == false)
                {
                    if (block == false)
                    {
                        if (pictureBox9.Image == null)
                        {
                            g.DrawEllipse(Pens.Black, 10, 10, 75, 75);
                            pictureBox9.Image = bmp;
                            b9 = 0;
                            Bitmap bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            using (Graphics g1 = Graphics.FromImage(bmp1))
                            {
                                if (b1 == 1 && b5 == 1 && b9 == 10)
                                {
                                    b9 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b1 == 1 && b9 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b7 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b8 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b6 == 1 && b5 == 10)
                                {
                                    b5 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b5 == 1 && b9 == 1 && b1 == 10)
                                {
                                    b1 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 10 && b5 == 1 && b8 == 1)
                                {
                                    b2 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 1 && b5 == 1 && b7 == 10)
                                {

                                    b7 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b7 == 1 && b5 == 1 && b3 == 10)
                                {

                                    b3 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b4 == 1 && b5 == 1 && b6 == 10)
                                {

                                    b6 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b6 == 1 && b5 == 1 && b4 == 10)
                                {

                                    b4 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b2 == 1 && b5 == 1 && b8 == 10)
                                {

                                    b8 = 1;
                                    a = false;
                                    MessageBox.Show("Победили крестики");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                                else if (b3 == 0 && b6 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox6.Image = bmp1;
                                    b6 = 1;
                                }
                                else if (b6 == 0 && b3 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox3.Image = bmp1;
                                    b3 = 1;
                                }
                                else if (b7 == 0 && b8 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox8.Image = bmp1;
                                    b8 = 1;
                                }
                                else if (b8 == 0 && b7 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox7.Image = bmp1;
                                    b7 = 1;
                                }
                                else if (b1 == 0 && b5 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b5 == 0 && b1 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox1.Image = bmp1;
                                    b1 = 1;
                                }
                                else if (b5 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox5.Image = bmp1;
                                    b5 = 1;
                                }
                                else if (b6 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox6.Image = bmp1;
                                    b6 = 1;
                                }
                                else if (b8 == 10 && block == false)
                                {
                                    g1.DrawLine(Pens.Black, 0, 0, 100, 100);
                                    g1.DrawLine(Pens.Black, 100, 0, 0, 100);
                                    pictureBox8.Image = bmp1;
                                    b8 = 1;
                                }
                                else if (b2 != 10 && b4 != 10 && block == false)
                                {
                                    a = false;
                                    MessageBox.Show("Ничья");
                                    foreach (var pb in Controls.OfType<PictureBox>())
                                    {
                                        pb.Image = null;
                                    }
                                    block = true;
                                }
                            }
                            if (block == true)
                            {
                                pictureBox1.BackColor = Color.Gray;
                                pictureBox2.BackColor = Color.Gray;
                                pictureBox3.BackColor = Color.Gray;
                                pictureBox4.BackColor = Color.Gray;
                                pictureBox5.BackColor = Color.Gray;
                                pictureBox6.BackColor = Color.Gray;
                                pictureBox7.BackColor = Color.Gray;
                                pictureBox8.BackColor = Color.Gray;
                                pictureBox9.BackColor = Color.Gray;
                                b1 = b2 = b3 = b4 = b5 = b6 = b7 = b8 = b9 = 10;
                            }
                        }
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            groupBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Выберите ход");
            }
            if (radioButton1.Checked == true)
            {
                groupBox1.Visible = false;
                chel1 = false;
                block = false;
                pictureBox1.BackColor = Color.White;
                pictureBox2.BackColor = Color.White;
                pictureBox3.BackColor = Color.White;
                pictureBox4.BackColor = Color.White;
                pictureBox5.BackColor = Color.White;
                pictureBox6.BackColor = Color.White;
                pictureBox7.BackColor = Color.White;
                pictureBox8.BackColor = Color.White;
                pictureBox9.BackColor = Color.White;
            }
            if (radioButton2.Checked == true)
            {
                groupBox1.Visible = false;
                chel2 = false;
                block = false;
                pictureBox1.BackColor = Color.White;
                pictureBox2.BackColor = Color.White;
                pictureBox3.BackColor = Color.White;
                pictureBox4.BackColor = Color.White;
                pictureBox5.BackColor = Color.White;
                pictureBox6.BackColor = Color.White;
                pictureBox7.BackColor = Color.White;
                pictureBox8.BackColor = Color.White;
                pictureBox9.BackColor = Color.White;
                Bitmap bmp = new Bitmap(pictureBox9.Width, pictureBox9.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawLine(Pens.Black, 0, 0, 100, 100);
                    g.DrawLine(Pens.Black, 100, 0, 0, 100);
                    pictureBox5.Image = bmp;
                    b5 = 1;
                    a = false;
                }
            }
        }
    }
}
