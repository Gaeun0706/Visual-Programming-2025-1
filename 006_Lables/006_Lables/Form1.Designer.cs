namespace _006_Lables
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
            this.btnRaffaello = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblArt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRaffaello
            // 
            this.btnRaffaello.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRaffaello.Location = new System.Drawing.Point(62, 66);
            this.btnRaffaello.Name = "btnRaffaello";
            this.btnRaffaello.Size = new System.Drawing.Size(189, 47);
            this.btnRaffaello.TabIndex = 0;
            this.btnRaffaello.Text = "라파엘로, 아테네 학당";
            this.btnRaffaello.UseVisualStyleBackColor = true;
            this.btnRaffaello.Click += new System.EventHandler(this.btnRaffaello_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnD.Location = new System.Drawing.Point(270, 66);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(150, 47);
            this.btnD.TabIndex = 1;
            this.btnD.Text = "다빈치, 모나리자";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(59, 130);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(0, 15);
            this.lblArtist.TabIndex = 2;
            // 
            // lblArt
            // 
            this.lblArt.Location = new System.Drawing.Point(59, 184);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(698, 257);
            this.lblArt.TabIndex = 3;
            this.lblArt.Click += new System.EventHandler(this.lblArt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnRaffaello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRaffaello;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblArt;
    }
}

