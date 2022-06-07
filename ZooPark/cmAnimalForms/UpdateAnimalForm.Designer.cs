namespace ZooPark.cmAnimalForms
{
    partial class UpdateAnimalForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbAviary = new System.Windows.Forms.ComboBox();
            this.lbAviary = new System.Windows.Forms.Label();
            this.lbHabitat = new System.Windows.Forms.Label();
            this.UpdateAnimalButton = new System.Windows.Forms.Button();
            this.CancelUpdateAnimalButton = new System.Windows.Forms.Button();
            this.tbHabitat = new System.Windows.Forms.TextBox();
            this.tbCurrentAviary = new System.Windows.Forms.TextBox();
            this.lbCurrentAviary = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lbHeight = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.weightLb = new System.Windows.Forms.Label();
            this.AgeLb = new System.Windows.Forms.Label();
            this.cbChangeAviary = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(488, 34);
            this.lbName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(219, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Название животного";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(24, 31);
            this.tbName.Margin = new System.Windows.Forms.Padding(6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(414, 31);
            this.tbName.TabIndex = 1;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // cbAviary
            // 
            this.cbAviary.FormattingEnabled = true;
            this.cbAviary.Location = new System.Drawing.Point(24, 200);
            this.cbAviary.Margin = new System.Windows.Forms.Padding(6);
            this.cbAviary.Name = "cbAviary";
            this.cbAviary.Size = new System.Drawing.Size(414, 33);
            this.cbAviary.TabIndex = 2;
            // 
            // lbAviary
            // 
            this.lbAviary.AutoSize = true;
            this.lbAviary.Location = new System.Drawing.Point(488, 203);
            this.lbAviary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAviary.Name = "lbAviary";
            this.lbAviary.Size = new System.Drawing.Size(153, 25);
            this.lbAviary.TabIndex = 3;
            this.lbAviary.Text = "Новый вольер";
            // 
            // lbHabitat
            // 
            this.lbHabitat.AutoSize = true;
            this.lbHabitat.Location = new System.Drawing.Point(488, 453);
            this.lbHabitat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbHabitat.Name = "lbHabitat";
            this.lbHabitat.Size = new System.Drawing.Size(216, 25);
            this.lbHabitat.TabIndex = 5;
            this.lbHabitat.Text = "Тип среды обитания";
            // 
            // UpdateAnimalButton
            // 
            this.UpdateAnimalButton.Location = new System.Drawing.Point(15, 520);
            this.UpdateAnimalButton.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateAnimalButton.Name = "UpdateAnimalButton";
            this.UpdateAnimalButton.Size = new System.Drawing.Size(374, 62);
            this.UpdateAnimalButton.TabIndex = 6;
            this.UpdateAnimalButton.Text = "Изменить";
            this.UpdateAnimalButton.UseVisualStyleBackColor = true;
            this.UpdateAnimalButton.Click += new System.EventHandler(this.UpdateAnimalButton_Click);
            // 
            // CancelUpdateAnimalButton
            // 
            this.CancelUpdateAnimalButton.CausesValidation = false;
            this.CancelUpdateAnimalButton.Location = new System.Drawing.Point(431, 516);
            this.CancelUpdateAnimalButton.Margin = new System.Windows.Forms.Padding(6);
            this.CancelUpdateAnimalButton.Name = "CancelUpdateAnimalButton";
            this.CancelUpdateAnimalButton.Size = new System.Drawing.Size(374, 65);
            this.CancelUpdateAnimalButton.TabIndex = 7;
            this.CancelUpdateAnimalButton.Text = "Отмена";
            this.CancelUpdateAnimalButton.UseVisualStyleBackColor = true;
            this.CancelUpdateAnimalButton.Click += new System.EventHandler(this.CancelUpdateAnimalButton_Click);
            // 
            // tbHabitat
            // 
            this.tbHabitat.Enabled = false;
            this.tbHabitat.Location = new System.Drawing.Point(24, 450);
            this.tbHabitat.Margin = new System.Windows.Forms.Padding(6);
            this.tbHabitat.Name = "tbHabitat";
            this.tbHabitat.Size = new System.Drawing.Size(414, 31);
            this.tbHabitat.TabIndex = 8;
            // 
            // tbCurrentAviary
            // 
            this.tbCurrentAviary.Enabled = false;
            this.tbCurrentAviary.Location = new System.Drawing.Point(24, 93);
            this.tbCurrentAviary.Margin = new System.Windows.Forms.Padding(6);
            this.tbCurrentAviary.Name = "tbCurrentAviary";
            this.tbCurrentAviary.Size = new System.Drawing.Size(414, 31);
            this.tbCurrentAviary.TabIndex = 9;
            // 
            // lbCurrentAviary
            // 
            this.lbCurrentAviary.AutoSize = true;
            this.lbCurrentAviary.Location = new System.Drawing.Point(488, 96);
            this.lbCurrentAviary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCurrentAviary.Name = "lbCurrentAviary";
            this.lbCurrentAviary.Size = new System.Drawing.Size(176, 25);
            this.lbCurrentAviary.TabIndex = 10;
            this.lbCurrentAviary.Text = "Текущий вольер";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(24, 388);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(414, 31);
            this.tbHeight.TabIndex = 11;
            this.tbHeight.Validating += new System.ComponentModel.CancelEventHandler(this.tbHeight_Validating);
            this.tbHeight.Validated += new System.EventHandler(this.tbHeight_Validated);
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(488, 391);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(97, 25);
            this.lbHeight.TabIndex = 12;
            this.lbHeight.Text = "Рост, см";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(24, 264);
            this.nudAge.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(414, 31);
            this.nudAge.TabIndex = 13;
            this.nudAge.ValueChanged += new System.EventHandler(this.nudAge_ValueChanged);
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(24, 326);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(414, 31);
            this.tbWeight.TabIndex = 14;
            this.tbWeight.Validating += new System.ComponentModel.CancelEventHandler(this.tbWeight_Validating);
            this.tbWeight.Validated += new System.EventHandler(this.tbWeight_Validated);
            // 
            // weightLb
            // 
            this.weightLb.AutoSize = true;
            this.weightLb.Location = new System.Drawing.Point(488, 329);
            this.weightLb.Name = "weightLb";
            this.weightLb.Size = new System.Drawing.Size(80, 25);
            this.weightLb.TabIndex = 15;
            this.weightLb.Text = "Вес, кг";
            // 
            // AgeLb
            // 
            this.AgeLb.AutoSize = true;
            this.AgeLb.Location = new System.Drawing.Point(488, 266);
            this.AgeLb.Name = "AgeLb";
            this.AgeLb.Size = new System.Drawing.Size(94, 25);
            this.AgeLb.TabIndex = 16;
            this.AgeLb.Text = "Возраст";
            // 
            // cbChangeAviary
            // 
            this.cbChangeAviary.AutoSize = true;
            this.cbChangeAviary.Location = new System.Drawing.Point(24, 149);
            this.cbChangeAviary.Name = "cbChangeAviary";
            this.cbChangeAviary.Size = new System.Drawing.Size(198, 29);
            this.cbChangeAviary.TabIndex = 17;
            this.cbChangeAviary.Text = "Смена вольера";
            this.cbChangeAviary.UseVisualStyleBackColor = true;
            this.cbChangeAviary.CheckStateChanged += new System.EventHandler(this.cbChangeAviary_CheckedStateChanged);
            // 
            // UpdateAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 602);
            this.Controls.Add(this.cbChangeAviary);
            this.Controls.Add(this.AgeLb);
            this.Controls.Add(this.weightLb);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.lbHeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.lbCurrentAviary);
            this.Controls.Add(this.tbCurrentAviary);
            this.Controls.Add(this.tbHabitat);
            this.Controls.Add(this.CancelUpdateAnimalButton);
            this.Controls.Add(this.UpdateAnimalButton);
            this.Controls.Add(this.lbHabitat);
            this.Controls.Add(this.lbAviary);
            this.Controls.Add(this.cbAviary);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UpdateAnimalForm";
            this.Text = "UpdateAnimalForm";
            this.Load += new System.EventHandler(this.UpdateAnimalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbAviary;
        private System.Windows.Forms.Label lbAviary;
        private System.Windows.Forms.Label lbHabitat;
        private System.Windows.Forms.Button UpdateAnimalButton;
        private System.Windows.Forms.Button CancelUpdateAnimalButton;
        private System.Windows.Forms.TextBox tbHabitat;
        private System.Windows.Forms.TextBox tbCurrentAviary;
        private System.Windows.Forms.Label lbCurrentAviary;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label AgeLb;
        private System.Windows.Forms.Label weightLb;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.CheckBox cbChangeAviary;
    }
}