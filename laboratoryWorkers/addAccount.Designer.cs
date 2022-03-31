namespace laboratoryWorkers
{
    partial class addAccount
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassord = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.comboBoxUpdateWorker = new System.Windows.Forms.ComboBox();
            this.comboBoxInsertDel = new System.Windows.Forms.ComboBox();
            this.labelInsertDel = new System.Windows.Forms.Label();
            this.comboBoxDictionary = new System.Windows.Forms.ComboBox();
            this.labelDictionary = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(24, 55);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(47, 16);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логин:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(246, 60);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(144, 22);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxPassord
            // 
            this.textBoxPassord.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassord.Location = new System.Drawing.Point(246, 88);
            this.textBoxPassord.Name = "textBoxPassord";
            this.textBoxPassord.Size = new System.Drawing.Size(144, 22);
            this.textBoxPassord.TabIndex = 2;
            this.textBoxPassord.TextChanged += new System.EventHandler(this.textBoxPassord_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(24, 86);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 16);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUpdate.Location = new System.Drawing.Point(24, 116);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(156, 16);
            this.labelUpdate.TabIndex = 4;
            this.labelUpdate.Text = "Обновление работников:";
            // 
            // comboBoxUpdateWorker
            // 
            this.comboBoxUpdateWorker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxUpdateWorker.FormattingEnabled = true;
            this.comboBoxUpdateWorker.Location = new System.Drawing.Point(246, 116);
            this.comboBoxUpdateWorker.Name = "comboBoxUpdateWorker";
            this.comboBoxUpdateWorker.Size = new System.Drawing.Size(144, 24);
            this.comboBoxUpdateWorker.TabIndex = 5;
            this.comboBoxUpdateWorker.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdateWorker_SelectedIndexChanged);
            // 
            // comboBoxInsertDel
            // 
            this.comboBoxInsertDel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxInsertDel.FormattingEnabled = true;
            this.comboBoxInsertDel.Location = new System.Drawing.Point(246, 144);
            this.comboBoxInsertDel.Name = "comboBoxInsertDel";
            this.comboBoxInsertDel.Size = new System.Drawing.Size(144, 24);
            this.comboBoxInsertDel.TabIndex = 6;
            this.comboBoxInsertDel.SelectedIndexChanged += new System.EventHandler(this.comboBoxInsertDel_SelectedIndexChanged);
            // 
            // labelInsertDel
            // 
            this.labelInsertDel.AutoSize = true;
            this.labelInsertDel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInsertDel.Location = new System.Drawing.Point(24, 144);
            this.labelInsertDel.Name = "labelInsertDel";
            this.labelInsertDel.Size = new System.Drawing.Size(216, 16);
            this.labelInsertDel.TabIndex = 7;
            this.labelInsertDel.Text = "Добавление/удаление работников:";
            // 
            // comboBoxDictionary
            // 
            this.comboBoxDictionary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDictionary.FormattingEnabled = true;
            this.comboBoxDictionary.Location = new System.Drawing.Point(246, 174);
            this.comboBoxDictionary.Name = "comboBoxDictionary";
            this.comboBoxDictionary.Size = new System.Drawing.Size(144, 24);
            this.comboBoxDictionary.TabIndex = 8;
            this.comboBoxDictionary.SelectedIndexChanged += new System.EventHandler(this.comboBoxDictionary_SelectedIndexChanged);
            // 
            // labelDictionary
            // 
            this.labelDictionary.AutoSize = true;
            this.labelDictionary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDictionary.Location = new System.Drawing.Point(24, 174);
            this.labelDictionary.Name = "labelDictionary";
            this.labelDictionary.Size = new System.Drawing.Size(141, 16);
            this.labelDictionary.TabIndex = 9;
            this.labelDictionary.Text = "Работа со словарями:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(130, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(50, 18);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "label1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(296, 231);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 35);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Применить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(196, 231);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(94, 35);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // addAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 282);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelDictionary);
            this.Controls.Add(this.comboBoxDictionary);
            this.Controls.Add(this.labelInsertDel);
            this.Controls.Add(this.comboBoxInsertDel);
            this.Controls.Add(this.comboBoxUpdateWorker);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassord);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Name = "addAccount";
            this.Text = "addAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassord;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.ComboBox comboBoxUpdateWorker;
        private System.Windows.Forms.ComboBox comboBoxInsertDel;
        private System.Windows.Forms.Label labelInsertDel;
        private System.Windows.Forms.ComboBox comboBoxDictionary;
        private System.Windows.Forms.Label labelDictionary;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClose;
    }
}