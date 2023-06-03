using System;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using System.Drawing;

// моя: dabb

namespace KG3
{
    public partial class formMain : Form
    {
        private double _Radius = 5;
        private double _Height = 5;
        private int _Slices = 5;

        public formMain()
        {
            InitializeComponent();
            AnT.InitializeContexts();
            dgvLights.RowCount = 1;
        }

        private void AnT_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);

            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glEnable(Gl.GL_LIGHTING);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            double W = 3;
            double H = W * AnT.Height / AnT.Width;
            Gl.glFrustum(-W, W, -H, H, 2, 12);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, new float[] { 0, 0, 1, 1 });
        }

        private void AnT_MouseMove(object sender, MouseEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glPushMatrix();

            Gl.glTranslated(0, 0, -8);
            Gl.glRotated((e.X - AnT.Width) * 360 / AnT.Width, 0, 1, 0);
            Gl.glRotated((e.Y - AnT.Height) * 360 / AnT.Height, 1, 0, 0);

            Gl.glColor3f(1, 1, 1);
            Glut.glutSolidCone(_Radius, _Height, _Slices, 1);

            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }

        private void dgvLights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && DialogResult.OK == colorDialog.ShowDialog())
                dgvLights.Rows[e.RowIndex].Cells[3].Value = colorDialog.Color;
        }

        private void bLight_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow r in dgvLights.Rows)
                {
                    Gl.glEnable(Gl.GL_LIGHT0 + r.Index);
                    float[] pos =
                    {
                        float.Parse((string) r.Cells[0].Value),
                        float.Parse((string) r.Cells[1].Value),
                        float.Parse((string) r.Cells[2].Value),
                        1
                    };
                    Gl.glLightfv(Gl.GL_LIGHT0 + r.Index, Gl.GL_POSITION, pos);

                    float[] color =
                    {
                        ((Color) r.Cells[3].Value).R / (float) 255,
                        ((Color) r.Cells[3].Value).G / (float) 255,
                        ((Color) r.Cells[3].Value).B / (float) 255,
                        1
                    };
                    Gl.glLightfv(Gl.GL_LIGHT0 + r.Index, Gl.GL_DIFFUSE, color);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входных данных!");
            }
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbLightsCount.Text))
                {
                    dgvLights.RowCount = int.Parse(tbLightsCount.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входных данных!");
                tbLightsCount.Clear();
            }

            try
            {
                if (!string.IsNullOrEmpty(tbRadius.Text))
                    _Radius = double.Parse(tbRadius.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входных данных!");
                tbRadius.Clear();
            }

            try
            {
                if (!string.IsNullOrEmpty(tbHeight.Text))
                    _Height = double.Parse(tbHeight.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входных данных!");
                tbHeight.Clear();
            }

            try
            {
                if (!string.IsNullOrEmpty(tbDivisions.Text))
                    _Slices = int.Parse(tbDivisions.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входных данных!");
                tbDivisions.Clear();
            }
        }
    }
}