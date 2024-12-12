namespace WinFormsApp1123
{
    partial class ReviewContract
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox3 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 0;
            label1.Text = "Client Name:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(316, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 36);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "   --Select Client--";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(316, 83);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(231, 36);
            comboBox2.TabIndex = 3;
            comboBox2.Text = " --Select Contract--";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 86);
            label2.Name = "label2";
            label2.Size = new Size(193, 28);
            label2.TabIndex = 2;
            label2.Text = "Contract Number:";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(316, 148);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(231, 36);
            comboBox3.TabIndex = 5;
            comboBox3.Text = "   --Select Date--";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 151);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 4;
            label3.Text = "Date:";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("MV Boli", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(267, 303);
            button1.Name = "button1";
            button1.Size = new Size(120, 47);
            button1.TabIndex = 6;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(443, 303);
            button2.Name = "button2";
            button2.Size = new Size(127, 47);
            button2.TabIndex = 7;
            button2.Text = "Export as pdf";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("MV Boli", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(620, 303);
            button3.Name = "button3";
            button3.Size = new Size(120, 47);
            button3.TabIndex = 8;
            button3.Text = "View";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 405);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Review Client Contract";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox3;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}