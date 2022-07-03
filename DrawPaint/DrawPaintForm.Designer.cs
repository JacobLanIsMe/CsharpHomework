
namespace DrawPaint
{
    partial class DrawPaintForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelPenPoint = new System.Windows.Forms.Label();
            this.buttonColorPicker = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPaintingBrush = new System.Windows.Forms.RadioButton();
            this.radioButtonEraser = new System.Windows.Forms.RadioButton();
            this.radioButtonMarkerPen = new System.Windows.Forms.RadioButton();
            this.radioButtonBrush = new System.Windows.Forms.RadioButton();
            this.radioButtonPen = new System.Windows.Forms.RadioButton();
            this.btnAllClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.CausesValidation = false;
            this.trackBar1.Location = new System.Drawing.Point(688, 274);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 153);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 2;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelPenPoint
            // 
            this.labelPenPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPenPoint.AutoSize = true;
            this.labelPenPoint.BackColor = System.Drawing.Color.White;
            this.labelPenPoint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenPoint.Location = new System.Drawing.Point(688, 427);
            this.labelPenPoint.Name = "labelPenPoint";
            this.labelPenPoint.Size = new System.Drawing.Size(18, 19);
            this.labelPenPoint.TabIndex = 1;
            this.labelPenPoint.Text = "1";
            this.labelPenPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonColorPicker
            // 
            this.buttonColorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonColorPicker.BackColor = System.Drawing.Color.Black;
            this.buttonColorPicker.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonColorPicker.Location = new System.Drawing.Point(688, 223);
            this.buttonColorPicker.Name = "buttonColorPicker";
            this.buttonColorPicker.Size = new System.Drawing.Size(45, 45);
            this.buttonColorPicker.TabIndex = 2;
            this.buttonColorPicker.UseVisualStyleBackColor = false;
            this.buttonColorPicker.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 465);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radioButtonPaintingBrush);
            this.groupBox1.Controls.Add(this.radioButtonEraser);
            this.groupBox1.Controls.Add(this.radioButtonMarkerPen);
            this.groupBox1.Controls.Add(this.radioButtonBrush);
            this.groupBox1.Controls.Add(this.radioButtonPen);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(598, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 154);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇畫筆";
            // 
            // radioButtonPaintingBrush
            // 
            this.radioButtonPaintingBrush.AutoSize = true;
            this.radioButtonPaintingBrush.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPaintingBrush.Location = new System.Drawing.Point(7, 72);
            this.radioButtonPaintingBrush.Name = "radioButtonPaintingBrush";
            this.radioButtonPaintingBrush.Size = new System.Drawing.Size(125, 22);
            this.radioButtonPaintingBrush.TabIndex = 4;
            this.radioButtonPaintingBrush.TabStop = true;
            this.radioButtonPaintingBrush.Text = "Painting bursh";
            this.radioButtonPaintingBrush.UseVisualStyleBackColor = true;
            this.radioButtonPaintingBrush.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonEraser
            // 
            this.radioButtonEraser.AutoSize = true;
            this.radioButtonEraser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEraser.Location = new System.Drawing.Point(7, 122);
            this.radioButtonEraser.Name = "radioButtonEraser";
            this.radioButtonEraser.Size = new System.Drawing.Size(73, 22);
            this.radioButtonEraser.TabIndex = 3;
            this.radioButtonEraser.TabStop = true;
            this.radioButtonEraser.Text = "Eraser";
            this.radioButtonEraser.UseVisualStyleBackColor = true;
            this.radioButtonEraser.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonMarkerPen
            // 
            this.radioButtonMarkerPen.AutoSize = true;
            this.radioButtonMarkerPen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMarkerPen.Location = new System.Drawing.Point(7, 97);
            this.radioButtonMarkerPen.Name = "radioButtonMarkerPen";
            this.radioButtonMarkerPen.Size = new System.Drawing.Size(107, 22);
            this.radioButtonMarkerPen.TabIndex = 2;
            this.radioButtonMarkerPen.Text = "Marker Pen";
            this.radioButtonMarkerPen.UseVisualStyleBackColor = true;
            // 
            // radioButtonBrush
            // 
            this.radioButtonBrush.AutoSize = true;
            this.radioButtonBrush.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBrush.Location = new System.Drawing.Point(7, 47);
            this.radioButtonBrush.Name = "radioButtonBrush";
            this.radioButtonBrush.Size = new System.Drawing.Size(66, 22);
            this.radioButtonBrush.TabIndex = 1;
            this.radioButtonBrush.Text = "Brush";
            this.radioButtonBrush.UseVisualStyleBackColor = true;
            this.radioButtonBrush.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonPen
            // 
            this.radioButtonPen.AutoSize = true;
            this.radioButtonPen.Checked = true;
            this.radioButtonPen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPen.Location = new System.Drawing.Point(7, 22);
            this.radioButtonPen.Name = "radioButtonPen";
            this.radioButtonPen.Size = new System.Drawing.Size(69, 22);
            this.radioButtonPen.TabIndex = 0;
            this.radioButtonPen.TabStop = true;
            this.radioButtonPen.Text = "Pencil";
            this.radioButtonPen.UseVisualStyleBackColor = true;
            this.radioButtonPen.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // btnAllClear
            // 
            this.btnAllClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAllClear.BackColor = System.Drawing.Color.White;
            this.btnAllClear.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAllClear.Location = new System.Drawing.Point(598, 189);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(135, 28);
            this.btnAllClear.TabIndex = 6;
            this.btnAllClear.Text = "全部清除";
            this.btnAllClear.UseVisualStyleBackColor = false;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // DrawPaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.buttonColorPicker);
            this.Controls.Add(this.labelPenPoint);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DrawPaintForm";
            this.Text = "DrawPaintForm";
            this.Load += new System.EventHandler(this.DrawPaintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelPenPoint;
        private System.Windows.Forms.Button buttonColorPicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonBrush;
        private System.Windows.Forms.RadioButton radioButtonPen;
        private System.Windows.Forms.RadioButton radioButtonMarkerPen;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.RadioButton radioButtonEraser;
        private System.Windows.Forms.RadioButton radioButtonPaintingBrush;
    }
}

