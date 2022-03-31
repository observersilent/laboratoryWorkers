namespace laboratoryWorkers
{
    partial class selectDictionary
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
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonAcademicDegree = new System.Windows.Forms.Button();
            this.buttonFamilyStatus = new System.Windows.Forms.Button();
            this.buttonGender = new System.Windows.Forms.Button();
            this.buttonPosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAccount
            // 
            this.buttonAccount.Location = new System.Drawing.Point(12, 12);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(203, 37);
            this.buttonAccount.TabIndex = 0;
            this.buttonAccount.Text = "Учетные записи";
            this.buttonAccount.UseVisualStyleBackColor = true;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonAcademicDegree
            // 
            this.buttonAcademicDegree.Location = new System.Drawing.Point(12, 55);
            this.buttonAcademicDegree.Name = "buttonAcademicDegree";
            this.buttonAcademicDegree.Size = new System.Drawing.Size(203, 37);
            this.buttonAcademicDegree.TabIndex = 1;
            this.buttonAcademicDegree.Text = "Ученые степени";
            this.buttonAcademicDegree.UseVisualStyleBackColor = true;
            this.buttonAcademicDegree.Click += new System.EventHandler(this.buttonAcademicDegree_Click);
            // 
            // buttonFamilyStatus
            // 
            this.buttonFamilyStatus.Location = new System.Drawing.Point(12, 98);
            this.buttonFamilyStatus.Name = "buttonFamilyStatus";
            this.buttonFamilyStatus.Size = new System.Drawing.Size(203, 37);
            this.buttonFamilyStatus.TabIndex = 2;
            this.buttonFamilyStatus.Text = "Семейные положения";
            this.buttonFamilyStatus.UseVisualStyleBackColor = true;
            this.buttonFamilyStatus.Click += new System.EventHandler(this.buttonFamilyStatus_Click);
            // 
            // buttonGender
            // 
            this.buttonGender.Location = new System.Drawing.Point(12, 141);
            this.buttonGender.Name = "buttonGender";
            this.buttonGender.Size = new System.Drawing.Size(203, 37);
            this.buttonGender.TabIndex = 3;
            this.buttonGender.Text = "Пол";
            this.buttonGender.UseVisualStyleBackColor = true;
            this.buttonGender.Click += new System.EventHandler(this.buttonGender_Click);
            // 
            // buttonPosition
            // 
            this.buttonPosition.Location = new System.Drawing.Point(12, 184);
            this.buttonPosition.Name = "buttonPosition";
            this.buttonPosition.Size = new System.Drawing.Size(203, 37);
            this.buttonPosition.TabIndex = 4;
            this.buttonPosition.Text = "Должности";
            this.buttonPosition.UseVisualStyleBackColor = true;
            this.buttonPosition.Click += new System.EventHandler(this.buttonPosition_Click);
            // 
            // selectDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 237);
            this.Controls.Add(this.buttonPosition);
            this.Controls.Add(this.buttonGender);
            this.Controls.Add(this.buttonFamilyStatus);
            this.Controls.Add(this.buttonAcademicDegree);
            this.Controls.Add(this.buttonAccount);
            this.Name = "selectDictionary";
            this.Text = "Выбор словаря";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonAcademicDegree;
        private System.Windows.Forms.Button buttonFamilyStatus;
        private System.Windows.Forms.Button buttonGender;
        private System.Windows.Forms.Button buttonPosition;
    }
}