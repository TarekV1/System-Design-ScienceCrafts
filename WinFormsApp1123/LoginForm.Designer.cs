﻿namespace Login
{
    partial class LoginForm
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
            Email_lb = new Label();
            Password_lb = new Label();
            Email_tx = new TextBox();
            Password_tx = new TextBox();
            Login_bt = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Email_lb
            // 
            Email_lb.AutoSize = true;
            Email_lb.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Email_lb.Location = new Point(92, 90);
            Email_lb.Name = "Email_lb";
            Email_lb.Size = new Size(63, 28);
            Email_lb.TabIndex = 0;
            Email_lb.Text = "Email";
            // 
            // Password_lb
            // 
            Password_lb.AutoSize = true;
            Password_lb.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Password_lb.Location = new Point(74, 170);
            Password_lb.Name = "Password_lb";
            Password_lb.Size = new Size(100, 28);
            Password_lb.TabIndex = 1;
            Password_lb.Text = "Password";
            // 
            // Email_tx
            // 
            Email_tx.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Email_tx.Location = new Point(219, 87);
            Email_tx.Name = "Email_tx";
            Email_tx.Size = new Size(165, 41);
            Email_tx.TabIndex = 2;
            Email_tx.TextChanged += Email_tx_TextChanged;
            Email_tx.Validating += Email_tx_Validating;
            // 
            // Password_tx
            // 
            Password_tx.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Password_tx.Location = new Point(219, 167);
            Password_tx.Name = "Password_tx";
            Password_tx.Size = new Size(165, 41);
            Password_tx.TabIndex = 3;
            Password_tx.UseSystemPasswordChar = true;
            Password_tx.Validating += Password_tx_Validating;
            // 
            // Login_bt
            // 
            Login_bt.Font = new Font("MV Boli", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Login_bt.Location = new Point(194, 303);
            Login_bt.Name = "Login_bt";
            Login_bt.Size = new Size(113, 55);
            Login_bt.TabIndex = 4;
            Login_bt.Text = "Login";
            Login_bt.UseVisualStyleBackColor = true;
            Login_bt.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(408, 360);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 5;
            label1.Text = "Register?";
            label1.Click += label1_Click;
            label1.MouseLeave += label1_MouseLeave;
            label1.MouseHover += label1_MouseHover;
            // 
            // button1
            // 
            button1.Font = new Font("MV Boli", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(106, 49);
            button1.TabIndex = 6;
            button1.Text = "<-Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 397);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Login_bt);
            Controls.Add(Password_tx);
            Controls.Add(Email_tx);
            Controls.Add(Password_lb);
            Controls.Add(Email_lb);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Email_lb;
        private Label Password_lb;
        private TextBox Email_tx;
        private TextBox Password_tx;
        private Button Login_bt;
        private Label label1;
        private Button button1;
    }
}