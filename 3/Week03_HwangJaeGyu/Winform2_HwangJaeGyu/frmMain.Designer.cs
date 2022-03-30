namespace Winform2_HwangJaeGyu
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.btnAllViewHW1 = new System.Windows.Forms.Button();
            this.btnAllViewHW2 = new System.Windows.Forms.Button();
            this.btnAllview = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxScore = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(14, 100);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(500, 149);
            this.tbxOutput.TabIndex = 15;
            // 
            // btnAllViewHW1
            // 
            this.btnAllViewHW1.Location = new System.Drawing.Point(308, 255);
            this.btnAllViewHW1.Name = "btnAllViewHW1";
            this.btnAllViewHW1.Size = new System.Drawing.Size(100, 34);
            this.btnAllViewHW1.TabIndex = 10;
            this.btnAllViewHW1.Text = "전체조회(2)";
            this.btnAllViewHW1.UseVisualStyleBackColor = true;
            this.btnAllViewHW1.Click += new System.EventHandler(this.btnAllViewHW1_Click);
            // 
            // btnAllViewHW2
            // 
            this.btnAllViewHW2.Location = new System.Drawing.Point(414, 255);
            this.btnAllViewHW2.Name = "btnAllViewHW2";
            this.btnAllViewHW2.Size = new System.Drawing.Size(100, 34);
            this.btnAllViewHW2.TabIndex = 11;
            this.btnAllViewHW2.Text = "전체조회(3)";
            this.btnAllViewHW2.UseVisualStyleBackColor = true;
            this.btnAllViewHW2.Click += new System.EventHandler(this.btnAllViewHW2_Click);
            // 
            // btnAllview
            // 
            this.btnAllview.Location = new System.Drawing.Point(14, 255);
            this.btnAllview.Name = "btnAllview";
            this.btnAllview.Size = new System.Drawing.Size(100, 34);
            this.btnAllview.TabIndex = 12;
            this.btnAllview.Text = "전체조회(1)";
            this.btnAllview.UseVisualStyleBackColor = true;
            this.btnAllview.Click += new System.EventHandler(this.btnAllview_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(414, 9);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 64);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "입력";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(14, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbxScore
            // 
            this.tbxScore.Location = new System.Drawing.Point(298, 50);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.Size = new System.Drawing.Size(100, 21);
            this.tbxScore.TabIndex = 7;
            this.tbxScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(148, 50);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 21);
            this.tbxName.TabIndex = 8;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(12, 50);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(100, 21);
            this.tbxNumber.TabIndex = 9;
            this.tbxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(296, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "성적";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(154, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "이름";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "학번";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 338);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.btnAllViewHW1);
            this.Controls.Add(this.btnAllViewHW2);
            this.Controls.Add(this.btnAllview);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxScore);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "성적관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Button btnAllViewHW1;
        private System.Windows.Forms.Button btnAllViewHW2;
        private System.Windows.Forms.Button btnAllview;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxScore;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

