
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
            this.labelColor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(727, 171);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 153);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelPenPoint
            // 
            this.labelPenPoint.AutoSize = true;
            this.labelPenPoint.BackColor = System.Drawing.Color.White;
            this.labelPenPoint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenPoint.Location = new System.Drawing.Point(727, 324);
            this.labelPenPoint.Name = "labelPenPoint";
            this.labelPenPoint.Size = new System.Drawing.Size(17, 18);
            this.labelPenPoint.TabIndex = 1;
            this.labelPenPoint.Text = "0";
            this.labelPenPoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonColorPicker
            // 
            this.buttonColorPicker.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonColorPicker.Location = new System.Drawing.Point(712, 80);
            this.buttonColorPicker.Name = "buttonColorPicker";
            this.buttonColorPicker.Size = new System.Drawing.Size(76, 37);
            this.buttonColorPicker.TabIndex = 2;
            this.buttonColorPicker.Text = "顏色";
            this.buttonColorPicker.UseVisualStyleBackColor = true;
            this.buttonColorPicker.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // labelColor
            // 
            this.labelColor.BackColor = System.Drawing.Color.Black;
            this.labelColor.Location = new System.Drawing.Point(712, 120);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(76, 37);
            this.labelColor.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // DrawPaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.buttonColorPicker);
            this.Controls.Add(this.labelPenPoint);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DrawPaintForm";
            this.Text = "DrawPaintForm";
            this.Load += new System.EventHandler(this.DrawPaintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelPenPoint;
        private System.Windows.Forms.Button buttonColorPicker;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

