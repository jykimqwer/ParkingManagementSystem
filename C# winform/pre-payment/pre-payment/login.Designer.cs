namespace prj_parking
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginID = new System.Windows.Forms.TextBox();
            this.loginPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(101, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // loginID
            // 
            this.loginID.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginID.Location = new System.Drawing.Point(229, 149);
            this.loginID.Name = "loginID";
            this.loginID.Size = new System.Drawing.Size(322, 35);
            this.loginID.TabIndex = 1;
            // 
            // loginPW
            // 
            this.loginPW.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginPW.Location = new System.Drawing.Point(229, 207);
            this.loginPW.Name = "loginPW";
            this.loginPW.Size = new System.Drawing.Size(322, 35);
            this.loginPW.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(101, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "비밀번호";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(608, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 100);
            this.button1.TabIndex = 4;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginPW);
            this.Controls.Add(this.loginID);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginID;
        private System.Windows.Forms.TextBox loginPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

