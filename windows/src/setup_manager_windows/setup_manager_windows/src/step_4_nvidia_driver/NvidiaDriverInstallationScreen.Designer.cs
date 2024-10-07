namespace setup_manager_windows.src.step_4_nvidia_driver
{
    partial class NvidiaDriverInstallationScreen
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
            this.githubBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.subTitle = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.midGroupBox = new System.Windows.Forms.GroupBox();
            this.midTextBox = new System.Windows.Forms.TextBox();
            this.bottomText = new System.Windows.Forms.Label();
            this.midGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // githubBtn
            // 
            this.githubBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubBtn.Location = new System.Drawing.Point(23, 287);
            this.githubBtn.Name = "githubBtn";
            this.githubBtn.Size = new System.Drawing.Size(81, 28);
            this.githubBtn.TabIndex = 19;
            this.githubBtn.Text = "Github";
            this.githubBtn.UseVisualStyleBackColor = true;
            this.githubBtn.Click += new System.EventHandler(this.githubBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(510, 287);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(81, 28);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(597, 287);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(81, 28);
            this.nextBtn.TabIndex = 17;
            this.nextBtn.Text = "Install";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // subTitle
            // 
            this.subTitle.AutoSize = true;
            this.subTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subTitle.Location = new System.Drawing.Point(21, 55);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(222, 15);
            this.subTitle.TabIndex = 21;
            this.subTitle.Text = "Checking for Nvidia Driver information...";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.header.Location = new System.Drawing.Point(21, 21);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(210, 24);
            this.header.TabIndex = 20;
            this.header.Text = "4. Install Nvidia Driver";
            // 
            // midGroupBox
            // 
            this.midGroupBox.Controls.Add(this.midTextBox);
            this.midGroupBox.Location = new System.Drawing.Point(24, 73);
            this.midGroupBox.Name = "midGroupBox";
            this.midGroupBox.Size = new System.Drawing.Size(653, 186);
            this.midGroupBox.TabIndex = 22;
            this.midGroupBox.TabStop = false;
            // 
            // midTextBox
            // 
            this.midTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.midTextBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midTextBox.Location = new System.Drawing.Point(16, 20);
            this.midTextBox.Multiline = true;
            this.midTextBox.Name = "midTextBox";
            this.midTextBox.ReadOnly = true;
            this.midTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.midTextBox.Size = new System.Drawing.Size(620, 152);
            this.midTextBox.TabIndex = 0;
            this.midTextBox.TabStop = false;
            // 
            // bottomText
            // 
            this.bottomText.AutoSize = true;
            this.bottomText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bottomText.Location = new System.Drawing.Point(22, 262);
            this.bottomText.Name = "bottomText";
            this.bottomText.Size = new System.Drawing.Size(0, 15);
            this.bottomText.TabIndex = 23;
            // 
            // NvidiaDriverInstallationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.bottomText);
            this.Controls.Add(this.midGroupBox);
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.header);
            this.Controls.Add(this.githubBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.nextBtn);
            this.Name = "NvidiaDriverInstallationScreen";
            this.Size = new System.Drawing.Size(700, 333);
            this.midGroupBox.ResumeLayout(false);
            this.midGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button githubBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label subTitle;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.GroupBox midGroupBox;
        private System.Windows.Forms.TextBox midTextBox;
        private System.Windows.Forms.Label bottomText;
    }
}
