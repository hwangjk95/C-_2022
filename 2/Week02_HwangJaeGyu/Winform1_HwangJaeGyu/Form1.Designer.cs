namespace Winform1_HwangJaeGyu
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbxOpr1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(85, 184);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(104, 37);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "클릭하세요";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.LightGray;
            this.lblResult.Location = new System.Drawing.Point(85, 109);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(121, 31);
            this.lblResult.TabIndex = 1;
            // 
            // tbxOpr1
            // 
            this.tbxOpr1.Location = new System.Drawing.Point(89, 44);
            this.tbxOpr1.Name = "tbxOpr1";
            this.tbxOpr1.Size = new System.Drawing.Size(100, 29);
            this.tbxOpr1.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(622, 807);
            this.Controls.Add(this.tbxOpr1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClick);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Text = "Winform 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbxOpr1;
    }
}

