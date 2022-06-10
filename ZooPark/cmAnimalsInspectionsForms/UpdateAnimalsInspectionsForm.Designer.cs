namespace ZooPark.cmAnimalsInspectionsForms
{
    partial class UpdateAnimalsInspectionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAnimalsInspectionsForm));
            this.tbEmployee = new System.Windows.Forms.TextBox();
            this.InspectionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.AnimalLb = new System.Windows.Forms.Label();
            this.DateInspectionLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeLb = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btUpdateInspection = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.countLb = new System.Windows.Forms.Label();
            this.tbAnimal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmployee
            // 
            this.tbEmployee.Enabled = false;
            this.tbEmployee.Location = new System.Drawing.Point(32, 29);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.Size = new System.Drawing.Size(200, 20);
            this.tbEmployee.TabIndex = 2;
            // 
            // InspectionDatePicker
            // 
            this.InspectionDatePicker.Location = new System.Drawing.Point(32, 114);
            this.InspectionDatePicker.Name = "InspectionDatePicker";
            this.InspectionDatePicker.Size = new System.Drawing.Size(200, 20);
            this.InspectionDatePicker.TabIndex = 3;
            this.InspectionDatePicker.Validated += new System.EventHandler(this.InspectionDatePicker_Validated);
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(32, 170);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(399, 94);
            this.tbComment.TabIndex = 4;
            this.tbComment.TextChanged += new System.EventHandler(this.tbComment_TextChanged);
            this.tbComment.Validating += new System.ComponentModel.CancelEventHandler(this.tbComment_Validating);
            this.tbComment.Validated += new System.EventHandler(this.tbComment_Validated);
            // 
            // AnimalLb
            // 
            this.AnimalLb.AutoSize = true;
            this.AnimalLb.Location = new System.Drawing.Point(259, 74);
            this.AnimalLb.Name = "AnimalLb";
            this.AnimalLb.Size = new System.Drawing.Size(59, 13);
            this.AnimalLb.TabIndex = 5;
            this.AnimalLb.Text = "Животное";
            // 
            // DateInspectionLb
            // 
            this.DateInspectionLb.AutoSize = true;
            this.DateInspectionLb.Location = new System.Drawing.Point(259, 117);
            this.DateInspectionLb.Name = "DateInspectionLb";
            this.DateInspectionLb.Size = new System.Drawing.Size(79, 13);
            this.DateInspectionLb.TabIndex = 6;
            this.DateInspectionLb.Text = "Дата осмотра";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Комментарий";
            // 
            // EmployeeLb
            // 
            this.EmployeeLb.AutoSize = true;
            this.EmployeeLb.Location = new System.Drawing.Point(259, 32);
            this.EmployeeLb.Name = "EmployeeLb";
            this.EmployeeLb.Size = new System.Drawing.Size(172, 13);
            this.EmployeeLb.TabIndex = 8;
            this.EmployeeLb.Text = "Проводивший осмотр сотрудник";
            // 
            // btCancel
            // 
            this.btCancel.CausesValidation = false;
            this.btCancel.Location = new System.Drawing.Point(239, 275);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(192, 40);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btUpdateInspection
            // 
            this.btUpdateInspection.Location = new System.Drawing.Point(32, 275);
            this.btUpdateInspection.Name = "btUpdateInspection";
            this.btUpdateInspection.Size = new System.Drawing.Size(183, 40);
            this.btUpdateInspection.TabIndex = 11;
            this.btUpdateInspection.Text = "Изменить";
            this.btUpdateInspection.UseVisualStyleBackColor = true;
            this.btUpdateInspection.Click += new System.EventHandler(this.btUpdateInspection_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // countLb
            // 
            this.countLb.AutoSize = true;
            this.countLb.Location = new System.Drawing.Point(383, 154);
            this.countLb.Name = "countLb";
            this.countLb.Size = new System.Drawing.Size(0, 13);
            this.countLb.TabIndex = 12;
            // 
            // tbAnimal
            // 
            this.tbAnimal.Enabled = false;
            this.tbAnimal.Location = new System.Drawing.Point(34, 74);
            this.tbAnimal.Name = "tbAnimal";
            this.tbAnimal.Size = new System.Drawing.Size(197, 20);
            this.tbAnimal.TabIndex = 13;
            // 
            // UpdateAnimalsInspectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 327);
            this.Controls.Add(this.tbAnimal);
            this.Controls.Add(this.countLb);
            this.Controls.Add(this.btUpdateInspection);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.EmployeeLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateInspectionLb);
            this.Controls.Add(this.AnimalLb);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.InspectionDatePicker);
            this.Controls.Add(this.tbEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpdateAnimalsInspectionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAnimalsInspectionsForm";
            this.Load += new System.EventHandler(this.UpdateAnimalsInspectionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbEmployee;
        private System.Windows.Forms.DateTimePicker InspectionDatePicker;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label AnimalLb;
        private System.Windows.Forms.Label DateInspectionLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EmployeeLb;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btUpdateInspection;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label countLb;
        private System.Windows.Forms.TextBox tbAnimal;
    }
}