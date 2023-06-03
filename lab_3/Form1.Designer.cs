namespace KG3
{
    partial class formMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.bLight = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbDivisions = new System.Windows.Forms.TextBox();
            this.lRadius = new System.Windows.Forms.Label();
            this.lHeight = new System.Windows.Forms.Label();
            this.lDivisions = new System.Windows.Forms.Label();
            this.tlpOuter = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSide = new System.Windows.Forms.TableLayoutPanel();
            this.tbLightsCount = new System.Windows.Forms.TextBox();
            this.dgvLights = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lLightsCount = new System.Windows.Forms.Label();
            this.tlpOuter.SuspendLayout();
            this.tlpSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLights)).BeginInit();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = true;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSize = true;
            this.AnT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnT.Location = new System.Drawing.Point(0, 0);
            this.AnT.Margin = new System.Windows.Forms.Padding(0);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(921, 661);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.Load += new System.EventHandler(this.AnT_Load);
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // bLight
            // 
            this.bLight.AutoSize = true;
            this.bLight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpSide.SetColumnSpan(this.bLight, 2);
            this.bLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bLight.Location = new System.Drawing.Point(25, 227);
            this.bLight.Margin = new System.Windows.Forms.Padding(25, 35, 25, 35);
            this.bLight.Name = "bLight";
            this.bLight.Size = new System.Drawing.Size(213, 34);
            this.bLight.TabIndex = 1;
            this.bLight.Text = "Осветить";
            this.bLight.Click += new System.EventHandler(this.bLight_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            this.colorDialog.SolidColorOnly = true;
            // 
            // tbRadius
            // 
            this.tbRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRadius.Location = new System.Drawing.Point(122, 299);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(138, 23);
            this.tbRadius.TabIndex = 3;
            this.tbRadius.Text = "5";
            this.tbRadius.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbHeight
            // 
            this.tbHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHeight.Location = new System.Drawing.Point(122, 328);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(138, 23);
            this.tbHeight.TabIndex = 4;
            this.tbHeight.Text = "5";
            this.tbHeight.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbDivisions
            // 
            this.tbDivisions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDivisions.Location = new System.Drawing.Point(122, 357);
            this.tbDivisions.Name = "tbDivisions";
            this.tbDivisions.Size = new System.Drawing.Size(138, 23);
            this.tbDivisions.TabIndex = 5;
            this.tbDivisions.Text = "5";
            this.tbDivisions.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // lRadius
            // 
            this.lRadius.AutoSize = true;
            this.lRadius.Location = new System.Drawing.Point(3, 302);
            this.lRadius.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lRadius.Name = "lRadius";
            this.lRadius.Size = new System.Drawing.Size(45, 15);
            this.lRadius.TabIndex = 6;
            this.lRadius.Text = "Радиус";
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(3, 331);
            this.lHeight.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(47, 15);
            this.lHeight.TabIndex = 7;
            this.lHeight.Text = "Высота";
            // 
            // lDivisions
            // 
            this.lDivisions.AutoSize = true;
            this.lDivisions.Location = new System.Drawing.Point(3, 360);
            this.lDivisions.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lDivisions.Name = "lDivisions";
            this.lDivisions.Size = new System.Drawing.Size(113, 15);
            this.lDivisions.TabIndex = 8;
            this.lDivisions.Text = "Количество граней";
            // 
            // tlpOuter
            // 
            this.tlpOuter.AutoSize = true;
            this.tlpOuter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOuter.ColumnCount = 2;
            this.tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOuter.Controls.Add(this.tlpSide, 1, 0);
            this.tlpOuter.Controls.Add(this.AnT, 0, 0);
            this.tlpOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOuter.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpOuter.Location = new System.Drawing.Point(0, 0);
            this.tlpOuter.Margin = new System.Windows.Forms.Padding(0);
            this.tlpOuter.Name = "tlpOuter";
            this.tlpOuter.RowCount = 1;
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOuter.Size = new System.Drawing.Size(1184, 661);
            this.tlpOuter.TabIndex = 10;
            // 
            // tlpSide
            // 
            this.tlpSide.AutoSize = true;
            this.tlpSide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpSide.ColumnCount = 2;
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSide.Controls.Add(this.tbLightsCount, 1, 1);
            this.tlpSide.Controls.Add(this.bLight, 0, 2);
            this.tlpSide.Controls.Add(this.tbDivisions, 1, 5);
            this.tlpSide.Controls.Add(this.lDivisions, 0, 5);
            this.tlpSide.Controls.Add(this.tbHeight, 1, 4);
            this.tlpSide.Controls.Add(this.lHeight, 0, 4);
            this.tlpSide.Controls.Add(this.lRadius, 0, 3);
            this.tlpSide.Controls.Add(this.tbRadius, 1, 3);
            this.tlpSide.Controls.Add(this.dgvLights, 0, 0);
            this.tlpSide.Controls.Add(this.lLightsCount, 0, 1);
            this.tlpSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSide.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpSide.Location = new System.Drawing.Point(921, 0);
            this.tlpSide.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSide.Name = "tlpSide";
            this.tlpSide.RowCount = 6;
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSide.Size = new System.Drawing.Size(263, 661);
            this.tlpSide.TabIndex = 11;
            // 
            // tbLightsCount
            // 
            this.tbLightsCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLightsCount.Location = new System.Drawing.Point(122, 163);
            this.tbLightsCount.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.tbLightsCount.Name = "tbLightsCount";
            this.tbLightsCount.Size = new System.Drawing.Size(138, 23);
            this.tbLightsCount.TabIndex = 12;
            this.tbLightsCount.Text = "1";
            this.tbLightsCount.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // dgvLights
            // 
            this.dgvLights.AllowUserToAddRows = false;
            this.dgvLights.AllowUserToDeleteRows = false;
            this.dgvLights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLights.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvLights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y,
            this.Z,
            this.Color});
            this.tlpSide.SetColumnSpan(this.dgvLights, 2);
            this.dgvLights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLights.Location = new System.Drawing.Point(3, 3);
            this.dgvLights.Name = "dgvLights";
            this.dgvLights.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLights.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvLights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLights.Size = new System.Drawing.Size(257, 150);
            this.dgvLights.TabIndex = 10;
            this.dgvLights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLights_CellContentClick);
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 38;
            // 
            // Y
            // 
            this.Y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.Width = 37;
            // 
            // Z
            // 
            this.Z.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Z.HeaderText = "Z";
            this.Z.Name = "Z";
            this.Z.Width = 37;
            // 
            // Color
            // 
            this.Color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Color.HeaderText = "Цвет";
            this.Color.Name = "Color";
            // 
            // lLightsCount
            // 
            this.lLightsCount.AutoSize = true;
            this.lLightsCount.Location = new System.Drawing.Point(3, 159);
            this.lLightsCount.Margin = new System.Windows.Forms.Padding(3);
            this.lLightsCount.Name = "lLightsCount";
            this.lLightsCount.Size = new System.Drawing.Size(104, 30);
            this.lLightsCount.TabIndex = 11;
            this.lLightsCount.Text = "Количество\r\nисточников света";
            this.lLightsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tlpOuter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "formMain";
            this.ShowIcon = false;
            this.tlpOuter.ResumeLayout(false);
            this.tlpOuter.PerformLayout();
            this.tlpSide.ResumeLayout(false);
            this.tlpSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Button bLight;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbDivisions;
        private System.Windows.Forms.Label lRadius;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.Label lDivisions;
        private System.Windows.Forms.TableLayoutPanel tlpOuter;
        private System.Windows.Forms.TableLayoutPanel tlpSide;
        private System.Windows.Forms.DataGridView dgvLights;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.DataGridViewButtonColumn Color;
        private System.Windows.Forms.Label lLightsCount;
        private System.Windows.Forms.TextBox tbLightsCount;
    }
}

