
namespace StudentsGrade
{
    partial class StudentsGradeForm
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
            this.textBoxMath = new System.Windows.Forms.TextBox();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.textBoxChinese = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRandomStudent = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRandom20Student = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelStatistics = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMath
            // 
            this.textBoxMath.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMath.Location = new System.Drawing.Point(90, 166);
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.Size = new System.Drawing.Size(100, 30);
            this.textBoxMath.TabIndex = 15;
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnglish.Location = new System.Drawing.Point(90, 117);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(100, 30);
            this.textBoxEnglish.TabIndex = 14;
            // 
            // textBoxChinese
            // 
            this.textBoxChinese.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChinese.Location = new System.Drawing.Point(90, 68);
            this.textBoxChinese.Name = "textBoxChinese";
            this.textBoxChinese.Size = new System.Drawing.Size(100, 30);
            this.textBoxChinese.TabIndex = 13;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxName.Location = new System.Drawing.Point(90, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 30);
            this.textBoxName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(24, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "數學:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "英文:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "國文:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名:";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("標楷體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddStudent.Location = new System.Drawing.Point(27, 208);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(163, 32);
            this.btnAddStudent.TabIndex = 16;
            this.btnAddStudent.Text = "加入學生資料";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRandomStudent
            // 
            this.btnRandomStudent.Font = new System.Drawing.Font("標楷體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandomStudent.Location = new System.Drawing.Point(27, 240);
            this.btnRandomStudent.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnRandomStudent.Name = "btnRandomStudent";
            this.btnRandomStudent.Size = new System.Drawing.Size(163, 32);
            this.btnRandomStudent.TabIndex = 17;
            this.btnRandomStudent.Text = "隨機儲存資料";
            this.btnRandomStudent.UseVisualStyleBackColor = true;
            this.btnRandomStudent.Click += new System.EventHandler(this.btnRandomStudent_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Enabled = false;
            this.btnStatistics.Font = new System.Drawing.Font("標楷體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatistics.Location = new System.Drawing.Point(27, 272);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(163, 32);
            this.btnStatistics.TabIndex = 18;
            this.btnStatistics.Text = "各科統計";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("標楷體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(27, 330);
            this.btnReset.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 32);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRandom20Student
            // 
            this.btnRandom20Student.Font = new System.Drawing.Font("標楷體", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandom20Student.Location = new System.Drawing.Point(27, 361);
            this.btnRandom20Student.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnRandom20Student.Name = "btnRandom20Student";
            this.btnRandom20Student.Size = new System.Drawing.Size(163, 32);
            this.btnRandom20Student.TabIndex = 20;
            this.btnRandom20Student.Text = "隨機加入20筆";
            this.btnRandom20Student.UseVisualStyleBackColor = true;
            this.btnRandom20Student.Click += new System.EventHandler(this.btnRandom20Student_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.splitContainer1.Location = new System.Drawing.Point(207, 19);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.labelScore);
            this.splitContainer1.Panel1.Controls.Add(this.labelTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelStatistics);
            this.splitContainer1.Size = new System.Drawing.Size(521, 366);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 21;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(1, 31);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(48, 16);
            this.labelScore.TabIndex = 10;
            this.labelScore.Text = "     ";
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(2, 7);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(502, 27);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "姓名       國文   英文   數學   總分   平均    最低    最高";
            // 
            // labelStatistics
            // 
            this.labelStatistics.AutoSize = true;
            this.labelStatistics.Location = new System.Drawing.Point(1, 2);
            this.labelStatistics.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStatistics.Name = "labelStatistics";
            this.labelStatistics.Size = new System.Drawing.Size(56, 16);
            this.labelStatistics.TabIndex = 2;
            this.labelStatistics.Text = "      ";
            // 
            // StudentsGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 609);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnRandom20Student);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnRandomStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.textBoxMath);
            this.Controls.Add(this.textBoxEnglish);
            this.Controls.Add(this.textBoxChinese);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "StudentsGradeForm";
            this.Text = "StudentGrade";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMath;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.TextBox textBoxChinese;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRandomStudent;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRandom20Student;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelStatistics;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelScore;
    }
}

