namespace ZooPark.cmAnimalForms
{
    partial class AddAnimalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAnimalForm));
            this.CancelAddAnimalButton = new System.Windows.Forms.Button();
            this.AddAnimalButton = new System.Windows.Forms.Button();
            this.lbHabitat = new System.Windows.Forms.Label();
            this.lbAviary = new System.Windows.Forms.Label();
            this.cbAviary = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.cbHabitat = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AgeLb = new System.Windows.Forms.Label();
            this.weightLb = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.lbHeight = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.dtpReceipt = new System.Windows.Forms.DateTimePicker();
            this.receiptDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelAddAnimalButton
            // 
            this.CancelAddAnimalButton.CausesValidation = false;
            this.CancelAddAnimalButton.Location = new System.Drawing.Point(249, 258);
            this.CancelAddAnimalButton.Name = "CancelAddAnimalButton";
            this.CancelAddAnimalButton.Size = new System.Drawing.Size(209, 32);
            this.CancelAddAnimalButton.TabIndex = 17;
            this.CancelAddAnimalButton.Text = "Отмена";
            this.CancelAddAnimalButton.UseVisualStyleBackColor = true;
            this.CancelAddAnimalButton.Click += new System.EventHandler(this.CancelAddAnimalButton_Click);
            // 
            // AddAnimalButton
            // 
            this.AddAnimalButton.Location = new System.Drawing.Point(12, 258);
            this.AddAnimalButton.Name = "AddAnimalButton";
            this.AddAnimalButton.Size = new System.Drawing.Size(209, 32);
            this.AddAnimalButton.TabIndex = 16;
            this.AddAnimalButton.Text = "Добавить";
            this.AddAnimalButton.UseVisualStyleBackColor = true;
            this.AddAnimalButton.Click += new System.EventHandler(this.AddAnimalButton_Click);
            // 
            // lbHabitat
            // 
            this.lbHabitat.AutoSize = true;
            this.lbHabitat.Location = new System.Drawing.Point(287, 50);
            this.lbHabitat.Name = "lbHabitat";
            this.lbHabitat.Size = new System.Drawing.Size(111, 13);
            this.lbHabitat.TabIndex = 15;
            this.lbHabitat.Text = "Тип среды обитания";
            // 
            // lbAviary
            // 
            this.lbAviary.AutoSize = true;
            this.lbAviary.Location = new System.Drawing.Point(287, 82);
            this.lbAviary.Name = "lbAviary";
            this.lbAviary.Size = new System.Drawing.Size(44, 13);
            this.lbAviary.TabIndex = 14;
            this.lbAviary.Text = "Вольер";
            // 
            // cbAviary
            // 
            this.cbAviary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAviary.FormattingEnabled = true;
            this.cbAviary.Location = new System.Drawing.Point(12, 81);
            this.cbAviary.Name = "cbAviary";
            this.cbAviary.Size = new System.Drawing.Size(245, 21);
            this.cbAviary.TabIndex = 13;
            this.cbAviary.Validated += new System.EventHandler(this.cbAviary_Validated);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(245, 20);
            this.tbName.TabIndex = 12;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(287, 14);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(114, 13);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Название животного";
            // 
            // cbHabitat
            // 
            this.cbHabitat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHabitat.FormattingEnabled = true;
            this.cbHabitat.Location = new System.Drawing.Point(12, 46);
            this.cbHabitat.Name = "cbHabitat";
            this.cbHabitat.Size = new System.Drawing.Size(245, 21);
            this.cbHabitat.TabIndex = 18;
            this.cbHabitat.SelectionChangeCommitted += new System.EventHandler(this.cbHabitat_SelectedValueChanged);
            this.cbHabitat.Validated += new System.EventHandler(this.cbHabitat_Validated);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AgeLb
            // 
            this.AgeLb.AutoSize = true;
            this.AgeLb.Location = new System.Drawing.Point(287, 116);
            this.AgeLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AgeLb.Name = "AgeLb";
            this.AgeLb.Size = new System.Drawing.Size(49, 13);
            this.AgeLb.TabIndex = 34;
            this.AgeLb.Text = "Возраст";
            // 
            // weightLb
            // 
            this.weightLb.AutoSize = true;
            this.weightLb.Location = new System.Drawing.Point(287, 151);
            this.weightLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightLb.Name = "weightLb";
            this.weightLb.Size = new System.Drawing.Size(43, 13);
            this.weightLb.TabIndex = 33;
            this.weightLb.Text = "Вес, кг";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(12, 149);
            this.tbWeight.Margin = new System.Windows.Forms.Padding(2);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(245, 20);
            this.tbWeight.TabIndex = 32;
            this.tbWeight.Validating += new System.ComponentModel.CancelEventHandler(this.tbWeight_Validating);
            this.tbWeight.Validated += new System.EventHandler(this.tbWeight_Validated);
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(12, 115);
            this.nudAge.Margin = new System.Windows.Forms.Padding(2);
            this.nudAge.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(243, 20);
            this.nudAge.TabIndex = 31;
            this.nudAge.ValueChanged += new System.EventHandler(this.nudAge_ValueChanged);
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(287, 185);
            this.lbHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(51, 13);
            this.lbHeight.TabIndex = 30;
            this.lbHeight.Text = "Рост, см";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(12, 183);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(2);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(245, 20);
            this.tbHeight.TabIndex = 29;
            this.tbHeight.Validating += new System.ComponentModel.CancelEventHandler(this.tbHeight_Validating);
            this.tbHeight.Validated += new System.EventHandler(this.tbHeight_Validated);
            // 
            // dtpReceipt
            // 
            this.dtpReceipt.Location = new System.Drawing.Point(12, 217);
            this.dtpReceipt.Name = "dtpReceipt";
            this.dtpReceipt.Size = new System.Drawing.Size(245, 20);
            this.dtpReceipt.TabIndex = 35;
            this.dtpReceipt.Validated += new System.EventHandler(this.dtpReceipt_Validated);
            // 
            // receiptDate
            // 
            this.receiptDate.AutoSize = true;
            this.receiptDate.Location = new System.Drawing.Point(287, 220);
            this.receiptDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.receiptDate.Name = "receiptDate";
            this.receiptDate.Size = new System.Drawing.Size(100, 13);
            this.receiptDate.TabIndex = 36;
            this.receiptDate.Text = "Дата поступления";
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 302);
            this.Controls.Add(this.receiptDate);
            this.Controls.Add(this.dtpReceipt);
            this.Controls.Add(this.AgeLb);
            this.Controls.Add(this.weightLb);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.lbHeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.cbHabitat);
            this.Controls.Add(this.CancelAddAnimalButton);
            this.Controls.Add(this.AddAnimalButton);
            this.Controls.Add(this.lbHabitat);
            this.Controls.Add(this.lbAviary);
            this.Controls.Add(this.cbAviary);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAnimalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAnimalForm";
            this.Load += new System.EventHandler(this.AddAnimalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelAddAnimalButton;
        private System.Windows.Forms.Button AddAnimalButton;
        private System.Windows.Forms.Label lbHabitat;
        private System.Windows.Forms.Label lbAviary;
        private System.Windows.Forms.ComboBox cbAviary;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cbHabitat;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label AgeLb;
        private System.Windows.Forms.Label weightLb;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label receiptDate;
        private System.Windows.Forms.DateTimePicker dtpReceipt;
    }
}