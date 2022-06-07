namespace ZooPark.cmVaccination
{
    partial class UpdateVaccinationForm
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
            this.btUpdateVaccination = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.EmployeeLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateInspectionLb = new System.Windows.Forms.Label();
            this.AnimalLb = new System.Windows.Forms.Label();
            this.VaccinationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tbEmployee = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbAnimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btUpdateVaccination
            // 
            this.btUpdateVaccination.Location = new System.Drawing.Point(19, 195);
            this.btUpdateVaccination.Name = "btUpdateVaccination";
            this.btUpdateVaccination.Size = new System.Drawing.Size(183, 40);
            this.btUpdateVaccination.TabIndex = 22;
            this.btUpdateVaccination.Text = "Изменить";
            this.btUpdateVaccination.UseVisualStyleBackColor = true;
            this.btUpdateVaccination.Click += new System.EventHandler(this.btUpdateVaccination_Click);
            // 
            // btCancel
            // 
            this.btCancel.CausesValidation = false;
            this.btCancel.Location = new System.Drawing.Point(223, 195);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(192, 40);
            this.btCancel.TabIndex = 21;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // EmployeeLb
            // 
            this.EmployeeLb.AutoSize = true;
            this.EmployeeLb.Location = new System.Drawing.Point(243, 24);
            this.EmployeeLb.Name = "EmployeeLb";
            this.EmployeeLb.Size = new System.Drawing.Size(172, 13);
            this.EmployeeLb.TabIndex = 20;
            this.EmployeeLb.Text = "Сотрудник, сделавший прививку";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Тип";
            // 
            // DateInspectionLb
            // 
            this.DateInspectionLb.AutoSize = true;
            this.DateInspectionLb.Location = new System.Drawing.Point(243, 116);
            this.DateInspectionLb.Name = "DateInspectionLb";
            this.DateInspectionLb.Size = new System.Drawing.Size(84, 13);
            this.DateInspectionLb.TabIndex = 18;
            this.DateInspectionLb.Text = "Дата прививки";
            // 
            // AnimalLb
            // 
            this.AnimalLb.AutoSize = true;
            this.AnimalLb.Location = new System.Drawing.Point(243, 68);
            this.AnimalLb.Name = "AnimalLb";
            this.AnimalLb.Size = new System.Drawing.Size(59, 13);
            this.AnimalLb.TabIndex = 17;
            this.AnimalLb.Text = "Животное";
            // 
            // VaccinationDatePicker
            // 
            this.VaccinationDatePicker.Location = new System.Drawing.Point(19, 110);
            this.VaccinationDatePicker.Name = "VaccinationDatePicker";
            this.VaccinationDatePicker.Size = new System.Drawing.Size(195, 20);
            this.VaccinationDatePicker.TabIndex = 15;
            // 
            // tbEmployee
            // 
            this.tbEmployee.Enabled = false;
            this.tbEmployee.Location = new System.Drawing.Point(17, 21);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.Size = new System.Drawing.Size(197, 20);
            this.tbEmployee.TabIndex = 14;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(19, 154);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(195, 21);
            this.cbType.TabIndex = 25;
            // 
            // tbAnimal
            // 
            this.tbAnimal.Enabled = false;
            this.tbAnimal.Location = new System.Drawing.Point(19, 65);
            this.tbAnimal.Name = "tbAnimal";
            this.tbAnimal.Size = new System.Drawing.Size(195, 20);
            this.tbAnimal.TabIndex = 26;
            // 
            // UpdateVaccinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 255);
            this.Controls.Add(this.tbAnimal);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btUpdateVaccination);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.EmployeeLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateInspectionLb);
            this.Controls.Add(this.AnimalLb);
            this.Controls.Add(this.VaccinationDatePicker);
            this.Controls.Add(this.tbEmployee);
            this.Name = "UpdateVaccinationForm";
            this.Text = "UpdateVaccinationForm";
            this.Load += new System.EventHandler(this.UpdateVaccinationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btUpdateVaccination;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label EmployeeLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DateInspectionLb;
        private System.Windows.Forms.Label AnimalLb;
        private System.Windows.Forms.DateTimePicker VaccinationDatePicker;
        private System.Windows.Forms.TextBox tbEmployee;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbAnimal;
    }
}