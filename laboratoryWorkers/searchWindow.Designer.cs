namespace laboratoryWorkers
{
    partial class searchWindow
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelHaveChildren = new System.Windows.Forms.Label();
            this.comboBoxHaveChildren = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelFamilyStatus = new System.Windows.Forms.Label();
            this.comboBoxFamilyStatus = new System.Windows.Forms.ComboBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.labelAcademicDegree = new System.Windows.Forms.Label();
            this.comboBoxAcademicDegree = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(62, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(256, 22);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Установите критерии поиска";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(172, 53);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(182, 22);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(25, 53);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 16);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(166, 298);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(91, 30);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(263, 298);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(91, 30);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Применить";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(172, 81);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(182, 22);
            this.textBoxSurname.TabIndex = 5;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(25, 81);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 16);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "Фамилия:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMiddleName.Location = new System.Drawing.Point(172, 109);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(182, 22);
            this.textBoxMiddleName.TabIndex = 7;
            this.textBoxMiddleName.TextChanged += new System.EventHandler(this.textBoxMiddleName_TextChanged);
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleName.Location = new System.Drawing.Point(25, 109);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(67, 16);
            this.labelMiddleName.TabIndex = 8;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.CustomFormat = "";
            this.dateTimePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(172, 137);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.ShowCheckBox = true;
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(182, 20);
            this.dateTimePickerBirthday.TabIndex = 9;
            this.dateTimePickerBirthday.CloseUp += new System.EventHandler(this.dateTimePickerBirthday_CloseUp);
            this.dateTimePickerBirthday.ValueChanged += new System.EventHandler(this.dateTimePickerBirthday_ValueChanged);
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthday.Location = new System.Drawing.Point(25, 137);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(105, 16);
            this.labelBirthday.TabIndex = 10;
            this.labelBirthday.Text = "День рождения:";
            // 
            // labelHaveChildren
            // 
            this.labelHaveChildren.AutoSize = true;
            this.labelHaveChildren.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHaveChildren.Location = new System.Drawing.Point(23, 163);
            this.labelHaveChildren.Name = "labelHaveChildren";
            this.labelHaveChildren.Size = new System.Drawing.Size(87, 16);
            this.labelHaveChildren.TabIndex = 11;
            this.labelHaveChildren.Text = "Имеет детей:";
            // 
            // comboBoxHaveChildren
            // 
            this.comboBoxHaveChildren.FormattingEnabled = true;
            this.comboBoxHaveChildren.Location = new System.Drawing.Point(172, 163);
            this.comboBoxHaveChildren.Name = "comboBoxHaveChildren";
            this.comboBoxHaveChildren.Size = new System.Drawing.Size(182, 21);
            this.comboBoxHaveChildren.TabIndex = 12;
            this.comboBoxHaveChildren.SelectedIndexChanged += new System.EventHandler(this.comboBoxHaveChildren_SelectedIndexChanged);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(25, 190);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(35, 16);
            this.labelGender.TabIndex = 13;
            this.labelGender.Text = "Пол:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(172, 190);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(182, 21);
            this.comboBoxGender.TabIndex = 14;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // labelFamilyStatus
            // 
            this.labelFamilyStatus.AutoSize = true;
            this.labelFamilyStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFamilyStatus.Location = new System.Drawing.Point(25, 217);
            this.labelFamilyStatus.Name = "labelFamilyStatus";
            this.labelFamilyStatus.Size = new System.Drawing.Size(141, 16);
            this.labelFamilyStatus.TabIndex = 15;
            this.labelFamilyStatus.Text = "Семейное положение:";
            // 
            // comboBoxFamilyStatus
            // 
            this.comboBoxFamilyStatus.FormattingEnabled = true;
            this.comboBoxFamilyStatus.Location = new System.Drawing.Point(172, 217);
            this.comboBoxFamilyStatus.Name = "comboBoxFamilyStatus";
            this.comboBoxFamilyStatus.Size = new System.Drawing.Size(182, 21);
            this.comboBoxFamilyStatus.TabIndex = 16;
            this.comboBoxFamilyStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxFamilyStatus_SelectedIndexChanged);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosition.Location = new System.Drawing.Point(25, 244);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(77, 16);
            this.labelPosition.TabIndex = 17;
            this.labelPosition.Text = "Должность:";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(172, 244);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(182, 21);
            this.comboBoxPosition.TabIndex = 18;
            this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosition_SelectedIndexChanged);
            // 
            // labelAcademicDegree
            // 
            this.labelAcademicDegree.AutoSize = true;
            this.labelAcademicDegree.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAcademicDegree.Location = new System.Drawing.Point(25, 271);
            this.labelAcademicDegree.Name = "labelAcademicDegree";
            this.labelAcademicDegree.Size = new System.Drawing.Size(106, 16);
            this.labelAcademicDegree.TabIndex = 19;
            this.labelAcademicDegree.Text = "Ученая степень:";
            // 
            // comboBoxAcademicDegree
            // 
            this.comboBoxAcademicDegree.FormattingEnabled = true;
            this.comboBoxAcademicDegree.Location = new System.Drawing.Point(172, 271);
            this.comboBoxAcademicDegree.Name = "comboBoxAcademicDegree";
            this.comboBoxAcademicDegree.Size = new System.Drawing.Size(182, 21);
            this.comboBoxAcademicDegree.TabIndex = 20;
            this.comboBoxAcademicDegree.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcademicDegree_SelectedIndexChanged);
            // 
            // searchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 362);
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
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTitle);
            this.Name = "searchWindow";
            this.Text = "searchWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelHaveChildren;
        private System.Windows.Forms.ComboBox comboBoxHaveChildren;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelFamilyStatus;
        private System.Windows.Forms.ComboBox comboBoxFamilyStatus;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label labelAcademicDegree;
        private System.Windows.Forms.ComboBox comboBoxAcademicDegree;
    }
}