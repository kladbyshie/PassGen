namespace PassGen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameField = new System.Windows.Forms.TextBox();
            this.seedField = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.seedLabel = new System.Windows.Forms.Label();
            this.passField = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.charField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(42, 47);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(171, 27);
            this.nameField.TabIndex = 0;
            this.nameField.TextChanged += new System.EventHandler(this.nameField_TextChanged);
            // 
            // seedField
            // 
            this.seedField.Location = new System.Drawing.Point(219, 47);
            this.seedField.Name = "seedField";
            this.seedField.Size = new System.Drawing.Size(102, 27);
            this.seedField.TabIndex = 1;
            this.seedField.TextChanged += new System.EventHandler(this.seedField_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(42, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(219, 24);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(42, 20);
            this.seedLabel.TabIndex = 1;
            this.seedLabel.Text = "Seed";
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(42, 115);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(373, 27);
            this.passField.TabIndex = 4;
            this.passField.TextChanged += new System.EventHandler(this.passField_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(42, 92);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 20);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(442, 47);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(94, 95);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate!";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // charField
            // 
            this.charField.Location = new System.Drawing.Point(327, 47);
            this.charField.Name = "charField";
            this.charField.Size = new System.Drawing.Size(88, 27);
            this.charField.TabIndex = 2;
            this.charField.TextChanged += new System.EventHandler(this.charField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "# of Chars";
            // 
            // Form1
            // 
            this.AcceptButton = this.generateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charField);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.seedField);
            this.Controls.Add(this.nameField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PassGen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox seedField;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox charField;
        private System.Windows.Forms.Label label1;
    }
}

