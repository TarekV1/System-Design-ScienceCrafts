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
            button1.Size = new Size(263, 66);
            button1.TabIndex = 1;
            button1.Text = "Review A Contract";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(130, 211);
            button2.Name = "button2";
            button2.Size = new Size(263, 86);
            button2.TabIndex = 1;
            button2.Text = "Review An Employee Information";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(130, 325);
            button3.Name = "button3";
            button3.Size = new Size(263, 84);
            button3.TabIndex = 2;
            button3.Text = "Kit Sumbmission";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // EmployeeMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 563);
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
    }
}