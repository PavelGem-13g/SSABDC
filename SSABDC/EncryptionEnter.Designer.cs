namespace SSABDC
{
    partial class EncryptionEnter
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.encryptionLableForm = new System.Windows.Forms.Label();
            this.encryptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 23);
            this.textBox1.TabIndex = 0;
            // 
            // encryptionLableForm
            // 
            this.encryptionLableForm.AutoSize = true;
            this.encryptionLableForm.Location = new System.Drawing.Point(12, 9);
            this.encryptionLableForm.Name = "encryptionLableForm";
            this.encryptionLableForm.Size = new System.Drawing.Size(64, 15);
            this.encryptionLableForm.TabIndex = 1;
            this.encryptionLableForm.Text = "Encryption";
            // 
            // encryptionButton
            // 
            this.encryptionButton.Location = new System.Drawing.Point(12, 56);
            this.encryptionButton.Name = "encryptionButton";
            this.encryptionButton.Size = new System.Drawing.Size(75, 23);
            this.encryptionButton.TabIndex = 2;
            this.encryptionButton.Text = "Add code";
            this.encryptionButton.UseVisualStyleBackColor = true;
            this.encryptionButton.Click += new System.EventHandler(this.encryptionButton_Click);
            // 
            // EncryptionEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 89);
            this.Controls.Add(this.encryptionButton);
            this.Controls.Add(this.encryptionLableForm);
            this.Controls.Add(this.textBox1);
            this.Name = "EncryptionEnter";
            this.Text = "EncryptionEnter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label encryptionLableForm;
        private Button encryptionButton;
    }
}