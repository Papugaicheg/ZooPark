namespace ZooPark.cmEmployeeForms
{
    partial class UpdateEmployeeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmployeeForm));
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMiddlename = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MiddlenameLabel = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.SexLabel = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.tbExp = new System.Windows.Forms.TextBox();
            this.ExpLabel = new System.Windows.Forms.Label();
            this.cbPost = new System.Windows.Forms.ComboBox();
            this.PostLabel = new System.Windows.Forms.Label();
            this.AcceptDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DismissDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AcceptDateLabel = new System.Windows.Forms.Label();
            this.DismissDateLabel = new System.Windows.Forms.Label();
            this.cbDismiss = new System.Windows.Forms.CheckBox();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.PassportLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(22, 22);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(204, 20);
            this.tbSurname.TabIndex = 0;
            this.tbSurname.Validating += new System.ComponentModel.CancelEventHandler(this.tbSurname_Validating);
            this.tbSurname.Validated += new System.EventHandler(this.tbSurname_Validated);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(22, 48);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(204, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // tbMiddlename
            // 
            this.tbMiddlename.Location = new System.Drawing.Point(22, 74);
            this.tbMiddlename.Name = "tbMiddlename";
            this.tbMiddlename.Size = new System.Drawing.Size(204, 20);
            this.tbMiddlename.TabIndex = 2;
            this.tbMiddlename.Validating += new System.ComponentModel.CancelEventHandler(this.tbMiddlename_Validating);
            this.tbMiddlename.Validated += new System.EventHandler(this.tbMiddlename_Validated);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(247, 25);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.SurnameLabel.TabIndex = 3;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(247, 51);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Имя";
            // 
            // MiddlenameLabel
            // 
            this.MiddlenameLabel.AutoSize = true;
            this.MiddlenameLabel.Location = new System.Drawing.Point(247, 77);
            this.MiddlenameLabel.Name = "MiddlenameLabel";
            this.MiddlenameLabel.Size = new System.Drawing.Size(54, 13);
            this.MiddlenameLabel.TabIndex = 5;
            this.MiddlenameLabel.Text = "Отчество";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(22, 100);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(71, 17);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Мужской";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(125, 100);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(72, 17);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Женский";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(247, 102);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(27, 13);
            this.SexLabel.TabIndex = 8;
            this.SexLabel.Text = "Пол";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(22, 123);
            this.BirthDatePicker.MaxDate = new System.DateTime(2006, 6, 4, 0, 0, 0, 0);
            this.BirthDatePicker.MinDate = new System.DateTime(1955, 1, 1, 0, 0, 0, 0);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(204, 20);
            this.BirthDatePicker.TabIndex = 9;
            this.BirthDatePicker.Value = new System.DateTime(2006, 6, 4, 0, 0, 0, 0);
            this.BirthDatePicker.ValueChanged += new System.EventHandler(this.BirthDatePicker_ValueChanged);
            this.BirthDatePicker.Validated += new System.EventHandler(this.BirthDatePicker_Validated);
            // 
            // BirthLabel
            // 
            this.BirthLabel.AutoSize = true;
            this.BirthLabel.Location = new System.Drawing.Point(247, 127);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(86, 13);
            this.BirthLabel.TabIndex = 10;
            this.BirthLabel.Text = "Дата рождения";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(247, 152);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.PhoneLabel.TabIndex = 12;
            this.PhoneLabel.Text = "Телефон";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(22, 175);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(428, 20);
            this.tbAdress.TabIndex = 13;
            this.tbAdress.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdress_Validating);
            this.tbAdress.Validated += new System.EventHandler(this.tbAdress_Validated);
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(468, 178);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(38, 13);
            this.AdressLabel.TabIndex = 14;
            this.AdressLabel.Text = "Адрес";
            // 
            // tbExp
            // 
            this.tbExp.Location = new System.Drawing.Point(22, 205);
            this.tbExp.Name = "tbExp";
            this.tbExp.Size = new System.Drawing.Size(100, 20);
            this.tbExp.TabIndex = 15;
            this.tbExp.Validating += new System.ComponentModel.CancelEventHandler(this.tbExp_Validating);
            this.tbExp.Validated += new System.EventHandler(this.tbExp_Validated);
            // 
            // ExpLabel
            // 
            this.ExpLabel.AutoSize = true;
            this.ExpLabel.Location = new System.Drawing.Point(143, 208);
            this.ExpLabel.Name = "ExpLabel";
            this.ExpLabel.Size = new System.Drawing.Size(33, 13);
            this.ExpLabel.TabIndex = 16;
            this.ExpLabel.Text = "Стаж";
            // 
            // cbPost
            // 
            this.cbPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPost.FormattingEnabled = true;
            this.cbPost.Location = new System.Drawing.Point(182, 204);
            this.cbPost.Name = "cbPost";
            this.cbPost.Size = new System.Drawing.Size(268, 21);
            this.cbPost.TabIndex = 17;
            this.cbPost.Validated += new System.EventHandler(this.cbPost_Validated);
            // 
            // PostLabel
            // 
            this.PostLabel.AutoSize = true;
            this.PostLabel.Location = new System.Drawing.Point(468, 207);
            this.PostLabel.Name = "PostLabel";
            this.PostLabel.Size = new System.Drawing.Size(65, 13);
            this.PostLabel.TabIndex = 18;
            this.PostLabel.Text = "Должность";
            // 
            // AcceptDatePicker
            // 
            this.AcceptDatePicker.Location = new System.Drawing.Point(22, 231);
            this.AcceptDatePicker.Name = "AcceptDatePicker";
            this.AcceptDatePicker.Size = new System.Drawing.Size(204, 20);
            this.AcceptDatePicker.TabIndex = 19;
            this.AcceptDatePicker.ValueChanged += new System.EventHandler(this.AcceptDatePicker_ValueChanged);
            this.AcceptDatePicker.Validated += new System.EventHandler(this.AcceptDatePicker_Validated);
            // 
            // DismissDatePicker
            // 
            this.DismissDatePicker.Location = new System.Drawing.Point(22, 257);
            this.DismissDatePicker.Name = "DismissDatePicker";
            this.DismissDatePicker.Size = new System.Drawing.Size(204, 20);
            this.DismissDatePicker.TabIndex = 20;
            this.DismissDatePicker.Validated += new System.EventHandler(this.DismissDatePicker_Validated);
            // 
            // AcceptDateLabel
            // 
            this.AcceptDateLabel.AutoSize = true;
            this.AcceptDateLabel.Location = new System.Drawing.Point(247, 235);
            this.AcceptDateLabel.Name = "AcceptDateLabel";
            this.AcceptDateLabel.Size = new System.Drawing.Size(74, 13);
            this.AcceptDateLabel.TabIndex = 21;
            this.AcceptDateLabel.Text = "Дата приема";
            // 
            // DismissDateLabel
            // 
            this.DismissDateLabel.AutoSize = true;
            this.DismissDateLabel.Location = new System.Drawing.Point(247, 261);
            this.DismissDateLabel.Name = "DismissDateLabel";
            this.DismissDateLabel.Size = new System.Drawing.Size(95, 13);
            this.DismissDateLabel.TabIndex = 22;
            this.DismissDateLabel.Text = "Дата увольнения";
            // 
            // cbDismiss
            // 
            this.cbDismiss.AutoSize = true;
            this.cbDismiss.Location = new System.Drawing.Point(364, 236);
            this.cbDismiss.Name = "cbDismiss";
            this.cbDismiss.Size = new System.Drawing.Size(64, 17);
            this.cbDismiss.TabIndex = 23;
            this.cbDismiss.Text = "Уволен";
            this.cbDismiss.UseVisualStyleBackColor = true;
            this.cbDismiss.CheckedChanged += new System.EventHandler(this.cbDismiss_CheckedChanged);
            // 
            // tbPassport
            // 
            this.tbPassport.Location = new System.Drawing.Point(22, 283);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(204, 20);
            this.tbPassport.TabIndex = 24;
            this.tbPassport.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassport_Validating);
            this.tbPassport.Validated += new System.EventHandler(this.tbPassport_Validated);
            // 
            // PassportLabel
            // 
            this.PassportLabel.AutoSize = true;
            this.PassportLabel.Location = new System.Drawing.Point(247, 286);
            this.PassportLabel.Name = "PassportLabel";
            this.PassportLabel.Size = new System.Drawing.Size(50, 13);
            this.PassportLabel.TabIndex = 25;
            this.PassportLabel.Text = "Паспорт";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(316, 286);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(112, 23);
            this.UpdateButton.TabIndex = 26;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // btCancel
            // 
            this.btCancel.CausesValidation = false;
            this.btCancel.Location = new System.Drawing.Point(434, 286);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 23);
            this.btCancel.TabIndex = 27;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(22, 149);
            this.tbPhone.Mask = "70000000000";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(204, 20);
            this.tbPhone.TabIndex = 28;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            this.tbPhone.Validated += new System.EventHandler(this.tbPhone_Validated);
            // 
            // UpdateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 321);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PassportLabel);
            this.Controls.Add(this.tbPassport);
            this.Controls.Add(this.cbDismiss);
            this.Controls.Add(this.DismissDateLabel);
            this.Controls.Add(this.AcceptDateLabel);
            this.Controls.Add(this.DismissDatePicker);
            this.Controls.Add(this.AcceptDatePicker);
            this.Controls.Add(this.PostLabel);
            this.Controls.Add(this.cbPost);
            this.Controls.Add(this.ExpLabel);
            this.Controls.Add(this.tbExp);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.BirthLabel);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.MiddlenameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.tbMiddlename);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение сотрудника";
            this.Load += new System.EventHandler(this.UpdateEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMiddlename;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MiddlenameLabel;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Label BirthLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.TextBox tbExp;
        private System.Windows.Forms.Label ExpLabel;
        private System.Windows.Forms.ComboBox cbPost;
        private System.Windows.Forms.Label PostLabel;
        private System.Windows.Forms.DateTimePicker AcceptDatePicker;
        private System.Windows.Forms.DateTimePicker DismissDatePicker;
        private System.Windows.Forms.Label AcceptDateLabel;
        private System.Windows.Forms.Label DismissDateLabel;
        private System.Windows.Forms.CheckBox cbDismiss;
        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.Label PassportLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox tbPhone;
    }
}