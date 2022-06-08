namespace ZooPark
{
    partial class AddPassForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPass1 = new System.Windows.Forms.TextBox();
            this.tbPass2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btAddPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // tbPass1
            // 
            this.tbPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass1.Location = new System.Drawing.Point(6, 6);
            this.tbPass1.Margin = new System.Windows.Forms.Padding(2);
            this.tbPass1.Name = "tbPass1";
            this.tbPass1.Size = new System.Drawing.Size(236, 22);
            this.tbPass1.TabIndex = 1;
            this.tbPass1.UseSystemPasswordChar = true;
            this.tbPass1.Validating += new System.ComponentModel.CancelEventHandler(this.tbPass1_Validating);
            // 
            // tbPass2
            // 
            this.tbPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass2.Location = new System.Drawing.Point(6, 88);
            this.tbPass2.Margin = new System.Windows.Forms.Padding(2);
            this.tbPass2.Name = "tbPass2";
            this.tbPass2.Size = new System.Drawing.Size(236, 22);
            this.tbPass2.TabIndex = 2;
            this.tbPass2.UseSystemPasswordChar = true;
            this.tbPass2.Validating += new System.ComponentModel.CancelEventHandler(this.tbPass2_Validating);
            this.tbPass2.Validated += new System.EventHandler(this.tbPass2_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(270, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(270, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Повторите \r\nвведенный пароль";
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowPass.Location = new System.Drawing.Point(6, 32);
            this.cbShowPass.Margin = new System.Windows.Forms.Padding(2);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(184, 17);
            this.cbShowPass.TabIndex = 5;
            this.cbShowPass.Text = "Отобразить введенный пароль";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btAddPass
            // 
            this.btAddPass.Location = new System.Drawing.Point(6, 124);
            this.btAddPass.Margin = new System.Windows.Forms.Padding(2);
            this.btAddPass.Name = "btAddPass";
            this.btAddPass.Size = new System.Drawing.Size(236, 40);
            this.btAddPass.TabIndex = 6;
            this.btAddPass.Text = "Добавить пароль";
            this.btAddPass.UseVisualStyleBackColor = true;
            this.btAddPass.Click += new System.EventHandler(this.btAddPass_Click);
            // 
            // AddPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 182);
            this.Controls.Add(this.btAddPass);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPass2);
            this.Controls.Add(this.tbPass1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPassForm";
            this.Load += new System.EventHandler(this.AddPassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPass1;
        private System.Windows.Forms.TextBox tbPass2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btAddPass;
    }
}