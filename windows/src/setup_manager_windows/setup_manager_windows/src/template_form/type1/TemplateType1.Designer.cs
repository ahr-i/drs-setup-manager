namespace setup_manager_windows.src.template_form.type1
{
    partial class TemplateType1
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
            this.leftBtn1 = new System.Windows.Forms.Button();
            this.rightBtn2 = new System.Windows.Forms.Button();
            this.rightBtn1 = new System.Windows.Forms.Button();
            this.mainText = new System.Windows.Forms.Label();
            this.headerText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftBtn1
            // 
            this.leftBtn1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBtn1.Location = new System.Drawing.Point(24, 285);
            this.leftBtn1.Name = "leftBtn1";
            this.leftBtn1.Size = new System.Drawing.Size(81, 28);
            this.leftBtn1.TabIndex = 18;
            this.leftBtn1.Text = "leftBtn1";
            this.leftBtn1.UseVisualStyleBackColor = true;
            // 
            // rightBtn2
            // 
            this.rightBtn2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBtn2.Location = new System.Drawing.Point(511, 285);
            this.rightBtn2.Name = "rightBtn2";
            this.rightBtn2.Size = new System.Drawing.Size(81, 28);
            this.rightBtn2.TabIndex = 17;
            this.rightBtn2.Text = "rightBtn2";
            this.rightBtn2.UseVisualStyleBackColor = true;
            // 
            // rightBtn1
            // 
            this.rightBtn1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBtn1.Location = new System.Drawing.Point(598, 285);
            this.rightBtn1.Name = "rightBtn1";
            this.rightBtn1.Size = new System.Drawing.Size(81, 28);
            this.rightBtn1.TabIndex = 16;
            this.rightBtn1.Text = "rightBtn1";
            this.rightBtn1.UseVisualStyleBackColor = true;
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainText.Location = new System.Drawing.Point(21, 53);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(54, 15);
            this.mainText.TabIndex = 15;
            this.mainText.Text = "mainText";
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerText.Location = new System.Drawing.Point(21, 19);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(109, 24);
            this.headerText.TabIndex = 14;
            this.headerText.Text = "headerText";
            // 
            // TemplateType1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.leftBtn1);
            this.Controls.Add(this.rightBtn2);
            this.Controls.Add(this.rightBtn1);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.headerText);
            this.Name = "TemplateType1";
            this.Size = new System.Drawing.Size(700, 333);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leftBtn1;
        private System.Windows.Forms.Button rightBtn2;
        private System.Windows.Forms.Button rightBtn1;
        private System.Windows.Forms.Label mainText;
        private System.Windows.Forms.Label headerText;
    }
}
