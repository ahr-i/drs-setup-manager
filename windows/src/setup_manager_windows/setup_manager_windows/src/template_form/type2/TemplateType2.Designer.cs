namespace setup_manager_windows.src.template_form.type2
{
    partial class TemplateType2
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
            this.headerText = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.leftBtn1 = new System.Windows.Forms.Button();
            this.rightBtn2 = new System.Windows.Forms.Button();
            this.rightBtn1 = new System.Windows.Forms.Button();
            this.midGroupBox = new System.Windows.Forms.GroupBox();
            this.midGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerText.Location = new System.Drawing.Point(87, 22);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(527, 31);
            this.headerText.TabIndex = 8;
            this.headerText.Text = "headerText";
            this.headerText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox
            // 
            this.textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(16, 20);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(494, 167);
            this.textBox.TabIndex = 0;
            this.textBox.TabStop = false;
            this.textBox.Text = "textBox";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // leftBtn1
            // 
            this.leftBtn1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBtn1.Location = new System.Drawing.Point(23, 280);
            this.leftBtn1.Name = "leftBtn1";
            this.leftBtn1.Size = new System.Drawing.Size(81, 28);
            this.leftBtn1.TabIndex = 12;
            this.leftBtn1.Text = "leftBtn1";
            this.leftBtn1.UseVisualStyleBackColor = true;
            // 
            // rightBtn2
            // 
            this.rightBtn2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBtn2.Location = new System.Drawing.Point(509, 280);
            this.rightBtn2.Name = "rightBtn2";
            this.rightBtn2.Size = new System.Drawing.Size(81, 28);
            this.rightBtn2.TabIndex = 11;
            this.rightBtn2.Text = "rightBtn2";
            this.rightBtn2.UseVisualStyleBackColor = true;
            // 
            // rightBtn1
            // 
            this.rightBtn1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBtn1.Location = new System.Drawing.Point(596, 280);
            this.rightBtn1.Name = "rightBtn1";
            this.rightBtn1.Size = new System.Drawing.Size(81, 28);
            this.rightBtn1.TabIndex = 10;
            this.rightBtn1.Text = "rightBtn1";
            this.rightBtn1.UseVisualStyleBackColor = true;
            // 
            // midGroupBox
            // 
            this.midGroupBox.Controls.Add(this.textBox);
            this.midGroupBox.Location = new System.Drawing.Point(87, 56);
            this.midGroupBox.Name = "midGroupBox";
            this.midGroupBox.Size = new System.Drawing.Size(527, 206);
            this.midGroupBox.TabIndex = 9;
            this.midGroupBox.TabStop = false;
            // 
            // TemplateType2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.leftBtn1);
            this.Controls.Add(this.rightBtn2);
            this.Controls.Add(this.rightBtn1);
            this.Controls.Add(this.midGroupBox);
            this.Name = "TemplateType2";
            this.Size = new System.Drawing.Size(700, 333);
            this.midGroupBox.ResumeLayout(false);
            this.midGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button leftBtn1;
        private System.Windows.Forms.Button rightBtn2;
        private System.Windows.Forms.Button rightBtn1;
        private System.Windows.Forms.GroupBox midGroupBox;
    }
}
