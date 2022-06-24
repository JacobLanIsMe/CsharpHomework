
namespace Method
{
    partial class btnClearResult
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
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.btnOddOrEven = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnCalOddEvenFromArray = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnCAndc = new System.Windows.Forms.Button();
            this.btnLongName = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSumArray = new System.Windows.Forms.Button();
            this.btnMaxArray = new System.Windows.Forms.Button();
            this.btnMinArray = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumber.Location = new System.Drawing.Point(97, 12);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 29);
            this.textBoxNumber.TabIndex = 1;
            // 
            // btnOddOrEven
            // 
            this.btnOddOrEven.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOddOrEven.Location = new System.Drawing.Point(13, 55);
            this.btnOddOrEven.Name = "btnOddOrEven";
            this.btnOddOrEven.Size = new System.Drawing.Size(110, 52);
            this.btnOddOrEven.TabIndex = 2;
            this.btnOddOrEven.Text = "輸入的數為奇數或偶數?";
            this.btnOddOrEven.UseVisualStyleBackColor = true;
            this.btnOddOrEven.Click += new System.EventHandler(this.btnOddOrEven_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelResult.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelResult.Location = new System.Drawing.Point(272, 233);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(40, 16);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "結果";
            // 
            // btnCalOddEvenFromArray
            // 
            this.btnCalOddEvenFromArray.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalOddEvenFromArray.Location = new System.Drawing.Point(218, 15);
            this.btnCalOddEvenFromArray.Name = "btnCalOddEvenFromArray";
            this.btnCalOddEvenFromArray.Size = new System.Drawing.Size(163, 37);
            this.btnCalOddEvenFromArray.TabIndex = 5;
            this.btnCalOddEvenFromArray.Text = "統計陣列中的奇偶數";
            this.btnCalOddEvenFromArray.UseVisualStyleBackColor = true;
            this.btnCalOddEvenFromArray.Click += new System.EventHandler(this.btnCalOddEvenFromArray_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaxMin.Location = new System.Drawing.Point(13, 113);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(163, 37);
            this.btnMaxMin.TabIndex = 6;
            this.btnMaxMin.Text = "陣列arr最大/小值";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // btnCAndc
            // 
            this.btnCAndc.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCAndc.Location = new System.Drawing.Point(13, 156);
            this.btnCAndc.Name = "btnCAndc";
            this.btnCAndc.Size = new System.Drawing.Size(368, 49);
            this.btnCAndc.TabIndex = 7;
            this.btnCAndc.Text = "陣列arr_Str[] \"C\" OR \"c\"的字樣有幾個";
            this.btnCAndc.UseVisualStyleBackColor = true;
            this.btnCAndc.Click += new System.EventHandler(this.btnCAndc_Click);
            // 
            // btnLongName
            // 
            this.btnLongName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLongName.Location = new System.Drawing.Point(218, 58);
            this.btnLongName.Name = "btnLongName";
            this.btnLongName.Size = new System.Drawing.Size(163, 49);
            this.btnLongName.TabIndex = 8;
            this.btnLongName.Text = "陣列arr_Str[]最長的名字";
            this.btnLongName.UseVisualStyleBackColor = true;
            this.btnLongName.Click += new System.EventHandler(this.btnLongName_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(387, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "[10,10]二維陣列-邊1,內0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(387, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "[10,10]二維陣列-邊0,內1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(387, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 49);
            this.button3.TabIndex = 11;
            this.button3.Text = "[10,10]二維陣列1010101010";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSumArray
            // 
            this.btnSumArray.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSumArray.Location = new System.Drawing.Point(596, 58);
            this.btnSumArray.Name = "btnSumArray";
            this.btnSumArray.Size = new System.Drawing.Size(163, 37);
            this.btnSumArray.TabIndex = 12;
            this.btnSumArray.Text = "Sum(陣列arr[])";
            this.btnSumArray.UseVisualStyleBackColor = true;
            this.btnSumArray.Click += new System.EventHandler(this.btnSumArray_Click);
            // 
            // btnMaxArray
            // 
            this.btnMaxArray.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaxArray.Location = new System.Drawing.Point(596, 101);
            this.btnMaxArray.Name = "btnMaxArray";
            this.btnMaxArray.Size = new System.Drawing.Size(163, 37);
            this.btnMaxArray.TabIndex = 13;
            this.btnMaxArray.Text = "Max(陣列arr[])";
            this.btnMaxArray.UseVisualStyleBackColor = true;
            this.btnMaxArray.Click += new System.EventHandler(this.btnMaxArray_Click);
            // 
            // btnMinArray
            // 
            this.btnMinArray.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinArray.Location = new System.Drawing.Point(596, 144);
            this.btnMinArray.Name = "btnMinArray";
            this.btnMinArray.Size = new System.Drawing.Size(163, 37);
            this.btnMinArray.TabIndex = 14;
            this.btnMinArray.Text = "Min(陣列arr[])";
            this.btnMinArray.UseVisualStyleBackColor = true;
            this.btnMinArray.Click += new System.EventHandler(this.btnMinArray_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSwap.Location = new System.Drawing.Point(596, 15);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(163, 37);
            this.btnSwap.TabIndex = 15;
            this.btnSwap.Text = "Swap[int, int]";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(62, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 37);
            this.button4.TabIndex = 16;
            this.button4.Text = "清空結果欄";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnClearResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnMinArray);
            this.Controls.Add(this.btnMaxArray);
            this.Controls.Add(this.btnSumArray);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLongName);
            this.Controls.Add(this.btnCAndc);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.btnCalOddEvenFromArray);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOddOrEven);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label1);
            this.Name = "btnClearResult";
            this.Text = "Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button btnOddOrEven;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnCalOddEvenFromArray;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnCAndc;
        private System.Windows.Forms.Button btnLongName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSumArray;
        private System.Windows.Forms.Button btnMaxArray;
        private System.Windows.Forms.Button btnMinArray;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button button4;
    }
}

