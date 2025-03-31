namespace _008_RadioButton
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbK = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbJ = new System.Windows.Forms.RadioButton();
            this.rbOthers = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFimale = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOthers);
            this.groupBox1.Controls.Add(this.rbJ);
            this.groupBox1.Controls.Add(this.rbC);
            this.groupBox1.Controls.Add(this.rbK);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(59, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "국적";
            // 
            // rbK
            // 
            this.rbK.AutoSize = true;
            this.rbK.Location = new System.Drawing.Point(17, 45);
            this.rbK.Name = "rbK";
            this.rbK.Size = new System.Drawing.Size(99, 27);
            this.rbK.TabIndex = 0;
            this.rbK.TabStop = true;
            this.rbK.Text = "대한민국";
            this.rbK.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(17, 70);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(65, 27);
            this.rbC.TabIndex = 1;
            this.rbC.TabStop = true;
            this.rbC.Text = "중국";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbJ
            // 
            this.rbJ.AutoSize = true;
            this.rbJ.Location = new System.Drawing.Point(17, 95);
            this.rbJ.Name = "rbJ";
            this.rbJ.Size = new System.Drawing.Size(65, 27);
            this.rbJ.TabIndex = 2;
            this.rbJ.TabStop = true;
            this.rbJ.Text = "일본";
            this.rbJ.UseVisualStyleBackColor = true;
            // 
            // rbOthers
            // 
            this.rbOthers.AutoSize = true;
            this.rbOthers.Location = new System.Drawing.Point(17, 120);
            this.rbOthers.Name = "rbOthers";
            this.rbOthers.Size = new System.Drawing.Size(111, 27);
            this.rbOthers.TabIndex = 3;
            this.rbOthers.TabStop = true;
            this.rbOthers.Text = "그 외 국가";
            this.rbOthers.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFimale);
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(326, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(27, 34);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 27);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "남";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFimale
            // 
            this.rbFimale.AutoSize = true;
            this.rbFimale.Location = new System.Drawing.Point(27, 59);
            this.rbFimale.Name = "rbFimale";
            this.rbFimale.Size = new System.Drawing.Size(48, 27);
            this.rbFimale.TabIndex = 1;
            this.rbFimale.TabStop = true;
            this.rbFimale.Text = "여";
            this.rbFimale.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSubmit.Location = new System.Drawing.Point(445, 195);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 41);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "제출";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOthers;
        private System.Windows.Forms.RadioButton rbJ;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFimale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btnSubmit;
    }
}

