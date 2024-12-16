namespace WinFormsApp1123
{
    partial class Order_Form
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
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(321, 46);
            label1.TabIndex = 0;
            label1.Text = "Service Submission";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 205);
            label2.Name = "label2";
            label2.Size = new Size(112, 31);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(91, 262);
            label3.Name = "label3";
            label3.Size = new Size(96, 31);
            label3.TabIndex = 2;
            label3.Text = "Courses";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(91, 327);
            label4.Name = "label4";
            label4.Size = new Size(101, 31);
            label4.TabIndex = 3;
            label4.Text = "Services";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(214, 397);
            label5.Name = "label5";
            label5.Size = new Size(101, 31);
            label5.TabIndex = 4;
            label5.Text = "Price : ";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Educational", "Entertainment", "Learning Disabilities" });
            comboBox1.Location = new Point(290, 205);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 36);
            comboBox1.TabIndex = 5;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectedValueChanged;
            comboBox1.SelectedValueChanged += calcPrice;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Physics", "Communicational Skills", "Educational Skills" });
            comboBox2.Location = new Point(290, 262);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(204, 36);
            comboBox2.TabIndex = 6;
            comboBox2.SelectionChangeCommitted += comboBox2_SelectedValueChanged;
            comboBox2.SelectedValueChanged += calcPrice;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Trainning", "Sessions", "Kits/Toys" });
            comboBox3.Location = new Point(290, 322);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(204, 36);
            comboBox3.TabIndex = 7;
            comboBox3.SelectionChangeCommitted += comboBox3_SelectedValueChanged;
            comboBox3.SelectedValueChanged += calcPrice;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(91, 90);
            label6.Name = "label6";
            label6.Size = new Size(73, 31);
            label6.TabIndex = 8;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(78, 142);
            label7.Name = "label7";
            label7.Size = new Size(181, 31);
            label7.TabIndex = 9;
            label7.Text = "Phone Number";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("MV Boli", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(290, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 38);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("MV Boli", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(290, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 38);
            textBox2.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(572, 407);
            button1.Name = "button1";
            button1.Size = new Size(105, 60);
            button1.TabIndex = 12;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("MV Boli", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 9);
            button2.Name = "button2";
            button2.Size = new Size(106, 49);
            button2.TabIndex = 13;
            button2.Text = "<-Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Order_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 479);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Order_Form";
            Text = "Order_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}