namespace SSABDC
{
    partial class AddFile
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
            this.filePathLabel = new System.Windows.Forms.Label();
            this.chooseFilename = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.accessLevel = new System.Windows.Forms.Label();
            this.addFileButtonForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(12, 9);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(49, 15);
            this.filePathLabel.TabIndex = 1;
            this.filePathLabel.Text = "Filepath";
            // 
            // chooseFilename
            // 
            this.chooseFilename.Location = new System.Drawing.Point(395, 27);
            this.chooseFilename.Name = "chooseFilename";
            this.chooseFilename.Size = new System.Drawing.Size(106, 23);
            this.chooseFilename.TabIndex = 2;
            this.chooseFilename.Text = "Choose filename";
            this.chooseFilename.UseVisualStyleBackColor = true;
            this.chooseFilename.Click += new System.EventHandler(this.chooseFilename_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "No"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // accessLevel
            // 
            this.accessLevel.AutoSize = true;
            this.accessLevel.Location = new System.Drawing.Point(12, 62);
            this.accessLevel.Name = "accessLevel";
            this.accessLevel.Size = new System.Drawing.Size(70, 15);
            this.accessLevel.TabIndex = 4;
            this.accessLevel.Text = "Aссess level";
            // 
            // addFileButtonForm
            // 
            this.addFileButtonForm.Location = new System.Drawing.Point(12, 112);
            this.addFileButtonForm.Name = "addFileButtonForm";
            this.addFileButtonForm.Size = new System.Drawing.Size(88, 23);
            this.addFileButtonForm.TabIndex = 5;
            this.addFileButtonForm.Text = "Add file";
            this.addFileButtonForm.UseVisualStyleBackColor = true;
            this.addFileButtonForm.Click += new System.EventHandler(this.addFileButtonForm_Click);
            // 
            // AddFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 155);
            this.Controls.Add(this.addFileButtonForm);
            this.Controls.Add(this.accessLevel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chooseFilename);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "AddFile";
            this.Text = "AddFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label filePathLabel;
        private Button chooseFilename;
        private ComboBox comboBox1;
        private Label accessLevel;
        private Button addFileButtonForm;
    }
}