namespace prj_parking
{
    partial class prepay
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
            this.parkingFee = new System.Windows.Forms.TextBox();
            this.usageTime = new System.Windows.Forms.TextBox();
            this.textOutTime = new System.Windows.Forms.TextBox();
            this.textInTime = new System.Windows.Forms.TextBox();
            this.textCarNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // parkingFee
            // 
            this.parkingFee.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.parkingFee.Location = new System.Drawing.Point(239, 292);
            this.parkingFee.Name = "parkingFee";
            this.parkingFee.Size = new System.Drawing.Size(409, 39);
            this.parkingFee.TabIndex = 9;
            // 
            // usageTime
            // 
            this.usageTime.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.usageTime.Location = new System.Drawing.Point(239, 228);
            this.usageTime.Name = "usageTime";
            this.usageTime.Size = new System.Drawing.Size(409, 39);
            this.usageTime.TabIndex = 8;
            // 
            // textOutTime
            // 
            this.textOutTime.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textOutTime.Location = new System.Drawing.Point(239, 165);
            this.textOutTime.Name = "textOutTime";
            this.textOutTime.Size = new System.Drawing.Size(409, 39);
            this.textOutTime.TabIndex = 7;
            // 
            // textInTime
            // 
            this.textInTime.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textInTime.Location = new System.Drawing.Point(239, 101);
            this.textInTime.Name = "textInTime";
            this.textInTime.Size = new System.Drawing.Size(409, 39);
            this.textInTime.TabIndex = 6;
            // 
            // textCarNum
            // 
            this.textCarNum.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textCarNum.Location = new System.Drawing.Point(239, 40);
            this.textCarNum.Name = "textCarNum";
            this.textCarNum.Size = new System.Drawing.Size(409, 39);
            this.textCarNum.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 67);
            this.button1.TabIndex = 10;
            this.button1.Text = "결제하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.socket_connect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(77, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "차량번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(77, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "입차시간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(77, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "출차시간";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(77, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "이용요금";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(77, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "이용시간";
            // 
            // prepay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 503);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.parkingFee);
            this.Controls.Add(this.usageTime);
            this.Controls.Add(this.textOutTime);
            this.Controls.Add(this.textInTime);
            this.Controls.Add(this.textCarNum);
            this.Name = "prepay";
            this.Text = "사전정산";
            this.Load += new System.EventHandler(this.prepay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox parkingFee;
        private System.Windows.Forms.TextBox usageTime;
        private System.Windows.Forms.TextBox textOutTime;
        private System.Windows.Forms.TextBox textInTime;
        private System.Windows.Forms.TextBox textCarNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}