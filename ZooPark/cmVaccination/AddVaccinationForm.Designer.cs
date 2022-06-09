namespace ZooPark.cmVaccination
{
    partial class AddVaccinationForm
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
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btAddVaccination = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.EmployeeLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateInspectionLb = new System.Windows.Forms.Label();
            this.AnimalLb = new System.Windows.Forms.Label();
            this.VaccinationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tbEmployee = new System.Windows.Forms.TextBox();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(15, 147);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(195, 21);
            this.cbType.TabIndex = 35;
            // 
            // btAddVaccination
            // 
            this.btAddVaccination.Location = new System.Drawing.Point(15, 188);
            this.btAddVaccination.Name = "btAddVaccination";
            this.btAddVaccination.Size = new System.Drawing.Size(183, 40);
            this.btAddVaccination.TabIndex = 34;
            this.btAddVaccination.Text = "Добавить";
            this.btAddVaccination.UseVisualStyleBackColor = true;
            this.btAddVaccination.Click += new System.EventHandler(this.btAddVaccination_Click);
            // 
            // btCancel
            // 
            this.btCancel.CausesValidation = false;
            this.btCancel.Location = new System.Drawing.Point(219, 188);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(192, 40);
            this.btCancel.TabIndex = 33;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // EmployeeLb
            // 
            this.EmployeeLb.AutoSize = true;
            this.EmployeeLb.Location = new System.Drawing.Point(239, 17);
            this.EmployeeLb.Name = "EmployeeLb";
            this.EmployeeLb.Size = new System.Drawing.Size(172, 13);
            this.EmployeeLb.TabIndex = 32;
            this.EmployeeLb.Text = "Сотрудник, сделавший прививку";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Прививка";
            // 
            // DateInspectionLb
            // 
            this.DateInspectionLb.AutoSize = true;
            this.DateInspectionLb.Location = new System.Drawing.Point(239, 109);
            this.DateInspectionLb.Name = "DateInspectionLb";
            this.DateInspectionLb.Size = new System.Drawing.Size(84, 13);
            this.DateInspectionLb.TabIndex = 30;
            this.DateInspectionLb.Text = "Дата прививки";
            // 
            // AnimalLb
            // 
            this.AnimalLb.AutoSize = true;
            this.AnimalLb.Location = new System.Drawing.Point(239, 61);
            this.AnimalLb.Name = "AnimalLb";
            this.AnimalLb.Size = new System.Drawing.Size(59, 13);
            this.AnimalLb.TabIndex = 29;
            this.AnimalLb.Text = "Животное";
            // 
            // VaccinationDatePicker
            // 
            this.VaccinationDatePicker.Location = new System.Drawing.Point(15, 103);
            this.VaccinationDatePicker.Name = "VaccinationDatePicker";
            this.VaccinationDatePicker.Size = new System.Drawing.Size(195, 20);
            this.VaccinationDatePicker.TabIndex = 28;
            // 
            // tbEmployee
            // 
            this.tbEmployee.Enabled = false;
            this.tbEmployee.Location = new System.Drawing.Point(13, 14);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.Size = new System.Drawing.Size(197, 20);
            this.tbEmployee.TabIndex = 27;
            // 
            // cbAnimal
            // 
            this.cbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(13, 58);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(197, 21);
            this.cbAnimal.TabIndex = 36;
            this.cbAnimal.SelectedValueChanged += new System.EventHandler(this.cbAnimal_SelectedValueChanged);
            // 
            // AddVaccinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 239);
            this.Controls.Add(this.cbAnimal);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btAddVaccination);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.EmployeeLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateInspectionLb);
            this.Controls.Add(this.AnimalLb);
            this.Controls.Add(this.VaccinationDatePicker);
            this.Controls.Add(this.tbEmployee);
            this.Name = "AddVaccinationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddVaccinationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btAddVaccination;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label EmployeeLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DateInspectionLb;
        private System.Windows.Forms.Label AnimalLb;
        private System.Windows.Forms.DateTimePicker VaccinationDatePicker;
        private System.Windows.Forms.TextBox tbEmployee;
        private System.Windows.Forms.ComboBox cbAnimal;
    }
}