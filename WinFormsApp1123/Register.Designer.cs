namespace WinFormsApp1123
{
    partial class Register
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
            address_tx = new TextBox();
            phonenum_tx = new TextBox();
            email_tx = new TextBox();
            Name_tx = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label2 = new Label();
            button1 = new Button();
            password_tx = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // address_tx
            // 
            address_tx.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            address_tx.Location = new Point(417, 256);
            address_tx.Name = "address_tx";
            address_tx.Size = new Size(297, 41);
            address_tx.TabIndex = 52;
            address_tx.TextChanged += textBox4_TextChanged;
            // 
            // phonenum_tx
            // 
            phonenum_tx.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            phonenum_tx.Location = new Point(417, 209);
            phonenum_tx.Name = "phonenum_tx";
            phonenum_tx.Size = new Size(297, 41);
            phonenum_tx.TabIndex = 51;
            phonenum_tx.TextChanged += textBox3_TextChanged;
            // 
            // email_tx
            // 
            email_tx.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            email_tx.Location = new Point(417, 115);
            email_tx.Name = "email_tx";
            email_tx.Size = new Size(297, 41);
            email_tx.TabIndex = 50;
            email_tx.TextChanged += textBox2_TextChanged;
            // 
            // Name_tx
            // 
            Name_tx.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name_tx.Location = new Point(417, 68);
            Name_tx.Name = "Name_tx";
            Name_tx.Size = new Size(297, 41);
            Name_tx.TabIndex = 49;
            Name_tx.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(234, 71);
            label6.Name = "label6";
            label6.Size = new Size(75, 28);
            label6.TabIndex = 47;
            label6.Text = "Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(228, 259);
            label7.Name = "label7";
            label7.Size = new Size(94, 28);
            label7.TabIndex = 46;
            label7.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(228, 212);
            label8.Name = "label8";
            label8.Size = new Size(161, 28);
            label8.TabIndex = 45;
            label8.Text = "Phone number:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(234, 118);
            label9.Name = "label9";
            label9.Size = new Size(71, 28);
            label9.TabIndex = 44;
            label9.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(417, 24);
            label2.Name = "label2";
            label2.Size = new Size(199, 41);
            label2.TabIndex = 59;
            label2.Text = "Registration";
            // 
            // button1
            // 
            button1.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(504, 337);
            button1.Name = "button1";
            button1.Size = new Size(112, 41);
            button1.TabIndex = 60;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // password_tx
            // 
            password_tx.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            password_tx.Location = new Point(417, 162);
            password_tx.Name = "password_tx";
            password_tx.Size = new Size(297, 41);
            password_tx.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(228, 165);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 61;
            label3.Text = "Password:";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 452);
            Controls.Add(password_tx);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(address_tx);
            Controls.Add(phonenum_tx);
            Controls.Add(email_tx);
            Controls.Add(Name_tx);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox address_tx;
        private TextBox phonenum_tx;
        private TextBox email_tx;
        private TextBox Name_tx;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
        private Label label2;
        private Button button1;
        private TextBox password_tx;
        private Label label3;
    }
}