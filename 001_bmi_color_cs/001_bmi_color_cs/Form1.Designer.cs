namespace _001_bmi_color_cs
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
            this.btnbmi = new System.Windows.Forms.Button();
            this.lblc = new System.Windows.Forms.Label();
            this.lblk = new System.Windows.Forms.Label();
            this.lblbmi = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtk = new System.Windows.Forms.TextBox();
            this.lblp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbmi
            // 
            this.btnbmi.Location = new System.Drawing.Point(308, 192);
            this.btnbmi.Name = "btnbmi";
            this.btnbmi.Size = new System.Drawing.Size(87, 23);
            this.btnbmi.TabIndex = 0;
            this.btnbmi.Text = "BMI 계산";
            this.btnbmi.UseVisualStyleBackColor = true;
            this.btnbmi.Click += new System.EventHandler(this.btnbmi_Click);
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(132, 76);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(53, 15);
            this.lblc.TabIndex = 1;
            this.lblc.Text = "키(cm)";
            // 
            // lblk
            // 
            this.lblk.AutoSize = true;
            this.lblk.Location = new System.Drawing.Point(132, 130);
            this.lblk.Name = "lblk";
            this.lblk.Size = new System.Drawing.Size(64, 15);
            this.lblk.TabIndex = 2;
            this.lblk.Text = "체중(kg)";
            // 
            // lblbmi
            // 
            this.lblbmi.AutoSize = true;
            this.lblbmi.Location = new System.Drawing.Point(132, 234);
            this.lblbmi.Name = "lblbmi";
            this.lblbmi.Size = new System.Drawing.Size(50, 15);
            this.lblbmi.TabIndex = 3;
            this.lblbmi.Text = "BMI = ";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(212, 73);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(183, 25);
            this.txtc.TabIndex = 4;
            // 
            // txtk
            // 
            this.txtk.Location = new System.Drawing.Point(212, 130);
            this.txtk.Name = "txtk";
            this.txtk.Size = new System.Drawing.Size(183, 25);
            this.txtk.TabIndex = 5;
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Location = new System.Drawing.Point(132, 288);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(52, 15);
            this.lblp.TabIndex = 6;
            this.lblp.Text = "판정 : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(308, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblp);
            this.Controls.Add(this.txtk);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.lblbmi);
            this.Controls.Add(this.lblk);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.btnbmi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbmi;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lblk;
        private System.Windows.Forms.Label lblbmi;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtk;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

