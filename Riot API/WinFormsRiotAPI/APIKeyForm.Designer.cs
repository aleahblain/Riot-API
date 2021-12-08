namespace WinFormsRiotAPI
{
    partial class APIKeyForm
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
            this.APIKeyLabel = new System.Windows.Forms.Label();
            this.APIKeyTextBox = new System.Windows.Forms.TextBox();
            this.APIKeyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // APIKeyLabel
            // 
            this.APIKeyLabel.AutoSize = true;
            this.APIKeyLabel.Location = new System.Drawing.Point(13, 16);
            this.APIKeyLabel.Name = "APIKeyLabel";
            this.APIKeyLabel.Size = new System.Drawing.Size(103, 13);
            this.APIKeyLabel.TabIndex = 0;
            this.APIKeyLabel.Text = "&Edit Current API Key";
            // 
            // APIKeyTextBox
            // 
            this.APIKeyTextBox.Location = new System.Drawing.Point(16, 39);
            this.APIKeyTextBox.Name = "APIKeyTextBox";
            this.APIKeyTextBox.Size = new System.Drawing.Size(411, 20);
            this.APIKeyTextBox.TabIndex = 1;
            this.APIKeyTextBox.TextChanged += new System.EventHandler(this.APIKeyTextBox_TextChanged);
            // 
            // APIKeyButton
            // 
            this.APIKeyButton.Location = new System.Drawing.Point(137, 74);
            this.APIKeyButton.Name = "APIKeyButton";
            this.APIKeyButton.Size = new System.Drawing.Size(174, 23);
            this.APIKeyButton.TabIndex = 2;
            this.APIKeyButton.Text = ">>";
            this.APIKeyButton.UseVisualStyleBackColor = true;
            this.APIKeyButton.Click += new System.EventHandler(this.APIKeyButton_Click);
            // 
            // APIKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 109);
            this.Controls.Add(this.APIKeyButton);
            this.Controls.Add(this.APIKeyTextBox);
            this.Controls.Add(this.APIKeyLabel);
            this.Name = "APIKeyForm";
            this.Text = "APIKeyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label APIKeyLabel;
        private System.Windows.Forms.TextBox APIKeyTextBox;
        private System.Windows.Forms.Button APIKeyButton;
    }
}