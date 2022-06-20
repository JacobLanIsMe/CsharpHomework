
namespace Hello
{
    partial class HelloForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxChiName = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxZodiac = new System.Windows.Forms.TextBox();
            this.textBoxEngName = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(177, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "English Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(177, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "性別:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(177, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "星座:";
            // 
            // textBoxChiName
            // 
            this.textBoxChiName.Font = new System.Drawing.Font("標楷體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxChiName.Location = new System.Drawing.Point(505, 139);
            this.textBoxChiName.Name = "textBoxChiName";
            this.textBoxChiName.Size = new System.Drawing.Size(300, 52);
            this.textBoxChiName.TabIndex = 0;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Font = new System.Drawing.Font("標楷體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxGender.Location = new System.Drawing.Point(505, 359);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(300, 52);
            this.textBoxGender.TabIndex = 4;
            // 
            // textBoxZodiac
            // 
            this.textBoxZodiac.Font = new System.Drawing.Font("標楷體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxZodiac.Location = new System.Drawing.Point(505, 470);
            this.textBoxZodiac.Name = "textBoxZodiac";
            this.textBoxZodiac.Size = new System.Drawing.Size(300, 52);
            this.textBoxZodiac.TabIndex = 5;
            // 
            // textBoxEngName
            // 
            this.textBoxEngName.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEngName.Location = new System.Drawing.Point(505, 250);
            this.textBoxEngName.Name = "textBoxEngName";
            this.textBoxEngName.Size = new System.Drawing.Size(300, 50);
            this.textBoxEngName.TabIndex = 6;
            // 
            // btnHello
            // 
            this.btnHello.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHello.Location = new System.Drawing.Point(177, 581);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(300, 60);
            this.btnHello.TabIndex = 7;
            this.btnHello.Text = "Say Hello!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnHi
            // 
            this.btnHi.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHi.Location = new System.Drawing.Point(505, 581);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(300, 60);
            this.btnHi.TabIndex = 8;
            this.btnHi.Text = "Say Hi!";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 889);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.textBoxEngName);
            this.Controls.Add(this.textBoxZodiac);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.textBoxChiName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HelloForm";
            this.Text = "你好! C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxChiName;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxZodiac;
        private System.Windows.Forms.TextBox textBoxEngName;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnHi;
    }
}

