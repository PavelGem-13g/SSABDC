namespace SSABDC
{
    partial class Login
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
            this.loginLable = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLable = new System.Windows.Forms.Label();
            this.loginButtonForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLable
            // 
            this.loginLable.AutoSize = true;
            this.loginLable.Location = new System.Drawing.Point(12, 9);
            this.loginLable.Name = "loginLable";
            this.loginLable.Size = new System.Drawing.Size(37, 15);
            this.loginLable.TabIndex = 0;
            this.loginLable.Text = "Login";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(12, 27);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(183, 23);
            this.loginTextBox.TabIndex = 1;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 71);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(183, 23);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // passwordLable
            // 
            this.passwordLable.AutoSize = true;
            this.passwordLable.Location = new System.Drawing.Point(12, 53);
            this.passwordLable.Name = "passwordLable";
            this.passwordLable.Size = new System.Drawing.Size(57, 15);
            this.passwordLable.TabIndex = 2;
            this.passwordLable.Text = "Password";
            // 
            // loginButtonForm
            // 
            this.loginButtonForm.Location = new System.Drawing.Point(12, 102);
            this.loginButtonForm.Name = "loginButtonForm";
            this.loginButtonForm.Size = new System.Drawing.Size(75, 23);
            this.loginButtonForm.TabIndex = 4;
            this.loginButtonForm.Text = "Log in";
            this.loginButtonForm.UseVisualStyleBackColor = true;
            this.loginButtonForm.Click += new System.EventHandler(this.loginButtonForm_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 137);
            this.Controls.Add(this.loginButtonForm);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLable);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLable);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label loginLable;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Label passwordLable;
        private Button loginButtonForm;
    }
}