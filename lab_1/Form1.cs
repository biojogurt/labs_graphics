using System.Windows.Forms;

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
            numericUpDown3.Maximum = pictureBox1.Width > pictureBox1.Height ? pictureBox1.Height / 2 : pictureBox1.Width / 2;
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
            int r = (int) numericUpDown3.Value;

            if (x0 - r < 0 || y0 - r < 0 || x0 + r > pictureBox1.Width || y0 + r > pictureBox1.Height)
            {
                MessageBox.Show("Выход за границу поля");
                return;
            }

            pictureBox1.Image = DrawCircle(x0, y0, r);
        }

        private void DrawPixel(Bitmap bitmap, int x0, int y0, int x, int y)
        {
            bitmap.SetPixel(x + x0, y + y0, color);
            bitmap.SetPixel(-x + x0, y + y0, color);
            bitmap.SetPixel(x + x0, -y + y0, color);
            bitmap.SetPixel(-x + x0, -y + y0, color);
            bitmap.SetPixel(y + x0, x + y0, color);
            bitmap.SetPixel(y + x0, -x + y0, color);
            bitmap.SetPixel(-y + x0, x + y0, color);
            bitmap.SetPixel(-y + x0, -x + y0, color);
        }

        private Bitmap DrawCircle(int x0, int y0, int r)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            int x = 0;
            int y = r;
            int d = 3 - (2 * r);
            DrawPixel(bitmap, x0, y0, x, y);

            for (; x <= y; x++)
            {
                if (d > 0)
                {
                    y--;
                    d += (4 * (x - y)) + 10;
                }
                else
                {
                    d += (4 * x) + 6;
                }

                DrawPixel(bitmap, x0, y0, x, y);
            }

            return bitmap;
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = pictureBox1.Width;
            numericUpDown2.Maximum = pictureBox1.Height;
            numericUpDown3.Maximum = pictureBox1.Width > pictureBox1.Height ? pictureBox1.Height / 2 : pictureBox1.Width / 2;
        }
    }
}