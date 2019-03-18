namespace lab_rab_1
{
    partial class fMain
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
            this.bRectangle = new System.Windows.Forms.Button();
            this.pbHolst = new System.Windows.Forms.PictureBox();
            this.bEllipse = new System.Windows.Forms.Button();
            this.bLine = new System.Windows.Forms.Button();
            this.cbThickness = new System.Windows.Forms.ComboBox();
            this.bPolygon = new System.Windows.Forms.Button();
            this.bSquare = new System.Windows.Forms.Button();
            this.bCircle = new System.Windows.Forms.Button();
            this.bColor = new System.Windows.Forms.Button();
            this.cdDraw = new System.Windows.Forms.ColorDialog();
            this.bClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHolst)).BeginInit();
            this.SuspendLayout();
            // 
            // bRectangle
            // 
            this.bRectangle.Location = new System.Drawing.Point(573, 145);
            this.bRectangle.Name = "bRectangle";
            this.bRectangle.Size = new System.Drawing.Size(135, 22);
            this.bRectangle.TabIndex = 0;
            this.bRectangle.Text = "Rectangle";
            this.bRectangle.UseVisualStyleBackColor = true;
            this.bRectangle.Click += new System.EventHandler(this.bRectangle_Click);
            // 
            // pbHolst
            // 
            this.pbHolst.BackColor = System.Drawing.Color.White;
            this.pbHolst.Location = new System.Drawing.Point(0, 12);
            this.pbHolst.Name = "pbHolst";
            this.pbHolst.Size = new System.Drawing.Size(547, 470);
            this.pbHolst.TabIndex = 1;
            this.pbHolst.TabStop = false;
            this.pbHolst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbHolst_MouseDown);
            this.pbHolst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbHolst_MouseMove);
            this.pbHolst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbHolst_MouseUp);
            // 
            // bEllipse
            // 
            this.bEllipse.Location = new System.Drawing.Point(573, 117);
            this.bEllipse.Name = "bEllipse";
            this.bEllipse.Size = new System.Drawing.Size(135, 22);
            this.bEllipse.TabIndex = 2;
            this.bEllipse.Text = "Ellipse";
            this.bEllipse.UseVisualStyleBackColor = true;
            this.bEllipse.Click += new System.EventHandler(this.bEllipse_Click);
            // 
            // bLine
            // 
            this.bLine.Location = new System.Drawing.Point(573, 89);
            this.bLine.Name = "bLine";
            this.bLine.Size = new System.Drawing.Size(135, 22);
            this.bLine.TabIndex = 3;
            this.bLine.Text = "Line";
            this.bLine.UseVisualStyleBackColor = true;
            this.bLine.Click += new System.EventHandler(this.bLine_Click);
            // 
            // cbThickness
            // 
            this.cbThickness.FormattingEnabled = true;
            this.cbThickness.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "36",
            "48",
            "72"});
            this.cbThickness.Location = new System.Drawing.Point(575, 55);
            this.cbThickness.Name = "cbThickness";
            this.cbThickness.Size = new System.Drawing.Size(132, 21);
            this.cbThickness.TabIndex = 4;
            this.cbThickness.SelectedIndexChanged += new System.EventHandler(this.cbThickness_SelectedIndexChanged);
            // 
            // bPolygon
            // 
            this.bPolygon.Location = new System.Drawing.Point(572, 226);
            this.bPolygon.Name = "bPolygon";
            this.bPolygon.Size = new System.Drawing.Size(136, 21);
            this.bPolygon.TabIndex = 5;
            this.bPolygon.Text = "Polygon";
            this.bPolygon.UseVisualStyleBackColor = true;
            this.bPolygon.Click += new System.EventHandler(this.bTriangle_Click);
            // 
            // bSquare
            // 
            this.bSquare.Location = new System.Drawing.Point(573, 173);
            this.bSquare.Name = "bSquare";
            this.bSquare.Size = new System.Drawing.Size(134, 21);
            this.bSquare.TabIndex = 6;
            this.bSquare.Text = "Square";
            this.bSquare.UseVisualStyleBackColor = true;
            this.bSquare.Click += new System.EventHandler(this.bSquare_Click);
            // 
            // bCircle
            // 
            this.bCircle.Location = new System.Drawing.Point(573, 200);
            this.bCircle.Name = "bCircle";
            this.bCircle.Size = new System.Drawing.Size(134, 20);
            this.bCircle.TabIndex = 7;
            this.bCircle.Text = "Circle";
            this.bCircle.UseVisualStyleBackColor = true;
            this.bCircle.Click += new System.EventHandler(this.bCircle_Click);
            // 
            // bColor
            // 
            this.bColor.Location = new System.Drawing.Point(572, 25);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(134, 21);
            this.bColor.TabIndex = 8;
            this.bColor.Text = "Color";
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(572, 254);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(133, 22);
            this.bClear.TabIndex = 9;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 483);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bColor);
            this.Controls.Add(this.bCircle);
            this.Controls.Add(this.bSquare);
            this.Controls.Add(this.bPolygon);
            this.Controls.Add(this.cbThickness);
            this.Controls.Add(this.bLine);
            this.Controls.Add(this.bEllipse);
            this.Controls.Add(this.pbHolst);
            this.Controls.Add(this.bRectangle);
            this.DoubleBuffered = true;
            this.Name = "fMain";
            this.Text = "Draw";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHolst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bRectangle;
        private System.Windows.Forms.PictureBox pbHolst;
        private System.Windows.Forms.Button bEllipse;
        private System.Windows.Forms.Button bLine;
        private System.Windows.Forms.ComboBox cbThickness;
        private System.Windows.Forms.Button bPolygon;
        private System.Windows.Forms.Button bSquare;
        private System.Windows.Forms.Button bCircle;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.ColorDialog cdDraw;
        private System.Windows.Forms.Button bClear;


    }
}

