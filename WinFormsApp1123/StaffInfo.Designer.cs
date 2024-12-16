namespace WinFormsApp1123
{
    partial class StaffInfo
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
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            label7 = new Label();
            label10 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(322, 32);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 0;
            label1.Text = "Staff ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(282, 116);
            label6.Name = "label6";
            label6.Size = new Size(75, 28);
            label6.TabIndex = 8;
            label6.Text = "Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(282, 210);
            label8.Name = "label8";
            label8.Size = new Size(161, 28);
            label8.TabIndex = 6;
            label8.Text = "Phone number:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(282, 163);
            label9.Name = "label9";
            label9.Size = new Size(71, 28);
            label9.TabIndex = 5;
            label9.Text = "Email:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(459, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 36);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "    ~~Select Staff~~";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(465, 113);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(217, 41);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(465, 160);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(217, 41);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(465, 207);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(217, 41);
            textBox3.TabIndex = 13;
            // 
            // button2
            // 
            button2.Font = new Font("MV Boli", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(386, 380);
            button2.Name = "button2";
            button2.Size = new Size(229, 44);
            button2.TabIndex = 21;
            button2.Text = "Export As PDF";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(282, 257);
            label7.Name = "label7";
            label7.Size = new Size(94, 28);
            label7.TabIndex = 7;
            label7.Text = "Address:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(282, 314);
            label10.Name = "label10";
            label10.Size = new Size(138, 28);
            label10.TabIndex = 10;
            label10.Text = "Department:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(465, 254);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(217, 41);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(465, 311);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(217, 41);
            textBox5.TabIndex = 15;
            // 
            // button1
            // 
            button1.Font = new Font("MV Boli", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 11);
            button1.Name = "button1";
            button1.Size = new Size(106, 49);
            button1.TabIndex = 22;
            button1.Text = "<-Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StaffInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 449);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "StaffInfo";
            Text = "Staff Information";
            Load += StaffInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private Label label7;
        private Label label10;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
    }
}