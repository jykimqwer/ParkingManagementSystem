namespace prj_gui
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            mainID = new TextBox();
            mainPW = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(569, 108);
            button1.Name = "button1";
            button1.Size = new Size(124, 89);
            button1.TabIndex = 0;
            button1.Text = "로그인";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DB_Conn;
            button1.KeyDown += Main_KeyDown;
            // 
            // mainID
            // 
            mainID.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            mainID.Location = new Point(220, 117);
            mainID.Name = "mainID";
            mainID.Size = new Size(297, 35);
            mainID.TabIndex = 1;
            // 
            // mainPW
            // 
            mainPW.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            mainPW.Location = new Point(219, 162);
            mainPW.Name = "mainPW";
            mainPW.Size = new Size(298, 35);
            mainPW.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(93, 117);
            label1.Name = "label1";
            label1.Size = new Size(86, 30);
            label1.TabIndex = 5;
            label1.Text = "아이디";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(93, 165);
            label2.Name = "label2";
            label2.Size = new Size(97, 30);
            label2.TabIndex = 6;
            label2.Text = "비밀번호";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 316);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mainPW);
            Controls.Add(mainID);
            Controls.Add(button1);
            Name = "Main";
            Text = "관리자 로그인";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox mainID;
        private TextBox mainPW;
        private Label label1;
        private Label label2;
    }
}