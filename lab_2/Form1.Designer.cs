namespace lab_2
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPyramide = new System.Windows.Forms.PictureBox();
            this.btnPaint = new System.Windows.Forms.Button();
            this.gbCam = new System.Windows.Forms.GroupBox();
            this.udAngle = new System.Windows.Forms.NumericUpDown();
            this.lAngle = new System.Windows.Forms.Label();
            this.textBoxCamDir = new System.Windows.Forms.TextBox();
            this.textBoxCamPos = new System.Windows.Forms.TextBox();
            this.lDirection = new System.Windows.Forms.Label();
            this.lLocation = new System.Windows.Forms.Label();
            this.textBoxBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxLights = new System.Windows.Forms.TextBox();
            this.textBoxSideCount = new System.Windows.Forms.TextBox();
            this.textBoxBaseRadius = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.flpSide = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCam = new System.Windows.Forms.FlowLayoutPanel();
            this.lHeight = new System.Windows.Forms.Label();
            this.lRadius = new System.Windows.Forms.Label();
            this.lSides = new System.Windows.Forms.Label();
            this.lLightDirection = new System.Windows.Forms.Label();
            this.gbMisc = new System.Windows.Forms.GroupBox();
            this.flpMisc = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPyramide)).BeginInit();
            this.gbCam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udAngle)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.flpSide.SuspendLayout();
            this.flpCam.SuspendLayout();
            this.gbMisc.SuspendLayout();
            this.flpMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPyramide
            // 
            this.pbPyramide.BackColor = System.Drawing.Color.White;
            this.pbPyramide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPyramide.Location = new System.Drawing.Point(167, 3);
            this.pbPyramide.Name = "pbPyramide";
            this.pbPyramide.Size = new System.Drawing.Size(1014, 705);
            this.pbPyramide.TabIndex = 0;
            this.pbPyramide.TabStop = false;
            // 
            // btnPaint
            // 
            this.btnPaint.AutoSize = true;
            this.btnPaint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPaint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPaint.Location = new System.Drawing.Point(3, 428);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(67, 25);
            this.btnPaint.TabIndex = 1;
            this.btnPaint.Text = "Рисовать";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // gbCam
            // 
            this.gbCam.AutoSize = true;
            this.gbCam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbCam.Controls.Add(this.flpCam);
            this.gbCam.Location = new System.Drawing.Point(3, 3);
            this.gbCam.Name = "gbCam";
            this.gbCam.Size = new System.Drawing.Size(152, 154);
            this.gbCam.TabIndex = 2;
            this.gbCam.TabStop = false;
            this.gbCam.Text = "Камера";
            // 
            // udAngle
            // 
            this.udAngle.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udAngle.Location = new System.Drawing.Point(3, 106);
            this.udAngle.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.udAngle.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.udAngle.Name = "udAngle";
            this.udAngle.Size = new System.Drawing.Size(140, 23);
            this.udAngle.TabIndex = 5;
            this.udAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // lAngle
            // 
            this.lAngle.AutoSize = true;
            this.lAngle.Location = new System.Drawing.Point(3, 88);
            this.lAngle.Name = "lAngle";
            this.lAngle.Size = new System.Drawing.Size(78, 15);
            this.lAngle.TabIndex = 4;
            this.lAngle.Text = "Угол обзора:";
            // 
            // textBoxCamDir
            // 
            this.textBoxCamDir.Location = new System.Drawing.Point(3, 62);
            this.textBoxCamDir.Name = "textBoxCamDir";
            this.textBoxCamDir.Size = new System.Drawing.Size(140, 23);
            this.textBoxCamDir.TabIndex = 3;
            this.textBoxCamDir.Text = "0 0 0";
            // 
            // textBoxCamPos
            // 
            this.textBoxCamPos.Location = new System.Drawing.Point(3, 18);
            this.textBoxCamPos.Name = "textBoxCamPos";
            this.textBoxCamPos.Size = new System.Drawing.Size(140, 23);
            this.textBoxCamPos.TabIndex = 2;
            this.textBoxCamPos.Text = "11 15 7";
            // 
            // lDirection
            // 
            this.lDirection.AutoSize = true;
            this.lDirection.Location = new System.Drawing.Point(3, 44);
            this.lDirection.Name = "lDirection";
            this.lDirection.Size = new System.Drawing.Size(81, 15);
            this.lDirection.TabIndex = 1;
            this.lDirection.Text = "Направление";
            // 
            // lLocation
            // 
            this.lLocation.AutoSize = true;
            this.lLocation.Location = new System.Drawing.Point(3, 0);
            this.lLocation.Name = "lLocation";
            this.lLocation.Size = new System.Drawing.Size(75, 15);
            this.lLocation.TabIndex = 0;
            this.lLocation.Text = "Положение:";
            // 
            // textBoxBoxSize
            // 
            this.textBoxBoxSize.Location = new System.Drawing.Point(3, 18);
            this.textBoxBoxSize.Name = "textBoxBoxSize";
            this.textBoxBoxSize.Size = new System.Drawing.Size(140, 23);
            this.textBoxBoxSize.TabIndex = 3;
            this.textBoxBoxSize.Text = "10";
            // 
            // textBoxLights
            // 
            this.textBoxLights.Location = new System.Drawing.Point(3, 180);
            this.textBoxLights.Name = "textBoxLights";
            this.textBoxLights.Size = new System.Drawing.Size(140, 23);
            this.textBoxLights.TabIndex = 4;
            this.textBoxLights.Text = "1 1 1";
            // 
            // textBoxSideCount
            // 
            this.textBoxSideCount.Location = new System.Drawing.Point(3, 121);
            this.textBoxSideCount.Name = "textBoxSideCount";
            this.textBoxSideCount.Size = new System.Drawing.Size(140, 23);
            this.textBoxSideCount.TabIndex = 7;
            this.textBoxSideCount.Text = "10";
            // 
            // textBoxBaseRadius
            // 
            this.textBoxBaseRadius.Location = new System.Drawing.Point(3, 62);
            this.textBoxBaseRadius.Name = "textBoxBaseRadius";
            this.textBoxBaseRadius.Size = new System.Drawing.Size(140, 23);
            this.textBoxBaseRadius.TabIndex = 4;
            this.textBoxBaseRadius.Text = "10";
            // 
            // btnColor
            // 
            this.btnColor.AutoSize = true;
            this.btnColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnColor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnColor.Location = new System.Drawing.Point(3, 397);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(43, 25);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "Цвет";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.Color.RoyalBlue;
            this.colorDialog.FullOpen = true;
            this.colorDialog.SolidColorOnly = true;
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pbPyramide, 1, 0);
            this.tlpMain.Controls.Add(this.flpSide, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(1184, 711);
            this.tlpMain.TabIndex = 7;
            // 
            // flpSide
            // 
            this.flpSide.AutoSize = true;
            this.flpSide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpSide.Controls.Add(this.gbCam);
            this.flpSide.Controls.Add(this.gbMisc);
            this.flpSide.Controls.Add(this.btnColor);
            this.flpSide.Controls.Add(this.btnPaint);
            this.flpSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSide.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSide.Location = new System.Drawing.Point(3, 3);
            this.flpSide.Name = "flpSide";
            this.flpSide.Size = new System.Drawing.Size(158, 705);
            this.flpSide.TabIndex = 1;
            this.flpSide.WrapContents = false;
            // 
            // flpCam
            // 
            this.flpCam.AutoSize = true;
            this.flpCam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpCam.Controls.Add(this.lLocation);
            this.flpCam.Controls.Add(this.textBoxCamPos);
            this.flpCam.Controls.Add(this.lDirection);
            this.flpCam.Controls.Add(this.textBoxCamDir);
            this.flpCam.Controls.Add(this.lAngle);
            this.flpCam.Controls.Add(this.udAngle);
            this.flpCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCam.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCam.Location = new System.Drawing.Point(3, 19);
            this.flpCam.Margin = new System.Windows.Forms.Padding(0);
            this.flpCam.Name = "flpCam";
            this.flpCam.Size = new System.Drawing.Size(146, 132);
            this.flpCam.TabIndex = 10;
            this.flpCam.WrapContents = false;
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(3, 0);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(111, 15);
            this.lHeight.TabIndex = 10;
            this.lHeight.Text = "Высота пирамиды:";
            // 
            // lRadius
            // 
            this.lRadius.AutoSize = true;
            this.lRadius.Location = new System.Drawing.Point(3, 44);
            this.lRadius.Name = "lRadius";
            this.lRadius.Size = new System.Drawing.Size(110, 15);
            this.lRadius.TabIndex = 11;
            this.lRadius.Text = "Радиус основания:";
            // 
            // lSides
            // 
            this.lSides.AutoSize = true;
            this.lSides.Location = new System.Drawing.Point(3, 88);
            this.lSides.Name = "lSides";
            this.lSides.Size = new System.Drawing.Size(99, 30);
            this.lSides.TabIndex = 12;
            this.lSides.Text = "Количество\r\nбоковых граней:";
            // 
            // lLightDirection
            // 
            this.lLightDirection.AutoSize = true;
            this.lLightDirection.Location = new System.Drawing.Point(3, 147);
            this.lLightDirection.Name = "lLightDirection";
            this.lLightDirection.Size = new System.Drawing.Size(81, 30);
            this.lLightDirection.TabIndex = 13;
            this.lLightDirection.Text = "Направление\r\nосвещения:";
            // 
            // gbMisc
            // 
            this.gbMisc.AutoSize = true;
            this.gbMisc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbMisc.Controls.Add(this.flpMisc);
            this.gbMisc.Location = new System.Drawing.Point(3, 163);
            this.gbMisc.Name = "gbMisc";
            this.gbMisc.Size = new System.Drawing.Size(152, 228);
            this.gbMisc.TabIndex = 14;
            this.gbMisc.TabStop = false;
            // 
            // flpMisc
            // 
            this.flpMisc.AutoSize = true;
            this.flpMisc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMisc.Controls.Add(this.lHeight);
            this.flpMisc.Controls.Add(this.textBoxBoxSize);
            this.flpMisc.Controls.Add(this.lRadius);
            this.flpMisc.Controls.Add(this.textBoxBaseRadius);
            this.flpMisc.Controls.Add(this.lSides);
            this.flpMisc.Controls.Add(this.textBoxSideCount);
            this.flpMisc.Controls.Add(this.lLightDirection);
            this.flpMisc.Controls.Add(this.textBoxLights);
            this.flpMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMisc.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMisc.Location = new System.Drawing.Point(3, 19);
            this.flpMisc.Margin = new System.Windows.Forms.Padding(0);
            this.flpMisc.Name = "flpMisc";
            this.flpMisc.Size = new System.Drawing.Size(146, 206);
            this.flpMisc.TabIndex = 0;
            this.flpMisc.WrapContents = false;
            // 
            // formMain
            // 
            this.AcceptButton = this.btnPaint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "formMain";
            this.ShowIcon = false;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbPyramide)).EndInit();
            this.gbCam.ResumeLayout(false);
            this.gbCam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udAngle)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.flpSide.ResumeLayout(false);
            this.flpSide.PerformLayout();
            this.flpCam.ResumeLayout(false);
            this.flpCam.PerformLayout();
            this.gbMisc.ResumeLayout(false);
            this.gbMisc.PerformLayout();
            this.flpMisc.ResumeLayout(false);
            this.flpMisc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPyramide;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.GroupBox gbCam;
        private System.Windows.Forms.TextBox textBoxCamDir;
        private System.Windows.Forms.TextBox textBoxCamPos;
        private System.Windows.Forms.Label lDirection;
        private System.Windows.Forms.Label lLocation;
        private System.Windows.Forms.TextBox textBoxBoxSize;
        private System.Windows.Forms.TextBox textBoxLights;
        private System.Windows.Forms.NumericUpDown udAngle;
        private System.Windows.Forms.Label lAngle;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox textBoxSideCount;
        private System.Windows.Forms.TextBox textBoxBaseRadius;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.FlowLayoutPanel flpSide;
        private System.Windows.Forms.FlowLayoutPanel flpCam;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.Label lRadius;
        private System.Windows.Forms.Label lSides;
        private System.Windows.Forms.Label lLightDirection;
        private System.Windows.Forms.GroupBox gbMisc;
        private System.Windows.Forms.FlowLayoutPanel flpMisc;
    }
}

