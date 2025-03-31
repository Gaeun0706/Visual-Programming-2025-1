namespace _003_Login_cs
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lblpw = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("안동엄마까투리", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnlogin.Location = new System.Drawing.Point(286, 204);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(129, 32);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "로그인";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("안동엄마까투리", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblid.Location = new System.Drawing.Point(91, 99);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(67, 23);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "아이디";
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Font = new System.Drawing.Font("안동엄마까투리", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblpw.Location = new System.Drawing.Point(91, 151);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(82, 23);
            this.lblpw.TabIndex = 2;
            this.lblpw.Text = "패스워드";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(179, 99);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(236, 25);
            this.txtid.TabIndex = 3;
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(179, 154);
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '●';
            this.txtpw.Size = new System.Drawing.Size(236, 25);
            this.txtpw.TabIndex = 4;
            // 
            // txtlogin
            // 
            this.txtlogin.Font = new System.Drawing.Font("안동엄마까투리", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtlogin.Location = new System.Drawing.Point(286, 252);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.ReadOnly = true;
            this.txtlogin.Size = new System.Drawing.Size(129, 31);
            this.txtlogin.TabIndex = 5;
            this.txtlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblpw);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnlogin);
            this.Name = "Form1";
            this.Text = "아이디";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.TextBox txtlogin;
    }
}

