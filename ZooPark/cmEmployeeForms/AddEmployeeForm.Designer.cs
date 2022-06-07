namespace ZooPark.cmEmployeeForms
{
    partial class AddEmployeeForm
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
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.PassportLabel = new System.Windows.Forms.Label();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.cbDismiss = new System.Windows.Forms.CheckBox();
            this.DismissDateLabel = new System.Windows.Forms.Label();
            this.AcceptDateLabel = new System.Windows.Forms.Label();
            this.DismissDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AcceptDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PostLabel = new System.Windows.Forms.Label();
            this.cbPost = new System.Windows.Forms.ComboBox();
            this.ExpLabel = new System.Windows.Forms.Label();
            this.tbExp = new System.Windows.Forms.TextBox();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SexLabel = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.MiddlenameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.tbMiddlename = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(12, 139);
            this.tbPhone.Mask = "70000000000";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(204, 20);
            this.tbPhone.TabIndex = 56;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            this.tbPhone.Validated += new System.EventHandler(this.tbPhone_Validated);
            // 
            // btCancel
            // 
            this.btCancel.CausesValidation = false;
            this.btCancel.Location = new System.Drawing.Point(424, 276);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 23);
            this.btCancel.TabIndex = 55;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(306, 276);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(112, 23);
            this.AddButton.TabIndex = 54;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PassportLabel
            // 
            this.PassportLabel.AutoSize = true;
            this.PassportLabel.Location = new System.Drawing.Point(237, 276);
            this.PassportLabel.Name = "PassportLabel";
            this.PassportLabel.Size = new System.Drawing.Size(50, 13);
            this.PassportLabel.TabIndex = 53;
            this.PassportLabel.Text = "Паспорт";
            // 
            // tbPassport
            // 
            this.tbPassport.Location = new System.Drawing.Point(12, 273);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(204, 20);
            this.tbPassport.TabIndex = 52;
            this.tbPassport.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassport_Validating);
            this.tbPassport.Validated += new System.EventHandler(this.tbPassport_Validated);
            // 
            // cbDismiss
            // 
            this.cbDismiss.AutoSize = true;
            this.cbDismiss.Location = new System.Drawing.Point(354, 226);
            this.cbDismiss.Name = "cbDismiss";
            this.cbDismiss.Size = new System.Drawing.Size(64, 17);
            this.cbDismiss.TabIndex = 51;
            this.cbDismiss.Text = "Уволен";
            this.cbDismiss.UseVisualStyleBackColor = true;
            this.cbDismiss.CheckedChanged += new System.EventHandler(this.cbDismiss_CheckedChanged);
            // 
            // DismissDateLabel
            // 
            this.DismissDateLabel.AutoSize = true;
            this.DismissDateLabel.Location = new System.Drawing.Point(237, 251);
            this.DismissDateLabel.Name = "DismissDateLabel";
            this.DismissDateLabel.Size = new System.Drawing.Size(95, 13);
            this.DismissDateLabel.TabIndex = 50;
            this.DismissDateLabel.Text = "Дата увольнения";
            // 
            // AcceptDateLabel
            // 
            this.AcceptDateLabel.AutoSize = true;
            this.AcceptDateLabel.Location = new System.Drawing.Point(237, 225);
            this.AcceptDateLabel.Name = "AcceptDateLabel";
            this.AcceptDateLabel.Size = new System.Drawing.Size(74, 13);
            this.AcceptDateLabel.TabIndex = 49;
            this.AcceptDateLabel.Text = "Дата приема";
            // 
            // DismissDatePicker
            // 
            this.DismissDatePicker.Location = new System.Drawing.Point(12, 247);
            this.DismissDatePicker.Name = "DismissDatePicker";
            this.DismissDatePicker.Size = new System.Drawing.Size(204, 20);
            this.DismissDatePicker.TabIndex = 48;
            this.DismissDatePicker.Validated += new System.EventHandler(this.DismissDatePicker_Validated);
            // 
            // AcceptDatePicker
            // 
            this.AcceptDatePicker.Location = new System.Drawing.Point(12, 221);
            this.AcceptDatePicker.Name = "AcceptDatePicker";
            this.AcceptDatePicker.Size = new System.Drawing.Size(204, 20);
            this.AcceptDatePicker.TabIndex = 47;
            this.AcceptDatePicker.ValueChanged += new System.EventHandler(this.AcceptDatePicker_ValueChanged);
            this.AcceptDatePicker.Validated += new System.EventHandler(this.AcceptDatePicker_Validated);
            // 
            // PostLabel
            // 
            this.PostLabel.AutoSize = true;
            this.PostLabel.Location = new System.Drawing.Point(458, 197);
            this.PostLabel.Name = "PostLabel";
            this.PostLabel.Size = new System.Drawing.Size(65, 13);
            this.PostLabel.TabIndex = 46;
            this.PostLabel.Text = "Должность";
            // 
            // cbPost
            // 
            this.cbPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPost.FormattingEnabled = true;
            this.cbPost.Location = new System.Drawing.Point(172, 194);
            this.cbPost.Name = "cbPost";
            this.cbPost.Size = new System.Drawing.Size(268, 21);
            this.cbPost.TabIndex = 45;
            this.cbPost.Validated += new System.EventHandler(this.cbPost_Validated);
            // 
            // ExpLabel
            // 
            this.ExpLabel.AutoSize = true;
            this.ExpLabel.Location = new System.Drawing.Point(133, 198);
            this.ExpLabel.Name = "ExpLabel";
            this.ExpLabel.Size = new System.Drawing.Size(33, 13);
            this.ExpLabel.TabIndex = 44;
            this.ExpLabel.Text = "Стаж";
            // 
            // tbExp
            // 
            this.tbExp.Location = new System.Drawing.Point(12, 195);
            this.tbExp.Name = "tbExp";
            this.tbExp.Size = new System.Drawing.Size(100, 20);
            this.tbExp.TabIndex = 43;
            this.tbExp.Validating += new System.ComponentModel.CancelEventHandler(this.tbExp_Validating);
            this.tbExp.Validated += new System.EventHandler(this.tbExp_Validated);
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(458, 168);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(38, 13);
            this.AdressLabel.TabIndex = 42;
            this.AdressLabel.Text = "Адрес";
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(12, 165);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(428, 20);
            this.tbAdress.TabIndex = 41;
            this.tbAdress.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdress_Validating);
            this.tbAdress.Validated += new System.EventHandler(this.tbAdress_Validated);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(237, 142);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.PhoneLabel.TabIndex = 40;
            this.PhoneLabel.Text = "Телефон";
            // 
            // BirthLabel
            // 
            this.BirthLabel.AutoSize = true;
            this.BirthLabel.Location = new System.Drawing.Point(237, 117);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(86, 13);
            this.BirthLabel.TabIndex = 39;
            this.BirthLabel.Text = "Дата рождения";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(12, 113);
            this.BirthDatePicker.MinDate = new System.DateTime(1955, 1, 1, 0, 0, 0, 0);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(204, 20);
            this.BirthDatePicker.TabIndex = 38;
            this.BirthDatePicker.ValueChanged += new System.EventHandler(this.BirthDatePicker_ValueChanged);
            this.BirthDatePicker.Validated += new System.EventHandler(this.BirthDatePicker_Validated);
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(237, 92);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(27, 13);
            this.SexLabel.TabIndex = 37;
            this.SexLabel.Text = "Пол";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(115, 90);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(72, 17);
            this.rbFemale.TabIndex = 36;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Женский";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(12, 90);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(71, 17);
            this.rbMale.TabIndex = 35;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Мужской";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // MiddlenameLabel
            // 
            this.MiddlenameLabel.AutoSize = true;
            this.MiddlenameLabel.Location = new System.Drawing.Point(237, 67);
            this.MiddlenameLabel.Name = "MiddlenameLabel";
            this.MiddlenameLabel.Size = new System.Drawing.Size(54, 13);
            this.MiddlenameLabel.TabIndex = 34;
            this.MiddlenameLabel.Text = "Отчество";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(237, 41);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 33;
            this.NameLabel.Text = "Имя";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(237, 15);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.SurnameLabel.TabIndex = 32;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // tbMiddlename
            // 
            this.tbMiddlename.Location = new System.Drawing.Point(12, 64);
            this.tbMiddlename.Name = "tbMiddlename";
            this.tbMiddlename.Size = new System.Drawing.Size(204, 20);
            this.tbMiddlename.TabIndex = 31;
            this.tbMiddlename.Validating += new System.ComponentModel.CancelEventHandler(this.tbMiddlename_Validating);
            this.tbMiddlename.Validated += new System.EventHandler(this.tbMiddlename_Validated);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(204, 20);
            this.tbName.TabIndex = 30;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(12, 12);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(204, 20);
            this.tbSurname.TabIndex = 29;
            this.tbSurname.Validating += new System.ComponentModel.CancelEventHandler(this.tbSurname_Validating);
            this.tbSurname.Validated += new System.EventHandler(this.tbSurname_Validated);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 321);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.AddButton);
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
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbPhone;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label PassportLabel;
        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.CheckBox cbDismiss;
        private System.Windows.Forms.Label DismissDateLabel;
        private System.Windows.Forms.Label AcceptDateLabel;
        private System.Windows.Forms.DateTimePicker DismissDatePicker;
        private System.Windows.Forms.DateTimePicker AcceptDatePicker;
        private System.Windows.Forms.Label PostLabel;
        private System.Windows.Forms.ComboBox cbPost;
        private System.Windows.Forms.Label ExpLabel;
        private System.Windows.Forms.TextBox tbExp;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label BirthLabel;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label MiddlenameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox tbMiddlename;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}