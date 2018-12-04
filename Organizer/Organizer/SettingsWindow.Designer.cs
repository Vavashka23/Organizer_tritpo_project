using System;

namespace Organizer
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.UploadFotoButton = new System.Windows.Forms.Button();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateChangeButton = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.thisDateLabel = new System.Windows.Forms.Label();
            this.thisNameLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // avatarBox
            // 
            this.avatarBox.Location = new System.Drawing.Point(504, 42);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(160, 153);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox.TabIndex = 10;
            this.avatarBox.TabStop = false;
            this.avatarBox.VisibleChanged += new System.EventHandler(this.avatarBox_VisibleChanged);
            // 
            // UploadFotoButton
            // 
            this.UploadFotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UploadFotoButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UploadFotoButton.Location = new System.Drawing.Point(708, 69);
            this.UploadFotoButton.Name = "UploadFotoButton";
            this.UploadFotoButton.Size = new System.Drawing.Size(218, 50);
            this.UploadFotoButton.TabIndex = 11;
            this.UploadFotoButton.Text = "Загрузить фото";
            this.UploadFotoButton.UseVisualStyleBackColor = true;
            this.UploadFotoButton.Click += new System.EventHandler(this.UploadFotoButton_Click);
            // 
            // newNameLabel
            // 
            this.newNameLabel.AutoSize = true;
            this.newNameLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newNameLabel.Location = new System.Drawing.Point(76, 42);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(175, 33);
            this.newNameLabel.TabIndex = 13;
            this.newNameLabel.Text = "Изменить имя:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(82, 78);
            this.nameTextBox.MaxLength = 30;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(207, 41);
            this.nameTextBox.TabIndex = 14;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Enabled = false;
            this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveChangesButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChangesButton.Location = new System.Drawing.Point(82, 242);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(260, 50);
            this.saveChangesButton.TabIndex = 15;
            this.saveChangesButton.Text = "Сохранить изменения";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 181);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 41);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Value = new System.DateTime(2018, 11, 18, 13, 25, 39, 310);
            // 
            // dateChangeButton
            // 
            this.dateChangeButton.AutoSize = true;
            this.dateChangeButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateChangeButton.Location = new System.Drawing.Point(76, 145);
            this.dateChangeButton.Name = "dateChangeButton";
            this.dateChangeButton.Size = new System.Drawing.Size(288, 33);
            this.dateChangeButton.TabIndex = 17;
            this.dateChangeButton.Text = "Изменить дату рождения:";
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Location = new System.Drawing.Point(813, 145);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(113, 50);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // thisDateLabel
            // 
            this.thisDateLabel.AutoSize = true;
            this.thisDateLabel.Location = new System.Drawing.Point(498, 251);
            this.thisDateLabel.Name = "thisDateLabel";
            this.thisDateLabel.Size = new System.Drawing.Size(265, 33);
            this.thisDateLabel.TabIndex = 20;
            this.thisDateLabel.Text = "Текущая дата рождения:";
            // 
            // thisNameLabel
            // 
            this.thisNameLabel.AutoSize = true;
            this.thisNameLabel.Location = new System.Drawing.Point(498, 312);
            this.thisNameLabel.Name = "thisNameLabel";
            this.thisNameLabel.Size = new System.Drawing.Size(151, 33);
            this.thisNameLabel.TabIndex = 21;
            this.thisNameLabel.Text = "Текущее имя:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(400, 617);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 33);
            this.errorLabel.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Изменение пароля:";
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(85, 547);
            this.newPassword.MaxLength = 15;
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(207, 41);
            this.newPassword.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 33);
            this.label2.TabIndex = 25;
            this.label2.Text = "Введите старый пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 33);
            this.label3.TabIndex = 26;
            this.label3.Text = "Введите новый пароль:";
            // 
            // oldPassword
            // 
            this.oldPassword.Location = new System.Drawing.Point(82, 456);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(207, 41);
            this.oldPassword.TabIndex = 27;
            // 
            // okButton
            // 
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okButton.Location = new System.Drawing.Point(85, 613);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(166, 41);
            this.okButton.TabIndex = 28;
            this.okButton.Text = "Изменить";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1012, 681);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.thisNameLabel);
            this.Controls.Add(this.thisDateLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dateChangeButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.newNameLabel);
            this.Controls.Add(this.UploadFotoButton);
            this.Controls.Add(this.avatarBox);
            this.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsWindow_FormClosed);
            this.Shown += new System.EventHandler(this.SettingsWindow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.Button UploadFotoButton;
        private System.Windows.Forms.Label newNameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dateChangeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label thisDateLabel;
        private System.Windows.Forms.Label thisNameLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldPassword;
        private System.Windows.Forms.Button okButton;
    }
}