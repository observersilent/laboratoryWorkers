﻿namespace laboratoryWorkers
{
    partial class autorizForm
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelAutorizStatus = new System.Windows.Forms.Label();
            this.labelForReview = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(20, 43);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(137, 22);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Введите логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(20, 88);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(151, 22);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Введите пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(207, 43);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(177, 29);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(207, 88);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(177, 29);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelAutorizStatus
            // 
            this.labelAutorizStatus.AutoSize = true;
            this.labelAutorizStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutorizStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAutorizStatus.Location = new System.Drawing.Point(27, 135);
            this.labelAutorizStatus.Name = "labelAutorizStatus";
            this.labelAutorizStatus.Size = new System.Drawing.Size(0, 16);
            this.labelAutorizStatus.TabIndex = 4;
            // 
            // labelForReview
            // 
            this.labelForReview.AutoSize = true;
            this.labelForReview.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForReview.ForeColor = System.Drawing.Color.Red;
            this.labelForReview.Location = new System.Drawing.Point(21, 9);
            this.labelForReview.Name = "labelForReview";
            this.labelForReview.Size = new System.Drawing.Size(289, 16);
            this.labelForReview.TabIndex = 5;
            this.labelForReview.Text = "Для тестирования! Логин: admin, пароль:admin";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(297, 135);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(87, 30);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Подключится";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // autorizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 182);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelForReview);
            this.Controls.Add(this.labelAutorizStatus);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Name = "autorizForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelAutorizStatus;
        private System.Windows.Forms.Label labelForReview;
        private System.Windows.Forms.Button buttonConnect;
    }
}

