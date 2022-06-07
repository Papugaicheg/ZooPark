namespace ZooPark.cmDiseaseForm
{
    partial class UpdateDiseaseForm
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
            this.animalLb = new System.Windows.Forms.Label();
            this.diseaseLb = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.UpdateDiseaseButton = new System.Windows.Forms.Button();
            this.cbDisease = new System.Windows.Forms.ComboBox();
            this.tbAnimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // animalLb
            // 
            this.animalLb.AutoSize = true;
            this.animalLb.Location = new System.Drawing.Point(289, 15);
            this.animalLb.Name = "animalLb";
            this.animalLb.Size = new System.Drawing.Size(59, 13);
            this.animalLb.TabIndex = 2;
            this.animalLb.Text = "Животное";
            // 
            // diseaseLb
            // 
            this.diseaseLb.AutoSize = true;
            this.diseaseLb.Location = new System.Drawing.Point(289, 52);
            this.diseaseLb.Name = "diseaseLb";
            this.diseaseLb.Size = new System.Drawing.Size(74, 13);
            this.diseaseLb.TabIndex = 3;
            this.diseaseLb.Text = "Заболевание";
            // 
            // btCancel
            // 
            this.btCancel.CausesValidation = false;
            this.btCancel.Location = new System.Drawing.Point(221, 98);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(147, 34);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // UpdateDiseaseButton
            // 
            this.UpdateDiseaseButton.Location = new System.Drawing.Point(13, 100);
            this.UpdateDiseaseButton.Name = "UpdateDiseaseButton";
            this.UpdateDiseaseButton.Size = new System.Drawing.Size(147, 32);
            this.UpdateDiseaseButton.TabIndex = 8;
            this.UpdateDiseaseButton.Text = "Изменить";
            this.UpdateDiseaseButton.UseVisualStyleBackColor = true;
            this.UpdateDiseaseButton.Click += new System.EventHandler(this.UpdateDiseaseButton_Click);
            // 
            // cbDisease
            // 
            this.cbDisease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisease.FormattingEnabled = true;
            this.cbDisease.Location = new System.Drawing.Point(13, 49);
            this.cbDisease.Name = "cbDisease";
            this.cbDisease.Size = new System.Drawing.Size(241, 21);
            this.cbDisease.TabIndex = 11;
            // 
            // tbAnimal
            // 
            this.tbAnimal.Enabled = false;
            this.tbAnimal.Location = new System.Drawing.Point(13, 12);
            this.tbAnimal.Name = "tbAnimal";
            this.tbAnimal.Size = new System.Drawing.Size(241, 20);
            this.tbAnimal.TabIndex = 12;
            // 
            // UpdateDiseaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 144);
            this.Controls.Add(this.tbAnimal);
            this.Controls.Add(this.cbDisease);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.UpdateDiseaseButton);
            this.Controls.Add(this.diseaseLb);
            this.Controls.Add(this.animalLb);
            this.Name = "UpdateDiseaseForm";
            this.Text = "UpdateDiseaseForm";
            this.Load += new System.EventHandler(this.UpdateDiseaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label animalLb;
        private System.Windows.Forms.Label diseaseLb;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button UpdateDiseaseButton;
        private System.Windows.Forms.ComboBox cbDisease;
        private System.Windows.Forms.TextBox tbAnimal;
    }
}