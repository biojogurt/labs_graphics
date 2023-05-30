namespace CircleDraw
{
    public partial class Form1 : Form
    {
        private Color color = Color.White;

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Maximum = pictureBox1.Width;
            numericUpDown2.Maximum = pictureBox1.Height;
            numericUpDown3.Maximum = pictureBox1.Width / 2;
            numericUpDown4.Maximum = pictureBox1.Height / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x0 = (int) numericUpDown1.Value;
            int y0 = (int) numericUpDown2.Value;
            int rx = (int) numericUpDown3.Value;
            int ry = (int) numericUpDown4.Value;

            if (x0 - rx < 0 || y0 - ry < 0 || x0 + rx > pictureBox1.Width || y0 + ry > pictureBox1.Height)
            {
                MessageBox.Show("Выход за границу поля");
                return;
            }

            pictureBox1.Image = drawEllipse(x0, y0, rx, ry);
        }

        private Bitmap drawEllipse(int x0, int y0, int rx, int ry)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            int x = 0;
            int y = ry;
            int dx = 2 * ry * ry * x;
            int dy = 2 * rx * rx * y;
            double d1 = (ry * ry) - (rx * rx * ry) + (0.25 * rx * rx);

            while (dx < dy)
            {
                bitmap.SetPixel(x + x0, y + y0, color);
                bitmap.SetPixel(-x + x0, -y + y0, color);
                bitmap.SetPixel(-x + x0, y + y0, color);
                bitmap.SetPixel(x + x0, -y + y0, color);

                x++;
                dx += 2 * ry * ry;

                if (d1 < 0)
                {
                    d1 += dx + (ry * ry);
                }
                else
                {
                    y--;
                    dy -= 2 * rx * rx;
                    d1 += dx - dy + (ry * ry);
                }
            }

            double d2 = (ry * ry * (x + 0.5) * (x + 0.5))
                      + (rx * rx * (y - 1) * (y - 1))
                      - (rx * rx * ry * ry);

            while (y >= 0)
            {
                bitmap.SetPixel(x + x0, y + y0, color);
                bitmap.SetPixel(-x + x0, -y + y0, color);
                bitmap.SetPixel(-x + x0, y + y0, color);
                bitmap.SetPixel(x + x0, -y + y0, color);

                y--;
                dy -= 2 * rx * rx;

                if (d2 > 0)
                {
                    d2 += (rx * rx) - dy;
                }
                else
                {
                    x++;
                    dx += 2 * ry * ry;
                    d2 += dx - dy + (rx * rx);
                }
            }

            return bitmap;
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = pictureBox1.Width;
            numericUpDown2.Maximum = pictureBox1.Height;
            numericUpDown3.Maximum = pictureBox1.Width / 2;
            numericUpDown4.Maximum = pictureBox1.Height / 2;
        }
    }
}