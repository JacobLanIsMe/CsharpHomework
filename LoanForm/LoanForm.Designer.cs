
namespace LoanForm
{
    partial class LoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLoanAmount = new System.Windows.Forms.TextBox();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.textBoxDownPayment = new System.Windows.Forms.TextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnTotalAmount = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("標楷體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(70, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("標楷體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(70, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "期限(年)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("標楷體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(70, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("標楷體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(70, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "頭期款";
            // 
            // textBoxLoanAmount
            // 
            this.textBoxLoanAmount.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoanAmount.Location = new System.Drawing.Point(218, 92);
            this.textBoxLoanAmount.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxLoanAmount.Name = "textBoxLoanAmount";
            this.textBoxLoanAmount.Size = new System.Drawing.Size(141, 29);
            this.textBoxLoanAmount.TabIndex = 4;
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPeriod.Location = new System.Drawing.Point(218, 139);
            this.textBoxPeriod.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(141, 29);
            this.textBoxPeriod.TabIndex = 5;
            // 
            // textBoxRate
            // 
            this.textBoxRate.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRate.Location = new System.Drawing.Point(218, 187);
            this.textBoxRate.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(141, 29);
            this.textBoxRate.TabIndex = 6;
            // 
            // textBoxDownPayment
            // 
            this.textBoxDownPayment.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDownPayment.Location = new System.Drawing.Point(218, 235);
            this.textBoxDownPayment.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxDownPayment.Name = "textBoxDownPayment";
            this.textBoxDownPayment.Size = new System.Drawing.Size(141, 29);
            this.textBoxDownPayment.TabIndex = 7;
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("標楷體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(70, 283);
            this.btnPMT.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(144, 29);
            this.btnPMT.TabIndex = 8;
            this.btnPMT.Text = "PMT(月付款)";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnTotalAmount
            // 
            this.btnTotalAmount.Font = new System.Drawing.Font("標楷體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotalAmount.Location = new System.Drawing.Point(215, 282);
            this.btnTotalAmount.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnTotalAmount.Name = "btnTotalAmount";
            this.btnTotalAmount.Size = new System.Drawing.Size(144, 29);
            this.btnTotalAmount.TabIndex = 9;
            this.btnTotalAmount.Text = "總付款";
            this.btnTotalAmount.UseVisualStyleBackColor = true;
            this.btnTotalAmount.Click += new System.EventHandler(this.btnTotalAmount_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(360, 283);
            this.btnReport.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(144, 29);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 440);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotalAmount);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.textBoxDownPayment);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.textBoxPeriod);
            this.Controls.Add(this.textBoxLoanAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "LoanForm";
            this.Text = "LoanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLoanAmount;
        private System.Windows.Forms.TextBox textBoxPeriod;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.TextBox textBoxDownPayment;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnTotalAmount;
        private System.Windows.Forms.Button btnReport;
    }
}

