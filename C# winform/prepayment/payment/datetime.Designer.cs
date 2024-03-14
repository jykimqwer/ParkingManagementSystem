namespace prj_gui
{
    partial class datetime
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
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(97, 132);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(372, 132);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(189, 357);
            button1.Name = "button1";
            button1.Size = new Size(108, 55);
            button1.TabIndex = 2;
            button1.Text = "조회하기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(372, 357);
            button2.Name = "button2";
            button2.Size = new Size(108, 55);
            button2.TabIndex = 3;
            button2.Text = "조회취소";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // datetime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Name = "datetime";
            Text = "datetime";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Button button1;
        private Button button2;
    }
}