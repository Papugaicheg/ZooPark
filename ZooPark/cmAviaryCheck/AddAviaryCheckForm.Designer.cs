namespace ZooPark.cmAviaryCheck
{
    partial class AddAviaryCheckForm
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
            this.btAddAviaryCheck = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.checkDateLb = new System.Windows.Forms.Label();
            this.dtpAviaryCheck = new System.Windows.Forms.DateTimePicker();
            this.aviaryLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmployee = new System.Windows.Forms.TextBox();
            this.cbAviary = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbEx = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // countLb
            // 
            this.countLb.AutoSize = true;
            this.countLb.Location = new System.Drawing.Point(363, 129);
            this.countLb.Name = "countLb";
            this.countLb.Size = new System.Drawing.Size(0, 13);
            this.countLb.TabIndex = 28;
            // 
            // btAddAviaryCheck
            // 
            this.btAddAviaryCheck.Location = new System.Drawing.Point(12, 276);
            this.btAddAviaryCheck.Name = "btAddAviaryCheck";
            this.btAddAviaryCheck.Size = new System.Drawing.Size(192, 40);
            this.btAddAviaryCheck.TabIndex = 27;
            this.btAddAviaryCheck.Text = "Добавить";
            this.btAddAviaryCheck.UseVisualStyleBackColor = true;
            this.btAddAviaryCheck.Click += new System.EventHandler(this.btAddAviaryCheck_Click);
            // 
            // btCancel
            // 
            this.btCancel.CausesValidation = false;
            this.btCancel.Location = new System.Drawing.Point(275, 276);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(201, 40);
            this.btCancel.TabIndex = 26;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Комментарий";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(12, 145);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(464, 94);
            this.tbComment.TabIndex = 24;
            this.tbComment.TextChanged += new System.EventHandler(this.tbComment_TextChanged);
            this.tbComment.Validating += new System.ComponentModel.CancelEventHandler(this.tbComment_Validating);
            this.tbComment.Validated += new System.EventHandler(this.tbComment_Validated);
            // 
            // checkDateLb
            // 
            this.checkDateLb.AutoSize = true;
            this.checkDateLb.Location = new System.Drawing.Point(290, 97);
            this.checkDateLb.Name = "checkDateLb";
            this.checkDateLb.Size = new System.Drawing.Size(84, 13);
            this.checkDateLb.TabIndex = 23;
            this.checkDateLb.Text = "Дата проверки";
            // 
            // dtpAviaryCheck
            // 
            this.dtpAviaryCheck.Location = new System.Drawing.Point(12, 92);
            this.dtpAviaryCheck.Name = "dtpAviaryCheck";
            this.dtpAviaryCheck.Size = new System.Drawing.Size(239, 20);
            this.dtpAviaryCheck.TabIndex = 22;
            // 
            // aviaryLb
            // 
            this.aviaryLb.AutoSize = true;
            this.aviaryLb.Location = new System.Drawing.Point(290, 56);
            this.aviaryLb.Name = "aviaryLb";
            this.aviaryLb.Size = new System.Drawing.Size(44, 13);
            this.aviaryLb.TabIndex = 21;
            this.aviaryLb.Text = "Вольер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Сотрудник выполняющий проверку";
            // 
            // tbEmployee
            // 
            this.tbEmployee.Enabled = false;
            this.tbEmployee.Location = new System.Drawing.Point(12, 14);
            this.tbEmployee.Name = "tbEmployee";
            this.tbEmployee.Size = new System.Drawing.Size(239, 20);
            this.tbEmployee.TabIndex = 18;
            // 
            // cbAviary
            // 
            this.cbAviary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAviary.FormattingEnabled = true;
            this.cbAviary.Location = new System.Drawing.Point(12, 53);
            this.cbAviary.Name = "cbAviary";
            this.cbAviary.Size = new System.Drawing.Size(239, 21);
            this.cbAviary.TabIndex = 29;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbEx
            // 
            this.cbEx.AutoSize = true;
            this.cbEx.Location = new System.Drawing.Point(12, 245);
            this.cbEx.Name = "cbEx";
            this.cbEx.Size = new System.Drawing.Size(151, 17);
            this.cbEx.TabIndex = 30;
            this.cbEx.Text = "Нарушений не выявлено";
            this.cbEx.UseVisualStyleBackColor = true;
            this.cbEx.CheckedChanged += new System.EventHandler(this.cbEx_CheckedChanged);
            // 
            // AddAviaryCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 357);
            this.Controls.Add(this.cbEx);
            this.Controls.Add(this.cbAviary);
            this.Controls.Add(this.countLb);
            this.Controls.Add(this.btAddAviaryCheck);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.checkDateLb);
            this.Controls.Add(this.dtpAviaryCheck);
            this.Controls.Add(this.aviaryLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmployee);
            this.Name = "AddAviaryCheckForm";
            this.Text = "AddAviaryCheckForm";
            this.Load += new System.EventHandler(this.AddAviaryCheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countLb;
        private System.Windows.Forms.Button btAddAviaryCheck;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label checkDateLb;
        private System.Windows.Forms.DateTimePicker dtpAviaryCheck;
        private System.Windows.Forms.Label aviaryLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmployee;
        private System.Windows.Forms.ComboBox cbAviary;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox cbEx;
    }
}