namespace ZooPark.cmAnimalsInspectionsForms
{
    partial class AddAnimalsInspectionsForm
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
            this.countLb = new System.Windows.Forms.Label();
            this.btAddInspection = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.EmployeeLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateInspectionLb = new System.Windows.Forms.Label();
            this.AnimalLb = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.InspectionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.tbEmployee = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // countLb
            // 
            this.countLb.AutoSize = true;
            this.countLb.Location = new System.Drawing.Point(363, 143);
            this.countLb.Name = "countLb";
            this.countLb.Size = new System.Drawing.Size(0, 13);
            this.countLb.TabIndex = 23;
            // 
            // btAddInspection
            // 
            this.btAddInspection.Location = new System.Drawing.Point(12, 264);
            this.btAddInspection.Name = "btAddInspection";
            this.btAddInspection.Size = new System.Drawing.Size(183, 40);
            this.btAddInspection.TabIndex = 22;
            this.btAddInspection.Text = "Добавить";
            this.btAddInspection.UseVisualStyleBackColor = true;
            this.btAddInspection.Click += new System.EventHandler(this.btAddInspection_Click);
            // 
            // btCancel
            // 
            this.btCancel.CausesValidation = false;
            this.btCancel.Location = new System.Drawing.Point(219, 264);
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
            this.EmployeeLb.Location = new System.Drawing.Point(239, 21);
            this.EmployeeLb.Name = "EmployeeLb";
            this.EmployeeLb.Size = new System.Drawing.Size(172, 13);
            this.EmployeeLb.TabIndex = 20;
            this.EmployeeLb.Text = "Проводивший осмотр сотрудник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Комментарий";
            // 
            // DateInspectionLb
            // 
            this.DateInspectionLb.AutoSize = true;
            this.DateInspectionLb.Location = new System.Drawing.Point(239, 106);
            this.DateInspectionLb.Name = "DateInspectionLb";
            this.DateInspectionLb.Size = new System.Drawing.Size(79, 13);
            this.DateInspectionLb.TabIndex = 18;
            this.DateInspectionLb.Text = "Дата осмотра";
            // 
            // AnimalLb
            // 
            this.AnimalLb.AutoSize = true;
            this.AnimalLb.Location = new System.Drawing.Point(239, 63);
            this.AnimalLb.Name = "AnimalLb";
            this.AnimalLb.Size = new System.Drawing.Size(59, 13);
            this.AnimalLb.TabIndex = 17;
            this.AnimalLb.Text = "Животное";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(12, 159);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(399, 94);
            this.tbComment.TabIndex = 16;
            this.tbComment.TextChanged += new System.EventHandler(this.tbComment_TextChanged);
            this.tbComment.Validating += new System.ComponentModel.CancelEventHandler(this.tbComment_Validating);
            this.tbComment.Validated += new System.EventHandler(this.tbComment_Validated);
            // 
            // InspectionDatePicker
            // 
            this.InspectionDatePicker.Location = new System.Drawing.Point(12, 103);
            this.InspectionDatePicker.Name = "InspectionDatePicker";
            this.InspectionDatePicker.Size = new System.Drawing.Size(200, 20);
            this.InspectionDatePicker.TabIndex = 15;
            // 
            // cbAnimal
            // 
            this.cbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(12, 60);
            this.cbAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(200, 21);
            this.cbAnimal.TabIndex = 13;
            this.cbAnimal.SelectedValueChanged += new System.EventHandler(this.cbAnimal_SelectionChangeCommitted);
            // 
            // tbEmployee
            // 
            this.tbEmployee.Enabled = false;
            this.tbEmployee.Location = new System.Drawing.Point(12, 18);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.Size = new System.Drawing.Size(200, 20);
            this.tbEmployee.TabIndex = 24;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddAnimalsInspectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 328);
            this.Controls.Add(this.tbEmployee);
            this.Controls.Add(this.countLb);
            this.Controls.Add(this.btAddInspection);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.EmployeeLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateInspectionLb);
            this.Controls.Add(this.AnimalLb);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.InspectionDatePicker);
            this.Controls.Add(this.cbAnimal);
            this.Name = "AddAnimalsInspectionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAnimalsInspectionsForm";
            this.Load += new System.EventHandler(this.AddAnimalsInspectionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countLb;
        private System.Windows.Forms.Button btAddInspection;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label EmployeeLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DateInspectionLb;
        private System.Windows.Forms.Label AnimalLb;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.DateTimePicker InspectionDatePicker;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.TextBox tbEmployee;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}