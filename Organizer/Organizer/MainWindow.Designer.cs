using System;

namespace Organizer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.showNoteButton = new System.Windows.Forms.Button();
            this.deleteNoteButton = new System.Windows.Forms.Button();
            this.searchNotesButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.listOfNotes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aboutButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.noteGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.noteName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.notificationComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.noteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNoteButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNoteButton.Location = new System.Drawing.Point(22, 33);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(226, 50);
            this.AddNoteButton.TabIndex = 0;
            this.AddNoteButton.Text = "Добавить заметку";
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // showNoteButton
            // 
            this.showNoteButton.Enabled = false;
            this.showNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showNoteButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showNoteButton.Location = new System.Drawing.Point(492, 33);
            this.showNoteButton.Name = "showNoteButton";
            this.showNoteButton.Size = new System.Drawing.Size(136, 50);
            this.showNoteButton.TabIndex = 2;
            this.showNoteButton.Text = "Просмотр";
            this.showNoteButton.UseVisualStyleBackColor = true;
            this.showNoteButton.Click += new System.EventHandler(this.showNoteButton_Click);
            // 
            // deleteNoteButton
            // 
            this.deleteNoteButton.Enabled = false;
            this.deleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteNoteButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteNoteButton.Location = new System.Drawing.Point(264, 33);
            this.deleteNoteButton.Name = "deleteNoteButton";
            this.deleteNoteButton.Size = new System.Drawing.Size(211, 50);
            this.deleteNoteButton.TabIndex = 1;
            this.deleteNoteButton.Text = "Удалить заметку";
            this.deleteNoteButton.UseVisualStyleBackColor = true;
            this.deleteNoteButton.Click += new System.EventHandler(this.deleteNoteButton_Click);
            // 
            // searchNotesButton
            // 
            this.searchNotesButton.Enabled = false;
            this.searchNotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchNotesButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchNotesButton.Location = new System.Drawing.Point(264, 107);
            this.searchNotesButton.Name = "searchNotesButton";
            this.searchNotesButton.Size = new System.Drawing.Size(98, 50);
            this.searchNotesButton.TabIndex = 4;
            this.searchNotesButton.Text = "Поиск";
            this.searchNotesButton.UseVisualStyleBackColor = true;
            this.searchNotesButton.Click += new System.EventHandler(this.searchNotesButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(22, 113);
            this.searchTextBox.MaxLength = 15;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(226, 41);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // listOfNotes
            // 
            this.listOfNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listOfNotes.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfNotes.FormattingEnabled = true;
            this.listOfNotes.ItemHeight = 33;
            this.listOfNotes.Location = new System.Drawing.Point(22, 216);
            this.listOfNotes.Name = "listOfNotes";
            this.listOfNotes.Size = new System.Drawing.Size(390, 431);
            this.listOfNotes.TabIndex = 6;
            this.listOfNotes.SelectedIndexChanged += new System.EventHandler(this.listOfNotes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aboutButton);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.settingsButton);
            this.groupBox1.Controls.Add(this.avatarBox);
            this.groupBox1.Location = new System.Drawing.Point(667, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // aboutButton
            // 
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aboutButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutButton.Location = new System.Drawing.Point(164, 121);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(113, 40);
            this.aboutButton.TabIndex = 7;
            this.aboutButton.Text = "Справка";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(174, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 33);
            this.nameLabel.TabIndex = 8;
            // 
            // settingsButton
            // 
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settingsButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.Location = new System.Drawing.Point(164, 66);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(148, 40);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // avatarBox
            // 
            this.avatarBox.Location = new System.Drawing.Point(18, 21);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(140, 140);
            this.avatarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarBox.TabIndex = 9;
            this.avatarBox.TabStop = false;
            // 
            // noteGroupBox
            // 
            this.noteGroupBox.Controls.Add(this.cancelButton);
            this.noteGroupBox.Controls.Add(this.okButton);
            this.noteGroupBox.Controls.Add(this.label2);
            this.noteGroupBox.Controls.Add(this.noteName);
            this.noteGroupBox.Controls.Add(this.label1);
            this.noteGroupBox.Controls.Add(this.descriptionTextBox);
            this.noteGroupBox.Controls.Add(this.notificationComboBox);
            this.noteGroupBox.Controls.Add(this.dateTimePicker);
            this.noteGroupBox.Location = new System.Drawing.Point(492, 216);
            this.noteGroupBox.Name = "noteGroupBox";
            this.noteGroupBox.Size = new System.Drawing.Size(452, 453);
            this.noteGroupBox.TabIndex = 0;
            this.noteGroupBox.TabStop = false;
            this.noteGroupBox.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(223, 397);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(126, 50);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(116, 396);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(60, 50);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Название события:";
            // 
            // noteName
            // 
            this.noteName.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteName.Location = new System.Drawing.Point(12, 52);
            this.noteName.MaxLength = 30;
            this.noteName.Name = "noteName";
            this.noteName.Size = new System.Drawing.Size(245, 41);
            this.noteName.TabIndex = 14;
            this.noteName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Описание:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 266);
            this.descriptionTextBox.MaxLength = 200;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(434, 124);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // notificationComboBox
            // 
            this.notificationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.notificationComboBox.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationComboBox.FormattingEnabled = true;
            this.notificationComboBox.Items.AddRange(new object[] {
            "Не предупреждать",
            "Предупредить за 1 день",
            "Предупредить в день события"});
            this.notificationComboBox.Location = new System.Drawing.Point(12, 173);
            this.notificationComboBox.Name = "notificationComboBox";
            this.notificationComboBox.Size = new System.Drawing.Size(337, 41);
            this.notificationComboBox.TabIndex = 11;
            this.notificationComboBox.Text = "Оповещение";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(12, 113);
            this.dateTimePicker.MinDate = new System.DateTime(2018, 11, 18, 13, 32, 29, 265);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(337, 41);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.Value = new System.DateTime(2018, 11, 18, 13, 32, 29, 266);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.Location = new System.Drawing.Point(101, 180);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 33);
            this.errorLabel.TabIndex = 7;
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(492, 107);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(136, 50);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1012, 681);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.noteGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listOfNotes);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchNotesButton);
            this.Controls.Add(this.deleteNoteButton);
            this.Controls.Add(this.showNoteButton);
            this.Controls.Add(this.AddNoteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.MainWindow_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.noteGroupBox.ResumeLayout(false);
            this.noteGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Button showNoteButton;
        private System.Windows.Forms.Button deleteNoteButton;
        private System.Windows.Forms.Button searchNotesButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox listOfNotes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.GroupBox noteGroupBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox notificationComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noteName;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button exitButton;
    }
}