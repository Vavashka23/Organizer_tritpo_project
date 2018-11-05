namespace Organizer
{
    partial class StartWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            this.loginButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.forgotPasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(385, 188);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(250, 60);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registrationButton.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Location = new System.Drawing.Point(385, 286);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(2);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(250, 60);
            this.registrationButton.TabIndex = 1;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            // 
            // forgotPasswordButton
            // 
            this.forgotPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forgotPasswordButton.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forgotPasswordButton.Location = new System.Drawing.Point(385, 391);
            this.forgotPasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.forgotPasswordButton.Name = "forgotPasswordButton";
            this.forgotPasswordButton.Size = new System.Drawing.Size(250, 60);
            this.forgotPasswordButton.TabIndex = 2;
            this.forgotPasswordButton.Text = "Не помню пароль";
            this.forgotPasswordButton.UseVisualStyleBackColor = true;
            // 
            // StartWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1012, 681);
            this.Controls.Add(this.forgotPasswordButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartWindow";
            this.Text = "Organizer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginWindow_FormClose);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button forgotPasswordButton;
    }
}

