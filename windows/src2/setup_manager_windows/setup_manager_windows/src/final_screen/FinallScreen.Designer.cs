namespace setup_manager_windows.src.final_screen
{
    partial class FinallScreen
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.subTitle = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.githubBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subTitle
            // 
            this.subTitle.AutoSize = true;
            this.subTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subTitle.Location = new System.Drawing.Point(22, 53);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(285, 90);
            this.subTitle.TabIndex = 25;
            this.subTitle.Text = "We appreciate you becoming part of our community.\r\n\r\nThe installation process is " +
    "now complete.\r\n\r\nDRS relies on user feedback to improve.\r\nIf you encounter any i" +
    "ssues, please let us know.";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.header.Location = new System.Drawing.Point(22, 19);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(208, 24);
            this.header.TabIndex = 24;
            this.header.Text = "Thank You Very Much";
            // 
            // githubBtn
            // 
            this.githubBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubBtn.Location = new System.Drawing.Point(24, 285);
            this.githubBtn.Name = "githubBtn";
            this.githubBtn.Size = new System.Drawing.Size(81, 28);
            this.githubBtn.TabIndex = 23;
            this.githubBtn.Text = "Github";
            this.githubBtn.UseVisualStyleBackColor = true;
            this.githubBtn.Click += new System.EventHandler(this.githubBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(598, 285);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(81, 28);
            this.nextBtn.TabIndex = 22;
            this.nextBtn.Text = "Okay";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // FinallScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.header);
            this.Controls.Add(this.githubBtn);
            this.Controls.Add(this.nextBtn);
            this.Name = "FinallScreen";
            this.Size = new System.Drawing.Size(700, 333);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subTitle;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button githubBtn;
        private System.Windows.Forms.Button nextBtn;
    }
}
