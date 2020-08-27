namespace osnova_just_bd.forms
{
    partial class usersForm
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
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.but_add = new System.Windows.Forms.Button();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_dell = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.MainGrid.Location = new System.Drawing.Point(12, 118);
            this.MainGrid.MultiSelect = false;
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(478, 150);
            this.MainGrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Login";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Pass";
            this.Column3.Name = "Column3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_edit);
            this.groupBox1.Controls.Add(this.but_add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_pass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_login);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поля";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(89, 13);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(100, 20);
            this.tb_login.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(89, 42);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(100, 20);
            this.tb_pass.TabIndex = 2;
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(6, 71);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 23);
            this.but_add.TabIndex = 4;
            this.but_add.Text = "Добавить";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_edit
            // 
            this.but_edit.Location = new System.Drawing.Point(89, 71);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(100, 23);
            this.but_edit.TabIndex = 5;
            this.but_edit.Text = "Редактировать";
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // but_dell
            // 
            this.but_dell.Location = new System.Drawing.Point(213, 83);
            this.but_dell.Name = "but_dell";
            this.but_dell.Size = new System.Drawing.Size(277, 23);
            this.but_dell.TabIndex = 2;
            this.but_dell.Text = "Удалить";
            this.but_dell.UseVisualStyleBackColor = true;
            this.but_dell.Click += new System.EventHandler(this.but_dell_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(12, 274);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(478, 20);
            this.tb_Search.TabIndex = 3;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // usersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 305);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.but_dell);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainGrid);
            this.Name = "usersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Button but_dell;
        private System.Windows.Forms.TextBox tb_Search;
    }
}