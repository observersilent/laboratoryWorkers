namespace laboratoryWorkers
{
    partial class addWindow
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
            this.comboBoxAcademicDegree = new System.Windows.Forms.ComboBox();
            this.labelAcademicDegree = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.comboBoxFamilyStatus = new System.Windows.Forms.ComboBox();
            this.labelFamilyStatus = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxHaveChildren = new System.Windows.Forms.ComboBox();
            this.labelHaveChildren = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.maskedTextBoxName = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSurname = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxMiddleName = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // comboBoxAcademicDegree
            // 
            this.comboBoxAcademicDegree.FormattingEnabled = true;
            this.comboBoxAcademicDegree.Location = new System.Drawing.Point(165, 266);
            this.comboBoxAcademicDegree.Name = "comboBoxAcademicDegree";
            this.comboBoxAcademicDegree.Size = new System.Drawing.Size(182, 21);
            this.comboBoxAcademicDegree.TabIndex = 41;
            this.comboBoxAcademicDegree.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcademicDegree_SelectedIndexChanged);
            // 
            // labelAcademicDegree
            // 
            this.labelAcademicDegree.AutoSize = true;
            this.labelAcademicDegree.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAcademicDegree.Location = new System.Drawing.Point(18, 266);
            this.labelAcademicDegree.Name = "labelAcademicDegree";
            this.labelAcademicDegree.Size = new System.Drawing.Size(106, 16);
            this.labelAcademicDegree.TabIndex = 40;
            this.labelAcademicDegree.Text = "Ученая степень:";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(165, 239);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(182, 21);
            this.comboBoxPosition.TabIndex = 39;
            this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosition_SelectedIndexChanged);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosition.Location = new System.Drawing.Point(18, 239);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(77, 16);
            this.labelPosition.TabIndex = 38;
            this.labelPosition.Text = "Должность:";
            // 
            // comboBoxFamilyStatus
            // 
            this.comboBoxFamilyStatus.FormattingEnabled = true;
            this.comboBoxFamilyStatus.Location = new System.Drawing.Point(165, 212);
            this.comboBoxFamilyStatus.Name = "comboBoxFamilyStatus";
            this.comboBoxFamilyStatus.Size = new System.Drawing.Size(182, 21);
            this.comboBoxFamilyStatus.TabIndex = 37;
            this.comboBoxFamilyStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxFamilyStatus_SelectedIndexChanged);
            // 
            // labelFamilyStatus
            // 
            this.labelFamilyStatus.AutoSize = true;
            this.labelFamilyStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFamilyStatus.Location = new System.Drawing.Point(18, 212);
            this.labelFamilyStatus.Name = "labelFamilyStatus";
            this.labelFamilyStatus.Size = new System.Drawing.Size(141, 16);
            this.labelFamilyStatus.TabIndex = 36;
            this.labelFamilyStatus.Text = "Семейное положение:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(165, 185);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(182, 21);
            this.comboBoxGender.TabIndex = 35;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(18, 185);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(35, 16);
            this.labelGender.TabIndex = 34;
            this.labelGender.Text = "Пол:";
            // 
            // comboBoxHaveChildren
            // 
            this.comboBoxHaveChildren.FormattingEnabled = true;
            this.comboBoxHaveChildren.Location = new System.Drawing.Point(165, 158);
            this.comboBoxHaveChildren.Name = "comboBoxHaveChildren";
            this.comboBoxHaveChildren.Size = new System.Drawing.Size(182, 21);
            this.comboBoxHaveChildren.TabIndex = 33;
            this.comboBoxHaveChildren.SelectedIndexChanged += new System.EventHandler(this.comboBoxHaveChildren_SelectedIndexChanged);
            // 
            // labelHaveChildren
            // 
            this.labelHaveChildren.AutoSize = true;
            this.labelHaveChildren.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHaveChildren.Location = new System.Drawing.Point(16, 158);
            this.labelHaveChildren.Name = "labelHaveChildren";
            this.labelHaveChildren.Size = new System.Drawing.Size(87, 16);
            this.labelHaveChildren.TabIndex = 32;
            this.labelHaveChildren.Text = "Имеет детей:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthday.Location = new System.Drawing.Point(18, 132);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(105, 16);
            this.labelBirthday.TabIndex = 31;
            this.labelBirthday.Text = "День рождения:";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.CustomFormat = "";
            this.dateTimePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(165, 132);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.ShowCheckBox = true;
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(182, 20);
            this.dateTimePickerBirthday.TabIndex = 30;
            this.dateTimePickerBirthday.ValueChanged += new System.EventHandler(this.dateTimePickerBirthday_ValueChanged);
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(18, 104);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(67, 16);
            this.labelMiddleName.TabIndex = 29;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(18, 76);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 16);
            this.labelSurname.TabIndex = 27;
            this.labelSurname.Text = "Фамилия:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(256, 293);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 30);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Применить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(159, 293);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(91, 30);
            this.buttonClose.TabIndex = 24;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(18, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 16);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Имя:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(91, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(180, 22);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "Добавление записи";
            // 
            // maskedTextBoxName
            // 
            this.maskedTextBoxName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxName.Location = new System.Drawing.Point(165, 48);
            this.maskedTextBoxName.Mask = "L????????????????????????????????????????????";
            this.maskedTextBoxName.Name = "maskedTextBoxName";
            this.maskedTextBoxName.Size = new System.Drawing.Size(182, 22);
            this.maskedTextBoxName.TabIndex = 42;
            this.maskedTextBoxName.TextChanged += new System.EventHandler(this.maskedTextBoxName_TextChanged);
            // 
            // maskedTextBoxSurname
            // 
            this.maskedTextBoxSurname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxSurname.Location = new System.Drawing.Point(165, 76);
            this.maskedTextBoxSurname.Mask = "L????????????????????????????????????????????";
            this.maskedTextBoxSurname.Name = "maskedTextBoxSurname";
            this.maskedTextBoxSurname.Size = new System.Drawing.Size(182, 22);
            this.maskedTextBoxSurname.TabIndex = 43;
            this.maskedTextBoxSurname.TextChanged += new System.EventHandler(this.maskedTextBoxSurname_TextChanged);
            // 
            // maskedTextBoxMiddleName
            // 
            this.maskedTextBoxMiddleName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxMiddleName.Location = new System.Drawing.Point(165, 104);
            this.maskedTextBoxMiddleName.Mask = "L????????????????????????????????????????????";
            this.maskedTextBoxMiddleName.Name = "maskedTextBoxMiddleName";
            this.maskedTextBoxMiddleName.Size = new System.Drawing.Size(182, 22);
            this.maskedTextBoxMiddleName.TabIndex = 44;
            this.maskedTextBoxMiddleName.TextChanged += new System.EventHandler(this.maskedTextBoxMiddleName_TextChanged);
            // 
            // addWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 340);
            this.Controls.Add(this.maskedTextBoxMiddleName);
            this.Controls.Add(this.maskedTextBoxSurname);
            this.Controls.Add(this.maskedTextBoxName);
            this.Controls.Add(this.comboBoxAcademicDegree);
            this.Controls.Add(this.labelAcademicDegree);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.comboBoxFamilyStatus);
            this.Controls.Add(this.labelFamilyStatus);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxHaveChildren);
            this.Controls.Add(this.labelHaveChildren);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.Name = "addWindow";
            this.Text = "addWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAcademicDegree;
        private System.Windows.Forms.Label labelAcademicDegree;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ComboBox comboBoxFamilyStatus;
        private System.Windows.Forms.Label labelFamilyStatus;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxHaveChildren;
        private System.Windows.Forms.Label labelHaveChildren;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSurname;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMiddleName;
    }
}