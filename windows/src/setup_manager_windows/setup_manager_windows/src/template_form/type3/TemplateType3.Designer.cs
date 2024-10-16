namespace setup_manager_windows.src.template_form.type3
{
    partial class TemplateType3
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
            this.mainText = new System.Windows.Forms.Label();
            this.headerText = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.asideText = new System.Windows.Forms.Label();
            this.leftBtn1 = new System.Windows.Forms.Button();
            this.rightBtn2 = new System.Windows.Forms.Button();
            this.rightBtn1 = new System.Windows.Forms.Button();
            this.midGroupBox = new System.Windows.Forms.GroupBox();
            this.midGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainText.Location = new System.Drawing.Point(22, 53);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(54, 15);
            this.mainText.TabIndex = 13;
            this.mainText.Text = "mainText";
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerText.Location = new System.Drawing.Point(22, 19);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(109, 24);
            this.headerText.TabIndex = 12;
            this.headerText.Text = "headerText";
            // 
            // textBox
            // 
            this.textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(16, 20);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(620, 152);
            this.textBox.TabIndex = 0;
            this.textBox.TabStop = false;
            this.textBox.Text = "textBox";
            // 
            // asideText
            // 
            this.asideText.AutoSize = true;
            this.asideText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asideText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.asideText.Location = new System.Drawing.Point(23, 260);
            this.asideText.Name = "asideText";
            this.asideText.Size = new System.Drawing.Size(57, 15);
            this.asideText.TabIndex = 18;
            this.asideText.Text = "asideText";
            // 
            // leftBtn1
            // 
            this.leftBtn1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBtn1.Location = new System.Drawing.Point(24, 285);
            this.leftBtn1.Name = "leftBtn1";
            this.leftBtn1.Size = new System.Drawing.Size(81, 28);
            this.leftBtn1.TabIndex = 17;
            this.leftBtn1.Text = "leftBtn1";
            this.leftBtn1.UseVisualStyleBackColor = true;
            // 
            // rightBtn2
            // 
            this.rightBtn2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBtn2.Location = new System.Drawing.Point(510, 285);
            this.rightBtn2.Name = "rightBtn2";
            this.rightBtn2.Size = new System.Drawing.Size(81, 28);
            this.rightBtn2.TabIndex = 16;
            this.rightBtn2.Text = "rightBtn2";
            this.rightBtn2.UseVisualStyleBackColor = true;
            // 
            // rightBtn1
            // 
            this.rightBtn1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBtn1.Location = new System.Drawing.Point(597, 285);
            this.rightBtn1.Name = "rightBtn1";
            this.rightBtn1.Size = new System.Drawing.Size(81, 28);
            this.rightBtn1.TabIndex = 15;
            this.rightBtn1.Text = "rightBtn1";
            this.rightBtn1.UseVisualStyleBackColor = true;
            // 
            // midGroupBox
            // 
            this.midGroupBox.Controls.Add(this.textBox);
            this.midGroupBox.Location = new System.Drawing.Point(25, 71);
            this.midGroupBox.Name = "midGroupBox";
            this.midGroupBox.Size = new System.Drawing.Size(653, 186);
            this.midGroupBox.TabIndex = 14;
            this.midGroupBox.TabStop = false;
            // 
            // TemplateType3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.asideText);
            this.Controls.Add(this.leftBtn1);
            this.Controls.Add(this.rightBtn2);
            this.Controls.Add(this.rightBtn1);
            this.Controls.Add(this.midGroupBox);
            this.Name = "TemplateType3";
            this.Size = new System.Drawing.Size(700, 333);
            this.midGroupBox.ResumeLayout(false);
            this.midGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainText;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label asideText;
        private System.Windows.Forms.Button leftBtn1;
        private System.Windows.Forms.Button rightBtn2;
        private System.Windows.Forms.Button rightBtn1;
        private System.Windows.Forms.GroupBox midGroupBox;
    }
}
