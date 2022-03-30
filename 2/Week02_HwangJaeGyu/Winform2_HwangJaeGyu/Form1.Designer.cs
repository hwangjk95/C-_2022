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
            this.tbxOpr1 = new System.Windows.Forms.TextBox();
            this.tbxOpr2 = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.chkFloatType = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxOpr1
            // 
            this.tbxOpr1.Location = new System.Drawing.Point(44, 28);
            this.tbxOpr1.Name = "tbxOpr1";
            this.tbxOpr1.Size = new System.Drawing.Size(63, 29);
            this.tbxOpr1.TabIndex = 0;
            this.tbxOpr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxOpr2
            // 
            this.tbxOpr2.Location = new System.Drawing.Point(140, 28);
            this.tbxOpr2.Name = "tbxOpr2";
            this.tbxOpr2.Size = new System.Drawing.Size(63, 29);
            this.tbxOpr2.TabIndex = 0;
            this.tbxOpr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(209, 31);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(47, 24);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "=";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(262, 28);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(77, 31);
            this.lblResult.TabIndex = 2;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkFloatType
            // 
            this.chkFloatType.AutoSize = true;
            this.chkFloatType.Location = new System.Drawing.Point(345, 28);
            this.chkFloatType.Name = "chkFloatType";
            this.chkFloatType.Size = new System.Drawing.Size(65, 25);
            this.chkFloatType.TabIndex = 3;
            this.chkFloatType.Text = "Float";
            this.chkFloatType.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(448, 76);
            this.Controls.Add(this.chkFloatType);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.tbxOpr2);
            this.Controls.Add(this.tbxOpr1);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frmMain";
            this.Text = "Winform 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOpr1;
        private System.Windows.Forms.TextBox tbxOpr2;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckBox chkFloatType;
    }
}

