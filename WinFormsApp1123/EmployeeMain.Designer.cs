namespace WinFormsApp1123
{
    partial class EmployeeMain
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // button1
            // 
            button1.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(130, 118);
            button1.Name = "button1";
            button1.Size = new Size(247, 66);
            button1.TabIndex = 1;
            button1.Text = "Review Contract";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(130, 211);
            button2.Name = "button2";
            button2.Size = new Size(247, 86);
            button2.TabIndex = 1;
            button2.Text = "Review Employee Information";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(130, 325);
            button3.Name = "button3";
            button3.Size = new Size(247, 84);
            button3.TabIndex = 2;
            button3.Text = "Kit Sumbmission";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(441, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 36);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(441, 239);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(244, 36);
            comboBox2.TabIndex = 4;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(441, 352);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(244, 36);
            comboBox3.TabIndex = 5;
            // 
            // EmployeeMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 599);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "EmployeeMain";
            Text = "EmployeeMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}