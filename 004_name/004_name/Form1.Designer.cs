namespace _004_name
{
    partial class Form1
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
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnc = new System.Windows.Forms.Button();
            this.lblN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(132, 77);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(47, 15);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "이름 :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(215, 74);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 25);
            this.txtname.TabIndex = 1;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(327, 75);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(75, 23);
            this.btnc.TabIndex = 2;
            this.btnc.Text = "클릭";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(132, 127);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 15);
            this.lblN.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 307);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Basic Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Label lblN;
    }
}

