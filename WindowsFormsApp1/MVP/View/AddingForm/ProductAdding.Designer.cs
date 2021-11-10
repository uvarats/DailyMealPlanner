
namespace WindowsFormsApp1.MVP.View
{
    partial class ProductAdding
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
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grammsField = new System.Windows.Forms.TextBox();
            this.proteinField = new System.Windows.Forms.NumericUpDown();
            this.fatsField = new System.Windows.Forms.NumericUpDown();
            this.carbsField = new System.Windows.Forms.NumericUpDown();
            this.caloriesField = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proteinField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesField)).BeginInit();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(91, 19);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(195, 20);
            this.nameField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gramms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Protein";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Carbs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Calories";
            // 
            // grammsField
            // 
            this.grammsField.Location = new System.Drawing.Point(91, 49);
            this.grammsField.MaxLength = 7;
            this.grammsField.Name = "grammsField";
            this.grammsField.Size = new System.Drawing.Size(195, 20);
            this.grammsField.TabIndex = 7;
            this.grammsField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grammsField_KeyPress);
            // 
            // proteinField
            // 
            this.proteinField.Location = new System.Drawing.Point(91, 79);
            this.proteinField.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.proteinField.Name = "proteinField";
            this.proteinField.Size = new System.Drawing.Size(195, 20);
            this.proteinField.TabIndex = 8;
            // 
            // fatsField
            // 
            this.fatsField.Location = new System.Drawing.Point(91, 109);
            this.fatsField.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fatsField.Name = "fatsField";
            this.fatsField.Size = new System.Drawing.Size(195, 20);
            this.fatsField.TabIndex = 9;
            // 
            // carbsField
            // 
            this.carbsField.Location = new System.Drawing.Point(91, 139);
            this.carbsField.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.carbsField.Name = "carbsField";
            this.carbsField.Size = new System.Drawing.Size(195, 20);
            this.carbsField.TabIndex = 10;
            // 
            // caloriesField
            // 
            this.caloriesField.Location = new System.Drawing.Point(91, 169);
            this.caloriesField.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.caloriesField.Name = "caloriesField";
            this.caloriesField.Size = new System.Drawing.Size(195, 20);
            this.caloriesField.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(110, 195);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ProductAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 248);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.caloriesField);
            this.Controls.Add(this.carbsField);
            this.Controls.Add(this.fatsField);
            this.Controls.Add(this.proteinField);
            this.Controls.Add(this.grammsField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductAdding";
            this.Text = "ProductAdding";
            this.Load += new System.EventHandler(this.ProductAdding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proteinField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox grammsField;
        private System.Windows.Forms.NumericUpDown proteinField;
        private System.Windows.Forms.NumericUpDown fatsField;
        private System.Windows.Forms.NumericUpDown carbsField;
        private System.Windows.Forms.NumericUpDown caloriesField;
        private System.Windows.Forms.Button addButton;
    }
}