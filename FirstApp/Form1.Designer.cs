namespace FirstApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginTextLabel = new System.Windows.Forms.Label();
            this.logInbutton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextLabel = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.primeTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTextLabel
            // 
            this.loginTextLabel.AutoSize = true;
            this.loginTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginTextLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.loginTextLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginTextLabel.Location = new System.Drawing.Point(22, 196);
            this.loginTextLabel.Name = "loginTextLabel";
            this.loginTextLabel.Size = new System.Drawing.Size(68, 27);
            this.loginTextLabel.TabIndex = 0;
            this.loginTextLabel.Text = "Login";
            // 
            // logInbutton
            // 
            this.logInbutton.BackColor = System.Drawing.Color.Ivory;
            this.logInbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInbutton.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInbutton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.logInbutton.Location = new System.Drawing.Point(171, 305);
            this.logInbutton.Name = "logInbutton";
            this.logInbutton.Size = new System.Drawing.Size(120, 45);
            this.logInbutton.TabIndex = 1;
            this.logInbutton.Text = "Log In";
            this.logInbutton.UseVisualStyleBackColor = false;
            this.logInbutton.Click += new System.EventHandler(this.logInbutton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(171, 198);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(283, 22);
            this.loginTextBox.TabIndex = 2;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            this.loginTextBox.MouseEnter += new System.EventHandler(this.loginTextBox_MouseEnter);
            this.loginTextBox.MouseLeave += new System.EventHandler(this.loginTextBox_MouseLeave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(171, 250);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(283, 22);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.MouseEnter += new System.EventHandler(this.passwordTextBox_MouseEnter);
            this.passwordTextBox.MouseLeave += new System.EventHandler(this.passwordTextBox_MouseLeave);
            // 
            // passwordTextLabel
            // 
            this.passwordTextLabel.AutoSize = true;
            this.passwordTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.passwordTextLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordTextLabel.Location = new System.Drawing.Point(22, 248);
            this.passwordTextLabel.Name = "passwordTextLabel";
            this.passwordTextLabel.Size = new System.Drawing.Size(108, 27);
            this.passwordTextLabel.TabIndex = 6;
            this.passwordTextLabel.Text = "Password";
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.Ivory;
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.RegButton.Location = new System.Drawing.Point(171, 366);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(120, 45);
            this.RegButton.TabIndex = 7;
            this.RegButton.Text = "Register";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // primeTextLabel
            // 
            this.primeTextLabel.AutoSize = true;
            this.primeTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.primeTextLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.primeTextLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.primeTextLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.primeTextLabel.Location = new System.Drawing.Point(147, 26);
            this.primeTextLabel.Name = "primeTextLabel";
            this.primeTextLabel.Size = new System.Drawing.Size(122, 27);
            this.primeTextLabel.TabIndex = 8;
            this.primeTextLabel.Text = "Prime Text";
            this.primeTextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.primeTextLabel.Click += new System.EventHandler(this.primeTextLabel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 423);
            this.Controls.Add(this.primeTextLabel);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.passwordTextLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.logInbutton);
            this.Controls.Add(this.loginTextLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginTextLabel;
        private System.Windows.Forms.Button logInbutton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordTextLabel;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Label primeTextLabel;
    }
}

