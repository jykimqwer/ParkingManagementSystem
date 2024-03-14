namespace prj_gui
{
    partial class New_account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textid = new TextBox();
            textpw = new TextBox();
            textname = new TextBox();
            textemail = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textcpw = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 79);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 8;
            label1.Text = "아이디";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 116);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 9;
            label2.Text = "비밀번호";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 198);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 11;
            label3.Text = "이름";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 238);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 12;
            label4.Text = "e-mail";
            // 
            // textid
            // 
            textid.Location = new Point(294, 76);
            textid.Name = "textid";
            textid.Size = new Size(234, 23);
            textid.TabIndex = 1;
            // 
            // textpw
            // 
            textpw.Location = new Point(294, 114);
            textpw.Name = "textpw";
            textpw.Size = new Size(234, 23);
            textpw.TabIndex = 2;
            // 
            // textname
            // 
            textname.Location = new Point(294, 195);
            textname.Name = "textname";
            textname.Size = new Size(234, 23);
            textname.TabIndex = 4;
            // 
            // textemail
            // 
            textemail.Location = new Point(294, 235);
            textemail.Name = "textemail";
            textemail.Size = new Size(234, 23);
            textemail.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(186, 339);
            button1.Name = "button1";
            button1.Size = new Size(128, 42);
            button1.TabIndex = 6;
            button1.Text = "등록";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(400, 339);
            button2.Name = "button2";
            button2.Size = new Size(128, 42);
            button2.TabIndex = 7;
            button2.Text = "취소";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textcpw
            // 
            textcpw.Location = new Point(294, 152);
            textcpw.Name = "textcpw";
            textcpw.Size = new Size(234, 23);
            textcpw.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(185, 157);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 10;
            label5.Text = "비밀번호 확인";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(549, 79);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 13;
            label6.Text = "4자 이상 12자 이하";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(549, 117);
            label7.Name = "label7";
            label7.Size = new Size(112, 15);
            label7.TabIndex = 14;
            label7.Text = "4자 이상 12자 이하";
            // 
            // New_account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textcpw);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textemail);
            Controls.Add(textname);
            Controls.Add(textpw);
            Controls.Add(textid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "New_account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "관리자 회원 가입";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textid;
        private TextBox textpw;
        private TextBox textname;
        private TextBox textemail;
        private Button button1;
        private Button button2;
        private TextBox textcpw;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}