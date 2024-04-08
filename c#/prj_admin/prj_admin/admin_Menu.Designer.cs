namespace prj_admin
{
    partial class admin_Menu
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.costLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.saveExcel = new System.Windows.Forms.Button();
            this.durationSearch = new System.Windows.Forms.Button();
            this.yearSearch = new System.Windows.Forms.Button();
            this.monthSearch = new System.Windows.Forms.Button();
            this.daySearch = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.carNumberText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.costLabel);
            this.tabPage2.Controls.Add(this.totalLabel);
            this.tabPage2.Controls.Add(this.exitBtn);
            this.tabPage2.Controls.Add(this.printBtn);
            this.tabPage2.Controls.Add(this.saveExcel);
            this.tabPage2.Controls.Add(this.durationSearch);
            this.tabPage2.Controls.Add(this.yearSearch);
            this.tabPage2.Controls.Add(this.monthSearch);
            this.tabPage2.Controls.Add(this.daySearch);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "총 사용량 조회";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(717, 448);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(38, 12);
            this.costLabel.TabIndex = 9;
            this.costLabel.Text = "label2";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(538, 448);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(38, 12);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "label1";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(702, 498);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(167, 45);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "종료";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(254, 498);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(167, 45);
            this.printBtn.TabIndex = 6;
            this.printBtn.Text = "출력";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // saveExcel
            // 
            this.saveExcel.Location = new System.Drawing.Point(31, 498);
            this.saveExcel.Name = "saveExcel";
            this.saveExcel.Size = new System.Drawing.Size(167, 45);
            this.saveExcel.TabIndex = 5;
            this.saveExcel.Text = "excel 열기";
            this.saveExcel.UseVisualStyleBackColor = true;
            this.saveExcel.Click += new System.EventHandler(this.button5_Click);
            // 
            // durationSearch
            // 
            this.durationSearch.Location = new System.Drawing.Point(702, 29);
            this.durationSearch.Name = "durationSearch";
            this.durationSearch.Size = new System.Drawing.Size(167, 45);
            this.durationSearch.TabIndex = 4;
            this.durationSearch.Text = "기간 조회";
            this.durationSearch.UseVisualStyleBackColor = true;
            this.durationSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // yearSearch
            // 
            this.yearSearch.Location = new System.Drawing.Point(477, 29);
            this.yearSearch.Name = "yearSearch";
            this.yearSearch.Size = new System.Drawing.Size(167, 45);
            this.yearSearch.TabIndex = 3;
            this.yearSearch.Text = "연도별 조회";
            this.yearSearch.UseVisualStyleBackColor = true;
            this.yearSearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // monthSearch
            // 
            this.monthSearch.Location = new System.Drawing.Point(254, 29);
            this.monthSearch.Name = "monthSearch";
            this.monthSearch.Size = new System.Drawing.Size(167, 45);
            this.monthSearch.TabIndex = 2;
            this.monthSearch.Text = "월별 조회";
            this.monthSearch.UseVisualStyleBackColor = true;
            this.monthSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // daySearch
            // 
            this.daySearch.Location = new System.Drawing.Point(31, 29);
            this.daySearch.Name = "daySearch";
            this.daySearch.Size = new System.Drawing.Size(167, 45);
            this.daySearch.TabIndex = 1;
            this.daySearch.Text = "당일 조회";
            this.daySearch.UseVisualStyleBackColor = true;
            this.daySearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 91);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(838, 343);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.carNumberText);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(906, 566);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "차량조회";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(300, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "차량번호를 입력하세요";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "프로그램 종료";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "차단기 열기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // carNumberText
            // 
            this.carNumberText.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.carNumberText.Location = new System.Drawing.Point(157, 114);
            this.carNumberText.Name = "carNumberText";
            this.carNumberText.Size = new System.Drawing.Size(444, 35);
            this.carNumberText.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(836, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(300, 50);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 624);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // admin_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 649);
            this.Controls.Add(this.tabControl1);
            this.Name = "admin_Menu";
            this.Text = "admin_Menu";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button saveExcel;
        private System.Windows.Forms.Button durationSearch;
        private System.Windows.Forms.Button yearSearch;
        private System.Windows.Forms.Button monthSearch;
        private System.Windows.Forms.Button daySearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox carNumberText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}