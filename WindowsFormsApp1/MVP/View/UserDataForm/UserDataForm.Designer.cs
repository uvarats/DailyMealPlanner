
namespace WindowsFormsApp1.MVP.View
{
    partial class UserDataForm
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
            this.weightField = new System.Windows.Forms.TextBox();
            this.heightField = new System.Windows.Forms.TextBox();
            this.ageField = new System.Windows.Forms.TextBox();
            this.activityBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.dcrLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // weightField
            // 
            this.weightField.Location = new System.Drawing.Point(78, 27);
            this.weightField.Margin = new System.Windows.Forms.Padding(2);
            this.weightField.MaxLength = 3;
            this.weightField.Name = "weightField";
            this.weightField.Size = new System.Drawing.Size(122, 20);
            this.weightField.TabIndex = 0;
            this.weightField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightField_KeyPress);
            // 
            // heightField
            // 
            this.heightField.Location = new System.Drawing.Point(78, 50);
            this.heightField.Margin = new System.Windows.Forms.Padding(2);
            this.heightField.MaxLength = 3;
            this.heightField.Name = "heightField";
            this.heightField.Size = new System.Drawing.Size(122, 20);
            this.heightField.TabIndex = 1;
            // 
            // ageField
            // 
            this.ageField.Location = new System.Drawing.Point(78, 72);
            this.ageField.Margin = new System.Windows.Forms.Padding(2);
            this.ageField.MaxLength = 3;
            this.ageField.Name = "ageField";
            this.ageField.Size = new System.Drawing.Size(122, 20);
            this.ageField.TabIndex = 2;
            this.ageField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightField_KeyPress);
            // 
            // activityBox
            // 
            this.activityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityBox.FormattingEnabled = true;
            this.activityBox.Location = new System.Drawing.Point(78, 96);
            this.activityBox.Margin = new System.Windows.Forms.Padding(2);
            this.activityBox.Name = "activityBox";
            this.activityBox.Size = new System.Drawing.Size(122, 21);
            this.activityBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Daily activity";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(9, 127);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(128, 13);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "Current daily calories rate:";
            // 
            // dcrLabel
            // 
            this.dcrLabel.AutoSize = true;
            this.dcrLabel.Location = new System.Drawing.Point(143, 127);
            this.dcrLabel.Name = "dcrLabel";
            this.dcrLabel.Size = new System.Drawing.Size(0, 13);
            this.dcrLabel.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(68, 160);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Exit";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "All changes are saved automatically.";
            // 
            // UserDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 195);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dcrLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activityBox);
            this.Controls.Add(this.ageField);
            this.Controls.Add(this.heightField);
            this.Controls.Add(this.weightField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserDataForm";
            this.Text = "Input user data";
            this.Load += new System.EventHandler(this.UserDataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox weightField;
        private System.Windows.Forms.TextBox heightField;
        private System.Windows.Forms.TextBox ageField;
        private System.Windows.Forms.ComboBox activityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label dcrLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
    }
}