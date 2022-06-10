namespace ZooPark.cmAviaryCheck
{
    partial class UpdateAviaryCheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAviaryCheckForm));
            this.tbEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAviary = new System.Windows.Forms.TextBox();
            this.aviaryLb = new System.Windows.Forms.Label();
            this.dtpAviaryCheck = new System.Windows.Forms.DateTimePicker();
            this.checkDateLb = new System.Windows.Forms.Label();
            this.countLb = new System.Windows.Forms.Label();
            this.btUpdateAviaryCheck = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmployee
            // 
            this.tbEmployee.Enabled = false;
            this.tbEmployee.Location = new System.Drawing.Point(12, 12);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.Size = new System.Drawing.Size(239, 20);
            this.tbEmployee.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудник выполняющий проверку";
            // 
            // tbAviary
            // 
            this.tbAviary.Enabled = false;
            this.tbAviary.Location = new System.Drawing.Point(12, 51);
            this.tbAviary.Name = "tbAviary";
            this.tbAviary.Size = new System.Drawing.Size(239, 20);
            this.tbAviary.TabIndex = 2;
            // 
            // aviaryLb
            // 
            this.aviaryLb.AutoSize = true;
            this.aviaryLb.Location = new System.Drawing.Point(290, 54);
            this.aviaryLb.Name = "aviaryLb";
            this.aviaryLb.Size = new System.Drawing.Size(44, 13);
            this.aviaryLb.TabIndex = 3;
            this.aviaryLb.Text = "Вольер";
            // 
            // dtpAviaryCheck
            // 
            this.dtpAviaryCheck.Location = new System.Drawing.Point(12, 90);
            this.dtpAviaryCheck.Name = "dtpAviaryCheck";
            this.dtpAviaryCheck.Size = new System.Drawing.Size(239, 20);
            this.dtpAviaryCheck.TabIndex = 4;
            // 
            // checkDateLb
            // 
            this.checkDateLb.AutoSize = true;
            this.checkDateLb.Location = new System.Drawing.Point(290, 95);
            this.checkDateLb.Name = "checkDateLb";
            this.checkDateLb.Size = new System.Drawing.Size(84, 13);
            this.checkDateLb.TabIndex = 5;
            this.checkDateLb.Text = "Дата проверки";
            // 
            // countLb
            // 
            this.countLb.AutoSize = true;
            this.countLb.Location = new System.Drawing.Point(363, 127);
            this.countLb.Name = "countLb";
            this.countLb.Size = new System.Drawing.Size(0, 13);
            this.countLb.TabIndex = 17;
            // 
            // btUpdateAviaryCheck
            // 
            this.btUpdateAviaryCheck.Location = new System.Drawing.Point(12, 256);
            this.btUpdateAviaryCheck.Name = "btUpdateAviaryCheck";
            this.btUpdateAviaryCheck.Size = new System.Drawing.Size(192, 40);
            this.btUpdateAviaryCheck.TabIndex = 16;
            this.btUpdateAviaryCheck.Text = "Изменить";
            this.btUpdateAviaryCheck.UseVisualStyleBackColor = true;
            this.btUpdateAviaryCheck.Click += new System.EventHandler(this.btUpdateAviaryCheck_Click);
            // 
            // btCancel
            // 
            this.btCancel.CausesValidation = false;
            this.btCancel.Location = new System.Drawing.Point(275, 256);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(201, 40);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Комментарий";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(12, 143);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(464, 94);
            this.tbComment.TabIndex = 13;
            this.tbComment.TextChanged += new System.EventHandler(this.tbComment_TextChanged);
            this.tbComment.Validating += new System.ComponentModel.CancelEventHandler(this.tbComment_Validating);
            this.tbComment.Validated += new System.EventHandler(this.tbComment_Validated);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UpdateAviaryCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 317);
            this.Controls.Add(this.countLb);
            this.Controls.Add(this.btUpdateAviaryCheck);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.checkDateLb);
            this.Controls.Add(this.dtpAviaryCheck);
            this.Controls.Add(this.aviaryLb);
            this.Controls.Add(this.tbAviary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateAviaryCheckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAviaryCheck";
            this.Load += new System.EventHandler(this.UpdateAviaryCheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAviary;
        private System.Windows.Forms.Label aviaryLb;
        private System.Windows.Forms.DateTimePicker dtpAviaryCheck;
        private System.Windows.Forms.Label checkDateLb;
        private System.Windows.Forms.Label countLb;
        private System.Windows.Forms.Button btUpdateAviaryCheck;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}