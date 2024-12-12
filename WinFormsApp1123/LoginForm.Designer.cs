namespace _5RYA
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
            Wmail_lb = new Label();
            Password_lb = new Label();
            UserName_tx = new TextBox();
            Password_tx = new TextBox();
            Login_bt = new Button();
            SuspendLayout();
            // 
            // Wmail_lb
            // 
            Wmail_lb.AutoSize = true;
            Wmail_lb.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Wmail_lb.Location = new Point(92, 90);
            Wmail_lb.Name = "Wmail_lb";
            Wmail_lb.Size = new Size(63, 28);
            Wmail_lb.TabIndex = 0;
            Wmail_lb.Text = "Email";
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
            // UserName_tx
            // 
            UserName_tx.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UserName_tx.Location = new Point(219, 87);
            UserName_tx.Name = "UserName_tx";
            UserName_tx.Size = new Size(165, 41);
            UserName_tx.TabIndex = 2;
            // 
            // Password_tx
            // 
            Password_tx.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Password_tx.Location = new Point(219, 167);
            Password_tx.Name = "Password_tx";
            Password_tx.Size = new Size(165, 41);
            Password_tx.TabIndex = 3;
            Password_tx.TextChanged += Password_tx_TextChanged;
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 396);
            Controls.Add(Login_bt);
            Controls.Add(Password_tx);
            Controls.Add(UserName_tx);
            Controls.Add(Password_lb);
            Controls.Add(Wmail_lb);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Wmail_lb;
        private Label Password_lb;
        private TextBox UserName_tx;
        private TextBox Password_tx;
        private Button Login_bt;
    }
}