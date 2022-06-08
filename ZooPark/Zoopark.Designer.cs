namespace ZooPark
{
    partial class Zoopark
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.cmEmployee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmUpdateEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.cmAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRefreshEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDeleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.cmInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAnimals = new System.Windows.Forms.TabPage();
            this.dgAnimals = new System.Windows.Forms.DataGridView();
            this.cmAnimals = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmUpdateAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.cmAddAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRefreshAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDeleteAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.cmInfoAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAnimalsInspection = new System.Windows.Forms.TabPage();
            this.dgAnimalsInspections = new System.Windows.Forms.DataGridView();
            this.cmAnimalsInspections = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tabVaccination = new System.Windows.Forms.TabPage();
            this.dgVaccinations = new System.Windows.Forms.DataGridView();
            this.cmVaccination = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmUpdateVaccination = new System.Windows.Forms.ToolStripMenuItem();
            this.cmAddVaccination = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRefreshVaccination = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRemoveVaccination = new System.Windows.Forms.ToolStripMenuItem();
            this.tabDisease = new System.Windows.Forms.TabPage();
            this.dgDisease = new System.Windows.Forms.DataGridView();
            this.cmDisease = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmUpdateDisease = new System.Windows.Forms.ToolStripMenuItem();
            this.cmAddDisease = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRefreshDisease = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDeleteDisease = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAviaryCheck = new System.Windows.Forms.TabPage();
            this.dgAviaryCheck = new System.Windows.Forms.DataGridView();
            this.cmAviaryCheck = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmUpdateAviaryCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.cmAddAviaryCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRefreshAviaryCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDeleteAviaryCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            this.cmEmployee.SuspendLayout();
            this.tabAnimals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimals)).BeginInit();
            this.cmAnimals.SuspendLayout();
            this.tabAnimalsInspection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimalsInspections)).BeginInit();
            this.cmAnimalsInspections.SuspendLayout();
            this.tabVaccination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccinations)).BeginInit();
            this.cmVaccination.SuspendLayout();
            this.tabDisease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisease)).BeginInit();
            this.cmDisease.SuspendLayout();
            this.tabAviaryCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAviaryCheck)).BeginInit();
            this.cmAviaryCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEmployee);
            this.tabControl.Controls.Add(this.tabAnimals);
            this.tabControl.Controls.Add(this.tabAnimalsInspection);
            this.tabControl.Controls.Add(this.tabVaccination);
            this.tabControl.Controls.Add(this.tabDisease);
            this.tabControl.Controls.Add(this.tabAviaryCheck);
            this.tabControl.Location = new System.Drawing.Point(6, 6);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(696, 353);
            this.tabControl.TabIndex = 0;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.dgEmployee);
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(2);
            this.tabEmployee.Size = new System.Drawing.Size(688, 327);
            this.tabEmployee.TabIndex = 0;
            this.tabEmployee.Text = "Сотрудники";
            this.tabEmployee.UseVisualStyleBackColor = true;
            this.tabEmployee.Enter += new System.EventHandler(this.tabEmployee_Enter);
            // 
            // dgEmployee
            // 
            this.dgEmployee.AllowUserToResizeColumns = false;
            this.dgEmployee.AllowUserToResizeRows = false;
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.ContextMenuStrip = this.cmEmployee;
            this.dgEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgEmployee.GridColor = System.Drawing.SystemColors.Control;
            this.dgEmployee.Location = new System.Drawing.Point(5, 5);
            this.dgEmployee.MultiSelect = false;
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.RowHeadersVisible = false;
            this.dgEmployee.RowHeadersWidth = 82;
            this.dgEmployee.Size = new System.Drawing.Size(678, 317);
            this.dgEmployee.TabIndex = 0;
            // 
            // cmEmployee
            // 
            this.cmEmployee.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmUpdateEmployee,
            this.cmAddEmployee,
            this.cmRefreshEmployee,
            this.cmDeleteEmployee,
            this.cmInfo});
            this.cmEmployee.Name = "cmEmployee";
            this.cmEmployee.Size = new System.Drawing.Size(146, 114);
            // 
            // cmUpdateEmployee
            // 
            this.cmUpdateEmployee.Name = "cmUpdateEmployee";
            this.cmUpdateEmployee.Size = new System.Drawing.Size(145, 22);
            this.cmUpdateEmployee.Text = "Изменить";
            this.cmUpdateEmployee.Click += new System.EventHandler(this.cmUpdateEmployee_Click);
            // 
            // cmAddEmployee
            // 
            this.cmAddEmployee.Name = "cmAddEmployee";
            this.cmAddEmployee.Size = new System.Drawing.Size(145, 22);
            this.cmAddEmployee.Text = "Добавить";
            this.cmAddEmployee.Click += new System.EventHandler(this.cmAddEmployee_Click);
            // 
            // cmRefreshEmployee
            // 
            this.cmRefreshEmployee.Name = "cmRefreshEmployee";
            this.cmRefreshEmployee.Size = new System.Drawing.Size(145, 22);
            this.cmRefreshEmployee.Text = "Обновить";
            this.cmRefreshEmployee.Click += new System.EventHandler(this.cmRefreshEmployee_Click);
            // 
            // cmDeleteEmployee
            // 
            this.cmDeleteEmployee.Name = "cmDeleteEmployee";
            this.cmDeleteEmployee.Size = new System.Drawing.Size(145, 22);
            this.cmDeleteEmployee.Text = "Удалить";
            this.cmDeleteEmployee.Click += new System.EventHandler(this.cmDeleteEmployee_Click);
            // 
            // cmInfo
            // 
            this.cmInfo.Name = "cmInfo";
            this.cmInfo.Size = new System.Drawing.Size(145, 22);
            this.cmInfo.Text = "Подробнее...";
            this.cmInfo.Click += new System.EventHandler(this.cmInfo_Click);
            // 
            // tabAnimals
            // 
            this.tabAnimals.Controls.Add(this.dgAnimals);
            this.tabAnimals.Location = new System.Drawing.Point(4, 22);
            this.tabAnimals.Margin = new System.Windows.Forms.Padding(2);
            this.tabAnimals.Name = "tabAnimals";
            this.tabAnimals.Padding = new System.Windows.Forms.Padding(2);
            this.tabAnimals.Size = new System.Drawing.Size(688, 327);
            this.tabAnimals.TabIndex = 1;
            this.tabAnimals.Text = "Животные";
            this.tabAnimals.UseVisualStyleBackColor = true;
            this.tabAnimals.Enter += new System.EventHandler(this.tabAnimals_Enter);
            // 
            // dgAnimals
            // 
            this.dgAnimals.AllowUserToResizeColumns = false;
            this.dgAnimals.AllowUserToResizeRows = false;
            this.dgAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnimals.ContextMenuStrip = this.cmAnimals;
            this.dgAnimals.Location = new System.Drawing.Point(5, 5);
            this.dgAnimals.MultiSelect = false;
            this.dgAnimals.Name = "dgAnimals";
            this.dgAnimals.RowHeadersVisible = false;
            this.dgAnimals.RowHeadersWidth = 82;
            this.dgAnimals.Size = new System.Drawing.Size(678, 317);
            this.dgAnimals.TabIndex = 0;
            // 
            // cmAnimals
            // 
            this.cmAnimals.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmAnimals.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmUpdateAnimal,
            this.cmAddAnimal,
            this.cmRefreshAnimal,
            this.cmDeleteAnimal,
            this.cmInfoAnimal});
            this.cmAnimals.Name = "cmAnimals";
            this.cmAnimals.Size = new System.Drawing.Size(146, 114);
            // 
            // cmUpdateAnimal
            // 
            this.cmUpdateAnimal.Name = "cmUpdateAnimal";
            this.cmUpdateAnimal.Size = new System.Drawing.Size(145, 22);
            this.cmUpdateAnimal.Text = "Изменить";
            this.cmUpdateAnimal.Click += new System.EventHandler(this.cmUpdateAnimal_Click);
            // 
            // cmAddAnimal
            // 
            this.cmAddAnimal.Name = "cmAddAnimal";
            this.cmAddAnimal.Size = new System.Drawing.Size(145, 22);
            this.cmAddAnimal.Text = "Добавить";
            this.cmAddAnimal.Click += new System.EventHandler(this.cmAddAnimal_Click);
            // 
            // cmRefreshAnimal
            // 
            this.cmRefreshAnimal.Name = "cmRefreshAnimal";
            this.cmRefreshAnimal.Size = new System.Drawing.Size(145, 22);
            this.cmRefreshAnimal.Text = "Обновить";
            this.cmRefreshAnimal.Click += new System.EventHandler(this.cmRefreshAnimal_Click);
            // 
            // cmDeleteAnimal
            // 
            this.cmDeleteAnimal.Name = "cmDeleteAnimal";
            this.cmDeleteAnimal.Size = new System.Drawing.Size(145, 22);
            this.cmDeleteAnimal.Text = "Удалить";
            this.cmDeleteAnimal.Click += new System.EventHandler(this.cmDeleteAnimal_Click);
            // 
            // cmInfoAnimal
            // 
            this.cmInfoAnimal.Name = "cmInfoAnimal";
            this.cmInfoAnimal.Size = new System.Drawing.Size(145, 22);
            this.cmInfoAnimal.Text = "Подробнее...";
            this.cmInfoAnimal.Click += new System.EventHandler(this.cmInfoAnimal_Click);
            // 
            // tabAnimalsInspection
            // 
            this.tabAnimalsInspection.Controls.Add(this.dgAnimalsInspections);
            this.tabAnimalsInspection.Location = new System.Drawing.Point(4, 22);
            this.tabAnimalsInspection.Name = "tabAnimalsInspection";
            this.tabAnimalsInspection.Size = new System.Drawing.Size(688, 327);
            this.tabAnimalsInspection.TabIndex = 2;
            this.tabAnimalsInspection.Text = "Журнал осмотров";
            this.tabAnimalsInspection.UseVisualStyleBackColor = true;
            this.tabAnimalsInspection.Enter += new System.EventHandler(this.tabAnimalsInspection_Enter);
            // 
            // dgAnimalsInspections
            // 
            this.dgAnimalsInspections.AllowUserToResizeColumns = false;
            this.dgAnimalsInspections.AllowUserToResizeRows = false;
            this.dgAnimalsInspections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAnimalsInspections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgAnimalsInspections.ContextMenuStrip = this.cmAnimalsInspections;
            this.dgAnimalsInspections.Location = new System.Drawing.Point(5, 5);
            this.dgAnimalsInspections.MultiSelect = false;
            this.dgAnimalsInspections.Name = "dgAnimalsInspections";
            this.dgAnimalsInspections.RowHeadersVisible = false;
            this.dgAnimalsInspections.RowHeadersWidth = 82;
            this.dgAnimalsInspections.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAnimalsInspections.Size = new System.Drawing.Size(676, 317);
            this.dgAnimalsInspections.TabIndex = 0;
            // 
            // cmAnimalsInspections
            // 
            this.cmAnimalsInspections.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmAnimalsInspections.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmUpdate,
            this.cmAdd,
            this.cmRefresh,
            this.cmDelete});
            this.cmAnimalsInspections.Name = "cmAnimalsInspections";
            this.cmAnimalsInspections.Size = new System.Drawing.Size(129, 92);
            // 
            // cmUpdate
            // 
            this.cmUpdate.Name = "cmUpdate";
            this.cmUpdate.Size = new System.Drawing.Size(128, 22);
            this.cmUpdate.Text = "Изменить";
            this.cmUpdate.Click += new System.EventHandler(this.cmUpdate_Click);
            // 
            // cmAdd
            // 
            this.cmAdd.Name = "cmAdd";
            this.cmAdd.Size = new System.Drawing.Size(128, 22);
            this.cmAdd.Text = "Добавить";
            this.cmAdd.Click += new System.EventHandler(this.cmAdd_Click);
            // 
            // cmRefresh
            // 
            this.cmRefresh.Name = "cmRefresh";
            this.cmRefresh.Size = new System.Drawing.Size(128, 22);
            this.cmRefresh.Text = "Обновить";
            this.cmRefresh.Click += new System.EventHandler(this.cmRefresh_Click);
            // 
            // cmDelete
            // 
            this.cmDelete.Name = "cmDelete";
            this.cmDelete.Size = new System.Drawing.Size(128, 22);
            this.cmDelete.Text = "Удалить";
            this.cmDelete.Click += new System.EventHandler(this.cmDelete_Click);
            // 
            // tabVaccination
            // 
            this.tabVaccination.Controls.Add(this.dgVaccinations);
            this.tabVaccination.Location = new System.Drawing.Point(4, 22);
            this.tabVaccination.Name = "tabVaccination";
            this.tabVaccination.Size = new System.Drawing.Size(688, 327);
            this.tabVaccination.TabIndex = 3;
            this.tabVaccination.Text = "Журнал прививок";
            this.tabVaccination.UseVisualStyleBackColor = true;
            this.tabVaccination.Enter += new System.EventHandler(this.tabVaccination_Enter);
            // 
            // dgVaccinations
            // 
            this.dgVaccinations.AllowUserToResizeColumns = false;
            this.dgVaccinations.AllowUserToResizeRows = false;
            this.dgVaccinations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgVaccinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVaccinations.ContextMenuStrip = this.cmVaccination;
            this.dgVaccinations.Location = new System.Drawing.Point(5, 5);
            this.dgVaccinations.MultiSelect = false;
            this.dgVaccinations.Name = "dgVaccinations";
            this.dgVaccinations.RowHeadersVisible = false;
            this.dgVaccinations.RowHeadersWidth = 82;
            this.dgVaccinations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgVaccinations.Size = new System.Drawing.Size(678, 317);
            this.dgVaccinations.TabIndex = 0;
            // 
            // cmVaccination
            // 
            this.cmVaccination.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmUpdateVaccination,
            this.cmAddVaccination,
            this.cmRefreshVaccination,
            this.cmRemoveVaccination});
            this.cmVaccination.Name = "cmVaccination";
            this.cmVaccination.Size = new System.Drawing.Size(129, 92);
            // 
            // cmUpdateVaccination
            // 
            this.cmUpdateVaccination.Name = "cmUpdateVaccination";
            this.cmUpdateVaccination.Size = new System.Drawing.Size(128, 22);
            this.cmUpdateVaccination.Text = "Изменить";
            this.cmUpdateVaccination.Click += new System.EventHandler(this.cmUpdateVaccination_Click);
            // 
            // cmAddVaccination
            // 
            this.cmAddVaccination.Name = "cmAddVaccination";
            this.cmAddVaccination.Size = new System.Drawing.Size(128, 22);
            this.cmAddVaccination.Text = "Добавить";
            this.cmAddVaccination.Click += new System.EventHandler(this.cmAddVaccination_Click);
            // 
            // cmRefreshVaccination
            // 
            this.cmRefreshVaccination.Name = "cmRefreshVaccination";
            this.cmRefreshVaccination.Size = new System.Drawing.Size(128, 22);
            this.cmRefreshVaccination.Text = "Обновить";
            this.cmRefreshVaccination.Click += new System.EventHandler(this.cmRefreshVaccination_Click);
            // 
            // cmRemoveVaccination
            // 
            this.cmRemoveVaccination.Name = "cmRemoveVaccination";
            this.cmRemoveVaccination.Size = new System.Drawing.Size(128, 22);
            this.cmRemoveVaccination.Text = "Удалить";
            this.cmRemoveVaccination.Click += new System.EventHandler(this.cmRemoveVaccination_Click);
            // 
            // tabDisease
            // 
            this.tabDisease.Controls.Add(this.dgDisease);
            this.tabDisease.Location = new System.Drawing.Point(4, 22);
            this.tabDisease.Name = "tabDisease";
            this.tabDisease.Size = new System.Drawing.Size(688, 327);
            this.tabDisease.TabIndex = 4;
            this.tabDisease.Text = "Болезни";
            this.tabDisease.UseVisualStyleBackColor = true;
            this.tabDisease.Enter += new System.EventHandler(this.tabDisease_Enter);
            // 
            // dgDisease
            // 
            this.dgDisease.AllowUserToResizeColumns = false;
            this.dgDisease.AllowUserToResizeRows = false;
            this.dgDisease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisease.ContextMenuStrip = this.cmDisease;
            this.dgDisease.Location = new System.Drawing.Point(5, 5);
            this.dgDisease.MultiSelect = false;
            this.dgDisease.Name = "dgDisease";
            this.dgDisease.RowHeadersVisible = false;
            this.dgDisease.RowHeadersWidth = 82;
            this.dgDisease.Size = new System.Drawing.Size(678, 317);
            this.dgDisease.TabIndex = 0;
            // 
            // cmDisease
            // 
            this.cmDisease.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmUpdateDisease,
            this.cmAddDisease,
            this.cmRefreshDisease,
            this.cmDeleteDisease});
            this.cmDisease.Name = "cmDisease";
            this.cmDisease.Size = new System.Drawing.Size(144, 92);
            // 
            // cmUpdateDisease
            // 
            this.cmUpdateDisease.Name = "cmUpdateDisease";
            this.cmUpdateDisease.Size = new System.Drawing.Size(143, 22);
            this.cmUpdateDisease.Text = "Изменить";
            this.cmUpdateDisease.Click += new System.EventHandler(this.cmUpdateDisease_Click);
            // 
            // cmAddDisease
            // 
            this.cmAddDisease.Name = "cmAddDisease";
            this.cmAddDisease.Size = new System.Drawing.Size(143, 22);
            this.cmAddDisease.Text = "Добавить";
            this.cmAddDisease.Click += new System.EventHandler(this.cmAddDisease_Click);
            // 
            // cmRefreshDisease
            // 
            this.cmRefreshDisease.Name = "cmRefreshDisease";
            this.cmRefreshDisease.Size = new System.Drawing.Size(143, 22);
            this.cmRefreshDisease.Text = "Обновление";
            this.cmRefreshDisease.Click += new System.EventHandler(this.cmRefreshDisease_Click);
            // 
            // cmDeleteDisease
            // 
            this.cmDeleteDisease.Name = "cmDeleteDisease";
            this.cmDeleteDisease.Size = new System.Drawing.Size(143, 22);
            this.cmDeleteDisease.Text = "Удалить";
            this.cmDeleteDisease.Click += new System.EventHandler(this.cmDeleteDisease_Click);
            // 
            // tabAviaryCheck
            // 
            this.tabAviaryCheck.Controls.Add(this.dgAviaryCheck);
            this.tabAviaryCheck.Location = new System.Drawing.Point(4, 22);
            this.tabAviaryCheck.Name = "tabAviaryCheck";
            this.tabAviaryCheck.Size = new System.Drawing.Size(688, 327);
            this.tabAviaryCheck.TabIndex = 5;
            this.tabAviaryCheck.Text = "Проверка вольеров";
            this.tabAviaryCheck.UseVisualStyleBackColor = true;
            this.tabAviaryCheck.Enter += new System.EventHandler(this.tabAviaryCheck_Enter);
            // 
            // dgAviaryCheck
            // 
            this.dgAviaryCheck.AllowUserToResizeColumns = false;
            this.dgAviaryCheck.AllowUserToResizeRows = false;
            this.dgAviaryCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAviaryCheck.ContextMenuStrip = this.cmAviaryCheck;
            this.dgAviaryCheck.Location = new System.Drawing.Point(5, 5);
            this.dgAviaryCheck.MultiSelect = false;
            this.dgAviaryCheck.Name = "dgAviaryCheck";
            this.dgAviaryCheck.RowHeadersVisible = false;
            this.dgAviaryCheck.RowHeadersWidth = 82;
            this.dgAviaryCheck.Size = new System.Drawing.Size(678, 317);
            this.dgAviaryCheck.TabIndex = 0;
            // 
            // cmAviaryCheck
            // 
            this.cmAviaryCheck.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmUpdateAviaryCheck,
            this.cmAddAviaryCheck,
            this.cmRefreshAviaryCheck,
            this.cmDeleteAviaryCheck});
            this.cmAviaryCheck.Name = "cmAviaryCheck";
            this.cmAviaryCheck.Size = new System.Drawing.Size(129, 92);
            // 
            // cmUpdateAviaryCheck
            // 
            this.cmUpdateAviaryCheck.Name = "cmUpdateAviaryCheck";
            this.cmUpdateAviaryCheck.Size = new System.Drawing.Size(128, 22);
            this.cmUpdateAviaryCheck.Text = "Изменить";
            this.cmUpdateAviaryCheck.Click += new System.EventHandler(this.cmUpdateAviaryCheck_Click);
            // 
            // cmAddAviaryCheck
            // 
            this.cmAddAviaryCheck.Name = "cmAddAviaryCheck";
            this.cmAddAviaryCheck.Size = new System.Drawing.Size(128, 22);
            this.cmAddAviaryCheck.Text = "Добавить";
            this.cmAddAviaryCheck.Click += new System.EventHandler(this.cmAddAviaryCheck_Click);
            // 
            // cmRefreshAviaryCheck
            // 
            this.cmRefreshAviaryCheck.Name = "cmRefreshAviaryCheck";
            this.cmRefreshAviaryCheck.Size = new System.Drawing.Size(128, 22);
            this.cmRefreshAviaryCheck.Text = "Обновить";
            this.cmRefreshAviaryCheck.Click += new System.EventHandler(this.cmRefreshAviaryCheck_Click);
            // 
            // cmDeleteAviaryCheck
            // 
            this.cmDeleteAviaryCheck.Name = "cmDeleteAviaryCheck";
            this.cmDeleteAviaryCheck.Size = new System.Drawing.Size(128, 22);
            this.cmDeleteAviaryCheck.Text = "Удалить";
            this.cmDeleteAviaryCheck.Click += new System.EventHandler(this.cmDeleteAviaryCheck_Click);
            // 
            // Zoopark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(713, 366);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Zoopark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зоопарк";
            this.Load += new System.EventHandler(this.Zoopark_Load);
            this.tabControl.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            this.cmEmployee.ResumeLayout(false);
            this.tabAnimals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimals)).EndInit();
            this.cmAnimals.ResumeLayout(false);
            this.tabAnimalsInspection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimalsInspections)).EndInit();
            this.cmAnimalsInspections.ResumeLayout(false);
            this.tabVaccination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVaccinations)).EndInit();
            this.cmVaccination.ResumeLayout(false);
            this.tabDisease.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDisease)).EndInit();
            this.cmDisease.ResumeLayout(false);
            this.tabAviaryCheck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAviaryCheck)).EndInit();
            this.cmAviaryCheck.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabAnimals;
        private System.Windows.Forms.TabPage tabAnimalsInspection;
        private System.Windows.Forms.TabPage tabVaccination;
        private System.Windows.Forms.TabPage tabDisease;
        private System.Windows.Forms.TabPage tabAviaryCheck;
        private System.Windows.Forms.DataGridView dgEmployee;
        private System.Windows.Forms.DataGridView dgAnimals;
        private System.Windows.Forms.DataGridView dgAnimalsInspections;
        private System.Windows.Forms.DataGridView dgVaccinations;
        private System.Windows.Forms.DataGridView dgDisease;
        private System.Windows.Forms.DataGridView dgAviaryCheck;
        private System.Windows.Forms.ContextMenuStrip cmEmployee;
        private System.Windows.Forms.ToolStripMenuItem cmUpdateEmployee;
        private System.Windows.Forms.ToolStripMenuItem cmAddEmployee;
        private System.Windows.Forms.ToolStripMenuItem cmRefreshEmployee;
        private System.Windows.Forms.ToolStripMenuItem cmDeleteEmployee;
        private System.Windows.Forms.ToolStripMenuItem cmInfo;
        private System.Windows.Forms.ContextMenuStrip cmAnimals;
        private System.Windows.Forms.ToolStripMenuItem cmUpdateAnimal;
        private System.Windows.Forms.ToolStripMenuItem cmAddAnimal;
        private System.Windows.Forms.ToolStripMenuItem cmDeleteAnimal;
        private System.Windows.Forms.ToolStripMenuItem cmRefreshAnimal;
        private System.Windows.Forms.ToolStripMenuItem cmInfoAnimal;
        private System.Windows.Forms.ContextMenuStrip cmAnimalsInspections;
        private System.Windows.Forms.ToolStripMenuItem cmUpdate;
        private System.Windows.Forms.ToolStripMenuItem cmAdd;
        private System.Windows.Forms.ToolStripMenuItem cmRefresh;
        private System.Windows.Forms.ToolStripMenuItem cmDelete;
        private System.Windows.Forms.ContextMenuStrip cmVaccination;
        private System.Windows.Forms.ToolStripMenuItem cmUpdateVaccination;
        private System.Windows.Forms.ToolStripMenuItem cmAddVaccination;
        private System.Windows.Forms.ToolStripMenuItem cmRefreshVaccination;
        private System.Windows.Forms.ToolStripMenuItem cmRemoveVaccination;
        private System.Windows.Forms.ContextMenuStrip cmDisease;
        private System.Windows.Forms.ToolStripMenuItem cmUpdateDisease;
        private System.Windows.Forms.ToolStripMenuItem cmAddDisease;
        private System.Windows.Forms.ToolStripMenuItem cmRefreshDisease;
        private System.Windows.Forms.ToolStripMenuItem cmDeleteDisease;
        private System.Windows.Forms.ContextMenuStrip cmAviaryCheck;
        private System.Windows.Forms.ToolStripMenuItem cmUpdateAviaryCheck;
        private System.Windows.Forms.ToolStripMenuItem cmAddAviaryCheck;
        private System.Windows.Forms.ToolStripMenuItem cmRefreshAviaryCheck;
        private System.Windows.Forms.ToolStripMenuItem cmDeleteAviaryCheck;
    }
}

