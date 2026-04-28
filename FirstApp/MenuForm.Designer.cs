namespace FirstApp
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.logOpenButton = new System.Windows.Forms.Button();
            this.regTableOpenButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(184, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тут був Вася,";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logOpenButton
            // 
            this.logOpenButton.BackColor = System.Drawing.Color.Ivory;
            this.logOpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOpenButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOpenButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.logOpenButton.Location = new System.Drawing.Point(12, 109);
            this.logOpenButton.Name = "logOpenButton";
            this.logOpenButton.Size = new System.Drawing.Size(294, 62);
            this.logOpenButton.TabIndex = 2;
            this.logOpenButton.Text = "Відкрити лог останніх відвідувачів";
            this.logOpenButton.UseVisualStyleBackColor = false;
            this.logOpenButton.Click += new System.EventHandler(this.logOpenButton_Click);
            // 
            // regTableOpenButton
            // 
            this.regTableOpenButton.BackColor = System.Drawing.Color.Ivory;
            this.regTableOpenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regTableOpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regTableOpenButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regTableOpenButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.regTableOpenButton.Location = new System.Drawing.Point(12, 177);
            this.regTableOpenButton.Name = "regTableOpenButton";
            this.regTableOpenButton.Size = new System.Drawing.Size(294, 62);
            this.regTableOpenButton.TabIndex = 3;
            this.regTableOpenButton.Text = "Відкрити форму з таблицею зареєстрованих";
            this.regTableOpenButton.UseVisualStyleBackColor = false;
            this.regTableOpenButton.Click += new System.EventHandler(this.regTableOpenButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Ivory;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exitButton.Location = new System.Drawing.Point(99, 344);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 45);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Вихід";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "...і login.";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Ivory;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.backButton.Location = new System.Drawing.Point(99, 281);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 45);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(318, 415);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.regTableOpenButton);
            this.Controls.Add(this.logOpenButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOpenButton;
        private System.Windows.Forms.Button regTableOpenButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
    }
}