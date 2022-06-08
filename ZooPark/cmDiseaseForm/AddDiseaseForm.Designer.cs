namespace ZooPark.cmDiseaseForm
{
    partial class AddDiseaseForm
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
            this.cbDisease = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.AddDiseaseButton = new System.Windows.Forms.Button();
            this.diseaseLb = new System.Windows.Forms.Label();
            this.animalLb = new System.Windows.Forms.Label();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbDisease
            // 
            this.cbDisease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisease.FormattingEnabled = true;
            this.cbDisease.Location = new System.Drawing.Point(12, 49);
            this.cbDisease.Name = "cbDisease";
            this.cbDisease.Size = new System.Drawing.Size(241, 21);
            this.cbDisease.TabIndex = 17;
            // 
            // btCancel
            // 
            this.btCancel.CausesValidation = false;
            this.btCancel.Location = new System.Drawing.Point(220, 98);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(147, 34);
            this.btCancel.TabIndex = 16;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // AddDiseaseButton
            // 
            this.AddDiseaseButton.Location = new System.Drawing.Point(12, 100);
            this.AddDiseaseButton.Name = "AddDiseaseButton";
            this.AddDiseaseButton.Size = new System.Drawing.Size(147, 32);
            this.AddDiseaseButton.TabIndex = 15;
            this.AddDiseaseButton.Text = "Добавить";
            this.AddDiseaseButton.UseVisualStyleBackColor = true;
            this.AddDiseaseButton.Click += new System.EventHandler(this.AddDiseaseButton_Click);
            // 
            // diseaseLb
            // 
            this.diseaseLb.AutoSize = true;
            this.diseaseLb.Location = new System.Drawing.Point(288, 52);
            this.diseaseLb.Name = "diseaseLb";
            this.diseaseLb.Size = new System.Drawing.Size(74, 13);
            this.diseaseLb.TabIndex = 14;
            this.diseaseLb.Text = "Заболевание";
            // 
            // animalLb
            // 
            this.animalLb.AutoSize = true;
            this.animalLb.Location = new System.Drawing.Point(288, 15);
            this.animalLb.Name = "animalLb";
            this.animalLb.Size = new System.Drawing.Size(59, 13);
            this.animalLb.TabIndex = 13;
            this.animalLb.Text = "Животное";
            // 
            // cbAnimal
            // 
            this.cbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(12, 12);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(241, 21);
            this.cbAnimal.TabIndex = 18;
            // 
            // AddDiseaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 155);
            this.Controls.Add(this.cbAnimal);
            this.Controls.Add(this.cbDisease);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.AddDiseaseButton);
            this.Controls.Add(this.diseaseLb);
            this.Controls.Add(this.animalLb);
            this.Name = "AddDiseaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDiseaseForm";
            this.Load += new System.EventHandler(this.AddDiseaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDisease;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button AddDiseaseButton;
        private System.Windows.Forms.Label diseaseLb;
        private System.Windows.Forms.Label animalLb;
        private System.Windows.Forms.ComboBox cbAnimal;
    }
}