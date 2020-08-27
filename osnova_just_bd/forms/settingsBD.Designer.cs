namespace osnova_just_bd.forms
{
    partial class settingsBD
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminpass = new System.Windows.Forms.TextBox();
            this.but_auth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.userid = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.database = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.but_auth);
            this.panel1.Controls.Add(this.adminpass);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 127);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // adminpass
            // 
            this.adminpass.Location = new System.Drawing.Point(9, 52);
            this.adminpass.Name = "adminpass";
            this.adminpass.Size = new System.Drawing.Size(293, 20);
            this.adminpass.TabIndex = 0;
            // 
            // but_auth
            // 
            this.but_auth.Location = new System.Drawing.Point(106, 78);
            this.but_auth.Name = "but_auth";
            this.but_auth.Size = new System.Drawing.Size(75, 23);
            this.but_auth.TabIndex = 1;
            this.but_auth.Text = "CHECK";
            this.but_auth.UseVisualStyleBackColor = true;
            this.but_auth.Click += new System.EventHandler(this.but_auth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ВВЕДИТЕ ПАРОЛЬ АДМИНИСТРАТОРА";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(12, 12);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(310, 20);
            this.server.TabIndex = 1;
            this.server.Text = "Сервер";
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(12, 38);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(310, 20);
            this.userid.TabIndex = 2;
            this.userid.Text = "Пользователь БД";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(12, 64);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(310, 20);
            this.pass.TabIndex = 3;
            this.pass.Text = "Пароль";
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(12, 90);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(310, 20);
            this.database.TabIndex = 4;
            this.database.Text = "Название базы данных";
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(12, 116);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(307, 23);
            this.save.TabIndex = 5;
            this.save.Text = "Сохранить настройки";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // settingsBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 149);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.database);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.server);
            this.Name = "settingsBD";
            this.Text = "Настройки подключения";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_auth;
        private System.Windows.Forms.TextBox adminpass;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.Button save;
    }
}