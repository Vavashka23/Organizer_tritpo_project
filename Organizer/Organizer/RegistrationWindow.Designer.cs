namespace Organizer
{
    partial class RegistrationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginEnterBox = new System.Windows.Forms.TextBox();
            this.passwordEnterBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.secretEnterBox = new System.Windows.Forms.TextBox();
            this.answerEnterBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(165, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(165, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите пароль:";
            // 
            // loginEnterBox
            // 
            this.loginEnterBox.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginEnterBox.Location = new System.Drawing.Point(168, 167);
            this.loginEnterBox.MaxLength = 14;
            this.loginEnterBox.Name = "loginEnterBox";
            this.loginEnterBox.Size = new System.Drawing.Size(268, 41);
            this.loginEnterBox.TabIndex = 2;
            // 
            // passwordEnterBox
            // 
            this.passwordEnterBox.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordEnterBox.Location = new System.Drawing.Point(168, 281);
            this.passwordEnterBox.MaxLength = 14;
            this.passwordEnterBox.Name = "passwordEnterBox";
            this.passwordEnterBox.PasswordChar = '#';
            this.passwordEnterBox.Size = new System.Drawing.Size(268, 41);
            this.passwordEnterBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(556, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите секретный вопрос:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(556, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите ответ на ваш вопрос:";
            // 
            // secretEnterBox
            // 
            this.secretEnterBox.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secretEnterBox.Location = new System.Drawing.Point(562, 167);
            this.secretEnterBox.Name = "secretEnterBox";
            this.secretEnterBox.Size = new System.Drawing.Size(338, 41);
            this.secretEnterBox.TabIndex = 6;
            // 
            // answerEnterBox
            // 
            this.answerEnterBox.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerEnterBox.Location = new System.Drawing.Point(562, 281);
            this.answerEnterBox.Name = "answerEnterBox";
            this.answerEnterBox.Size = new System.Drawing.Size(338, 41);
            this.answerEnterBox.TabIndex = 7;
            // 
            // okButton
            // 
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(408, 396);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(58, 50);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(499, 396);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(90, 50);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // RegistrationWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1012, 681);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.answerEnterBox);
            this.Controls.Add(this.secretEnterBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordEnterBox);
            this.Controls.Add(this.loginEnterBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationWindow";
            this.Text = "Organizer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginEnterBox;
        private System.Windows.Forms.TextBox passwordEnterBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox secretEnterBox;
        private System.Windows.Forms.TextBox answerEnterBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button backButton;
    }
}