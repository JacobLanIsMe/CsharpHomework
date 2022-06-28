
namespace POS
{
    partial class BarPOS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnWine);
            this.panel1.Controls.Add(this.btnWhisky);
            this.panel1.Controls.Add(this.btnTequila);
            this.panel1.Controls.Add(this.btnBeer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 342);
            this.panel1.TabIndex = 0;
            // 
            // btnWine
            // 
            this.btnWine.BackColor = System.Drawing.Color.White;
            this.btnWine.Font = new System.Drawing.Font("標楷體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWine.Location = new System.Drawing.Point(104, 178);
            this.btnWine.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(102, 125);
            this.btnWine.TabIndex = 4;
            this.btnWine.Text = "紅酒\n\nWine\n\nNT$320";
            this.btnWine.UseVisualStyleBackColor = false;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.BackColor = System.Drawing.Color.White;
            this.btnWhisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWhisky.Font = new System.Drawing.Font("標楷體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhisky.Location = new System.Drawing.Point(2, 178);
            this.btnWhisky.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(102, 125);
            this.btnWhisky.TabIndex = 3;
            this.btnWhisky.Text = "威士忌\n\nWhisky\n\nNT$350";
            this.btnWhisky.UseVisualStyleBackColor = false;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.BackColor = System.Drawing.Color.White;
            this.btnTequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTequila.Font = new System.Drawing.Font("標楷體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTequila.Location = new System.Drawing.Point(104, 42);
            this.btnTequila.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(102, 125);
            this.btnTequila.TabIndex = 2;
            this.btnTequila.Text = "龍舌蘭\n\nTequila\n\nNT$180";
            this.btnTequila.UseVisualStyleBackColor = false;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.BackColor = System.Drawing.Color.White;
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeer.Font = new System.Drawing.Font("標楷體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBeer.ForeColor = System.Drawing.Color.Black;
            this.btnBeer.Location = new System.Drawing.Point(2, 42);
            this.btnBeer.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(102, 125);
            this.btnBeer.TabIndex = 1;
            this.btnBeer.Text = "啤酒\n\nBeer\n\nNT$120";
            this.btnBeer.UseVisualStyleBackColor = false;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "菜單 Menu";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxTotalPrice);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(219, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 98);
            this.panel3.TabIndex = 1;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.BackColor = System.Drawing.Color.Black;
            this.textBoxTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTotalPrice.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalPrice.ForeColor = System.Drawing.Color.White;
            this.textBoxTotalPrice.Location = new System.Drawing.Point(22, 52);
            this.textBoxTotalPrice.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(148, 29);
            this.textBoxTotalPrice.TabIndex = 2;
            this.textBoxTotalPrice.Text = "NT$ 0";
            this.textBoxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(74, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 22);
            this.label15.TabIndex = 1;
            this.label15.Text = "Total Price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(3, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "總金額";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.btnCreditCard);
            this.panel7.Controls.Add(this.btnCash);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Location = new System.Drawing.Point(219, 177);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(176, 98);
            this.panel7.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(81, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 14);
            this.label17.TabIndex = 3;
            this.label17.Text = "信用卡享九折!";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Font = new System.Drawing.Font("標楷體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreditCard.Location = new System.Drawing.Point(88, 37);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(82, 34);
            this.btnCreditCard.TabIndex = 2;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("標楷體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.Location = new System.Drawing.Point(3, 37);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(82, 34);
            this.btnCash.TabIndex = 1;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(3, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 21);
            this.label19.TabIndex = 0;
            this.label19.Text = "付款方式";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.button3);
            this.panel8.Controls.Add(this.listBox1);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Location = new System.Drawing.Point(399, 73);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(273, 342);
            this.panel8.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(162, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "清除清單";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "                        尚未點餐"});
            this.listBox1.Location = new System.Drawing.Point(5, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 244);
            this.listBox1.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(96, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 22);
            this.label20.TabIndex = 3;
            this.label20.Text = "List";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(3, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 21);
            this.label18.TabIndex = 3;
            this.label18.Text = "購物清單";
            // 
            // BarPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 479);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "BarPOS";
            this.Text = "Bar POS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
    }
}

