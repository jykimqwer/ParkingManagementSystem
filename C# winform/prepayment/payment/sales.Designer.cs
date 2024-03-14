namespace prj_gui
{
    partial class sales
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
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            Excel = new Button();
            print = new Button();
            totalLabel = new Label();
            costLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(713, 233);
            dataGridView1.TabIndex = 10;
            // 
            // button4
            // 
            button4.Location = new Point(597, 40);
            button4.Name = "button4";
            button4.Size = new Size(160, 42);
            button4.TabIndex = 9;
            button4.Text = "기간 이용 조회";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(408, 40);
            button3.Name = "button3";
            button3.Size = new Size(160, 42);
            button3.TabIndex = 8;
            button3.Text = "해당연도 이용 조회";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(227, 40);
            button2.Name = "button2";
            button2.Size = new Size(160, 42);
            button2.TabIndex = 7;
            button2.Text = "월별 이용 조회";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(44, 40);
            button1.Name = "button1";
            button1.Size = new Size(160, 42);
            button1.TabIndex = 6;
            button1.Text = "일일 이용 조회";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(635, 388);
            button5.Name = "button5";
            button5.Size = new Size(122, 39);
            button5.TabIndex = 11;
            button5.Text = "종료";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Excel
            // 
            Excel.Location = new Point(44, 388);
            Excel.Name = "Excel";
            Excel.Size = new Size(122, 39);
            Excel.TabIndex = 12;
            Excel.Text = "Excel 저장";
            Excel.UseVisualStyleBackColor = true;
            Excel.Click += button6_Click;
            // 
            // print
            // 
            print.Location = new Point(190, 388);
            print.Name = "print";
            print.Size = new Size(122, 39);
            print.TabIndex = 13;
            print.Text = "출력";
            print.UseVisualStyleBackColor = true;
            print.Click += print_Click;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(514, 353);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(39, 15);
            totalLabel.TabIndex = 14;
            totalLabel.Text = "label1";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(625, 353);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(39, 15);
            costLabel.TabIndex = 15;
            costLabel.Text = "label1";
            // 
            // sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(costLabel);
            Controls.Add(totalLabel);
            Controls.Add(print);
            Controls.Add(Excel);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "sales";
            Text = "매출 조회";
            Load += sales_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button Excel;
        private Button print;
        private Label totalLabel;
        private Label costLabel;
    }
}