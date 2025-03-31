namespace _000_bmi_cs
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
            this.btnBMI = new System.Windows.Forms.Button();
            this.lblC = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(279, 250);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(75, 23);
            this.btnBMI.TabIndex = 0;
            this.btnBMI.Text = "BMI 계산";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(183, 124);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(53, 15);
            this.lblC.TabIndex = 1;
            this.lblC.Text = "키(cm)";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(183, 180);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(64, 15);
            this.lblK.TabIndex = 2;
            this.lblK.Text = "체중(kg)";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(197, 303);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 15);
            this.lblBMI.TabIndex = 3;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(254, 121);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 25);
            this.txtC.TabIndex = 4;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(254, 177);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 25);
            this.txtK.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.btnBMI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtK;
    }
}

