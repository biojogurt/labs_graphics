namespace lab_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            numericUpDown3 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize) pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize) numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize) numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(109, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel1.SetRowSpan(pictureBox1, 8);
            pictureBox1.Size = new Size(691, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Resize += pictureBox1_Resize;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(numericUpDown3, 0, 5);
            tableLayoutPanel1.Controls.Add(button1, 0, 6);
            tableLayoutPanel1.Controls.Add(button2, 0, 7);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Центр (x)";
            // 
            // numericUpDown1
            // 
            numericUpDown1.AutoSize = true;
            numericUpDown1.Dock = DockStyle.Top;
            numericUpDown1.Location = new Point(3, 24);
            numericUpDown1.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(103, 23);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.Value = new decimal(new int[] { 110, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 53);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Центр (y)";
            // 
            // numericUpDown2
            // 
            numericUpDown2.AutoSize = true;
            numericUpDown2.Dock = DockStyle.Top;
            numericUpDown2.Location = new Point(3, 74);
            numericUpDown2.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(103, 23);
            numericUpDown2.TabIndex = 10;
            numericUpDown2.Value = new decimal(new int[] { 110, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 103);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "Радиус";
            // 
            // numericUpDown3
            // 
            numericUpDown3.AutoSize = true;
            numericUpDown3.Dock = DockStyle.Top;
            numericUpDown3.Location = new Point(3, 124);
            numericUpDown3.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(103, 23);
            numericUpDown3.TabIndex = 11;
            numericUpDown3.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(3, 153);
            button1.Name = "button1";
            button1.Size = new Size(103, 25);
            button1.TabIndex = 5;
            button1.Text = "Выбрать цвет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(3, 184);
            button2.Name = "button2";
            button2.Size = new Size(103, 25);
            button2.TabIndex = 6;
            button2.Text = "Построить круг";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            colorDialog1.FullOpen = true;
            colorDialog1.SolidColorOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize) pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize) numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize) numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Button button1;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private ColorDialog colorDialog1;
    }
}