namespace prj_gui
{
    partial class billing
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
            number = new TextBox();
            inTime = new TextBox();
            outTime = new TextBox();
            usageTime = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            parkingFee = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // number
            // 
            number.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            number.Location = new Point(258, 41);
            number.Name = "number";
            number.Size = new Size(424, 43);
            number.TabIndex = 0;
            // 
            // inTime
            // 
            inTime.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            inTime.Location = new Point(258, 103);
            inTime.Name = "inTime";
            inTime.Size = new Size(424, 43);
            inTime.TabIndex = 1;
            // 
            // outTime
            // 
            outTime.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            outTime.Location = new Point(258, 164);
            outTime.Name = "outTime";
            outTime.Size = new Size(424, 43);
            outTime.TabIndex = 2;
            // 
            // usageTime
            // 
            usageTime.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            usageTime.Location = new Point(258, 229);
            usageTime.Name = "usageTime";
            usageTime.Size = new Size(424, 43);
            usageTime.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(275, 369);
            button1.Name = "button1";
            button1.Size = new Size(242, 55);
            button1.TabIndex = 5;
            button1.Text = "결제하기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(99, 44);
            label1.Name = "label1";
            label1.Size = new Size(125, 37);
            label1.TabIndex = 7;
            label1.Text = "차량번호";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(99, 106);
            label2.Name = "label2";
            label2.Size = new Size(125, 37);
            label2.TabIndex = 8;
            label2.Text = "입차시간";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(99, 167);
            label3.Name = "label3";
            label3.Size = new Size(125, 37);
            label3.TabIndex = 9;
            label3.Text = "출차시간";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(99, 297);
            label4.Name = "label4";
            label4.Size = new Size(125, 37);
            label4.TabIndex = 11;
            label4.Text = "주차요금";
            // 
            // parkingFee
            // 
            parkingFee.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            parkingFee.Location = new Point(258, 294);
            parkingFee.Name = "parkingFee";
            parkingFee.Size = new Size(424, 43);
            parkingFee.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(99, 232);
            label5.Name = "label5";
            label5.Size = new Size(125, 37);
            label5.TabIndex = 10;
            label5.Text = "이용시간";
            // 
            // billing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(parkingFee);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(usageTime);
            Controls.Add(outTime);
            Controls.Add(inTime);
            Controls.Add(number);
            Name = "billing";
            Text = "주차 정산";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox number;
        private TextBox inTime;
        private TextBox outTime;
        private TextBox usageTime;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox parkingFee;
        private Label label5;
    }
}