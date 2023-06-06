using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab_2
{
    public partial class formMain : Form
    {
        private Color brush = Color.Gray;

        public formMain()
        {
            InitializeComponent();
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            Scene s = new Scene(pbPyramide.Height, pbPyramide.Width, brush);
            s.MakePyramide(int.Parse(textBoxBoxSize.Text), int.Parse(textBoxBaseRadius.Text), int.Parse(textBoxSideCount.Text));
            s.AddCamera(new Camera(new Vertex(textBoxCamPos.Text), new Vertex(textBoxCamDir.Text).Minus(new Vertex(textBoxCamPos.Text)), (double) udAngle.Value));
            s.LightPoint = new Vertex(textBoxLights.Text);
            s.Render();
            pbPyramide.Image = s.Pic;
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                brush = colorDialog.Color;
            }
        }
    }
}