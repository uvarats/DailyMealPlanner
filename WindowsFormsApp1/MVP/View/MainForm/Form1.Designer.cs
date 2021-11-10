namespace WindowsFormsApp1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.viewAndEdit = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.caloriesField = new System.Windows.Forms.NumericUpDown();
            this.carbsField = new System.Windows.Forms.NumericUpDown();
            this.fatsField = new System.Windows.Forms.NumericUpDown();
            this.proteinField = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grammsField = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.productsBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.categoriesCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesEdit = new System.Windows.Forms.TabPage();
            this.newCategoryButton = new System.Windows.Forms.Button();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.categoryEditButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.descriptionField = new System.Windows.Forms.TextBox();
            this.categoryName = new System.Windows.Forms.TextBox();
            this.categoriesBox = new System.Windows.Forms.ListBox();
            this.meals = new System.Windows.Forms.TabPage();
            this.categoryCombo2 = new System.Windows.Forms.ComboBox();
            this.addedProducts = new System.Windows.Forms.ListBox();
            this.mealsBox = new System.Windows.Forms.ListBox();
            this.productsBox2 = new System.Windows.Forms.ListBox();
            this.dcrLabel = new System.Windows.Forms.Label();
            this.userDataButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.viewAndEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteinField)).BeginInit();
            this.categoriesEdit.SuspendLayout();
            this.meals.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.viewAndEdit);
            this.tabControl1.Controls.Add(this.categoriesEdit);
            this.tabControl1.Controls.Add(this.meals);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 449);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // viewAndEdit
            // 
            this.viewAndEdit.Controls.Add(this.button3);
            this.viewAndEdit.Controls.Add(this.caloriesField);
            this.viewAndEdit.Controls.Add(this.carbsField);
            this.viewAndEdit.Controls.Add(this.fatsField);
            this.viewAndEdit.Controls.Add(this.proteinField);
            this.viewAndEdit.Controls.Add(this.label8);
            this.viewAndEdit.Controls.Add(this.label7);
            this.viewAndEdit.Controls.Add(this.label6);
            this.viewAndEdit.Controls.Add(this.label5);
            this.viewAndEdit.Controls.Add(this.label4);
            this.viewAndEdit.Controls.Add(this.label3);
            this.viewAndEdit.Controls.Add(this.grammsField);
            this.viewAndEdit.Controls.Add(this.productName);
            this.viewAndEdit.Controls.Add(this.productsBox);
            this.viewAndEdit.Controls.Add(this.button2);
            this.viewAndEdit.Controls.Add(this.label2);
            this.viewAndEdit.Controls.Add(this.textBox1);
            this.viewAndEdit.Controls.Add(this.button1);
            this.viewAndEdit.Controls.Add(this.categoriesCombo);
            this.viewAndEdit.Controls.Add(this.label1);
            this.viewAndEdit.Location = new System.Drawing.Point(4, 25);
            this.viewAndEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewAndEdit.Name = "viewAndEdit";
            this.viewAndEdit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewAndEdit.Size = new System.Drawing.Size(631, 420);
            this.viewAndEdit.TabIndex = 0;
            this.viewAndEdit.Text = "View and edit";
            this.viewAndEdit.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 306);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "Add product";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // caloriesField
            // 
            this.caloriesField.Location = new System.Drawing.Point(399, 224);
            this.caloriesField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.caloriesField.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.caloriesField.Name = "caloriesField";
            this.caloriesField.ReadOnly = true;
            this.caloriesField.Size = new System.Drawing.Size(163, 22);
            this.caloriesField.TabIndex = 23;
            // 
            // carbsField
            // 
            this.carbsField.Location = new System.Drawing.Point(399, 197);
            this.carbsField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carbsField.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.carbsField.Name = "carbsField";
            this.carbsField.ReadOnly = true;
            this.carbsField.Size = new System.Drawing.Size(163, 22);
            this.carbsField.TabIndex = 22;
            // 
            // fatsField
            // 
            this.fatsField.Location = new System.Drawing.Point(399, 169);
            this.fatsField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fatsField.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fatsField.Name = "fatsField";
            this.fatsField.ReadOnly = true;
            this.fatsField.Size = new System.Drawing.Size(163, 22);
            this.fatsField.TabIndex = 21;
            // 
            // proteinField
            // 
            this.proteinField.Location = new System.Drawing.Point(399, 140);
            this.proteinField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proteinField.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.proteinField.Name = "proteinField";
            this.proteinField.ReadOnly = true;
            this.proteinField.Size = new System.Drawing.Size(163, 22);
            this.proteinField.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Calories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Carbs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Protein";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gramms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name";
            // 
            // grammsField
            // 
            this.grammsField.Location = new System.Drawing.Point(399, 114);
            this.grammsField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grammsField.MaxLength = 7;
            this.grammsField.Name = "grammsField";
            this.grammsField.ReadOnly = true;
            this.grammsField.Size = new System.Drawing.Size(167, 22);
            this.grammsField.TabIndex = 9;
            this.grammsField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grammsField_KeyPress);
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(399, 86);
            this.productName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Size = new System.Drawing.Size(167, 22);
            this.productName.TabIndex = 8;
            // 
            // productsBox
            // 
            this.productsBox.FormattingEnabled = true;
            this.productsBox.ItemHeight = 16;
            this.productsBox.Location = new System.Drawing.Point(16, 39);
            this.productsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(277, 260);
            this.productsBox.TabIndex = 7;
            this.productsBox.SelectedIndexChanged += new System.EventHandler(this.productsBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 277);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edit selected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search by name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoriesCombo
            // 
            this.categoriesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriesCombo.FormattingEnabled = true;
            this.categoriesCombo.Location = new System.Drawing.Point(424, 9);
            this.categoriesCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoriesCombo.Name = "categoriesCombo";
            this.categoriesCombo.Size = new System.Drawing.Size(163, 24);
            this.categoriesCombo.TabIndex = 2;
            this.categoriesCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current category";
            // 
            // categoriesEdit
            // 
            this.categoriesEdit.Controls.Add(this.newCategoryButton);
            this.categoriesEdit.Controls.Add(this.deleteCategoryButton);
            this.categoriesEdit.Controls.Add(this.categoryEditButton);
            this.categoriesEdit.Controls.Add(this.label10);
            this.categoriesEdit.Controls.Add(this.label9);
            this.categoriesEdit.Controls.Add(this.descriptionField);
            this.categoriesEdit.Controls.Add(this.categoryName);
            this.categoriesEdit.Controls.Add(this.categoriesBox);
            this.categoriesEdit.Location = new System.Drawing.Point(4, 25);
            this.categoriesEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoriesEdit.Name = "categoriesEdit";
            this.categoriesEdit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoriesEdit.Size = new System.Drawing.Size(631, 420);
            this.categoriesEdit.TabIndex = 1;
            this.categoriesEdit.Text = "Categories edit";
            this.categoriesEdit.UseVisualStyleBackColor = true;
            // 
            // newCategoryButton
            // 
            this.newCategoryButton.Location = new System.Drawing.Point(175, 315);
            this.newCategoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newCategoryButton.Name = "newCategoryButton";
            this.newCategoryButton.Size = new System.Drawing.Size(127, 28);
            this.newCategoryButton.TabIndex = 28;
            this.newCategoryButton.Text = "New Category";
            this.newCategoryButton.UseVisualStyleBackColor = true;
            this.newCategoryButton.Click += new System.EventHandler(this.newCategoryButton_Click);
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(21, 315);
            this.deleteCategoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(125, 28);
            this.deleteCategoryButton.TabIndex = 27;
            this.deleteCategoryButton.Text = "Delete category";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // categoryEditButton
            // 
            this.categoryEditButton.Location = new System.Drawing.Point(416, 186);
            this.categoryEditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryEditButton.Name = "categoryEditButton";
            this.categoryEditButton.Size = new System.Drawing.Size(75, 23);
            this.categoryEditButton.TabIndex = 5;
            this.categoryEditButton.Text = "Edit";
            this.categoryEditButton.UseVisualStyleBackColor = true;
            this.categoryEditButton.Click += new System.EventHandler(this.categoryEditButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Name";
            // 
            // descriptionField
            // 
            this.descriptionField.Location = new System.Drawing.Point(405, 137);
            this.descriptionField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.ReadOnly = true;
            this.descriptionField.Size = new System.Drawing.Size(184, 22);
            this.descriptionField.TabIndex = 2;
            // 
            // categoryName
            // 
            this.categoryName.Location = new System.Drawing.Point(405, 101);
            this.categoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryName.Name = "categoryName";
            this.categoryName.ReadOnly = true;
            this.categoryName.Size = new System.Drawing.Size(184, 22);
            this.categoryName.TabIndex = 1;
            // 
            // categoriesBox
            // 
            this.categoriesBox.FormattingEnabled = true;
            this.categoriesBox.ItemHeight = 16;
            this.categoriesBox.Location = new System.Drawing.Point(17, 16);
            this.categoriesBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoriesBox.Name = "categoriesBox";
            this.categoriesBox.Size = new System.Drawing.Size(285, 292);
            this.categoriesBox.TabIndex = 0;
            this.categoriesBox.SelectedIndexChanged += new System.EventHandler(this.categoriesBox_SelectedIndexChanged);
            // 
            // meals
            // 
            this.meals.Controls.Add(this.categoryCombo2);
            this.meals.Controls.Add(this.addedProducts);
            this.meals.Controls.Add(this.mealsBox);
            this.meals.Controls.Add(this.productsBox2);
            this.meals.Controls.Add(this.dcrLabel);
            this.meals.Controls.Add(this.userDataButton);
            this.meals.Location = new System.Drawing.Point(4, 25);
            this.meals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.meals.Name = "meals";
            this.meals.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.meals.Size = new System.Drawing.Size(631, 420);
            this.meals.TabIndex = 2;
            this.meals.Text = "Meals";
            this.meals.UseVisualStyleBackColor = true;
            // 
            // categoryCombo2
            // 
            this.categoryCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCombo2.FormattingEnabled = true;
            this.categoryCombo2.Location = new System.Drawing.Point(179, 6);
            this.categoryCombo2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoryCombo2.Name = "categoryCombo2";
            this.categoryCombo2.Size = new System.Drawing.Size(105, 24);
            this.categoryCombo2.TabIndex = 5;
            // 
            // addedProducts
            // 
            this.addedProducts.FormattingEnabled = true;
            this.addedProducts.ItemHeight = 16;
            this.addedProducts.Location = new System.Drawing.Point(331, 6);
            this.addedProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addedProducts.Name = "addedProducts";
            this.addedProducts.Size = new System.Drawing.Size(159, 116);
            this.addedProducts.TabIndex = 4;
            // 
            // mealsBox
            // 
            this.mealsBox.FormattingEnabled = true;
            this.mealsBox.ItemHeight = 16;
            this.mealsBox.Location = new System.Drawing.Point(11, 242);
            this.mealsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mealsBox.Name = "mealsBox";
            this.mealsBox.Size = new System.Drawing.Size(159, 116);
            this.mealsBox.TabIndex = 3;
            this.mealsBox.SelectedIndexChanged += new System.EventHandler(this.mealsBox_SelectedIndexChanged);
            // 
            // productsBox2
            // 
            this.productsBox2.FormattingEnabled = true;
            this.productsBox2.ItemHeight = 16;
            this.productsBox2.Location = new System.Drawing.Point(11, 6);
            this.productsBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productsBox2.Name = "productsBox2";
            this.productsBox2.Size = new System.Drawing.Size(159, 116);
            this.productsBox2.TabIndex = 2;
            // 
            // dcrLabel
            // 
            this.dcrLabel.AutoSize = true;
            this.dcrLabel.Location = new System.Drawing.Point(496, 289);
            this.dcrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dcrLabel.Name = "dcrLabel";
            this.dcrLabel.Size = new System.Drawing.Size(121, 16);
            this.dcrLabel.TabIndex = 1;
            this.dcrLabel.Text = "(daily calories rate)";
            // 
            // userDataButton
            // 
            this.userDataButton.Location = new System.Drawing.Point(497, 308);
            this.userDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userDataButton.Name = "userDataButton";
            this.userDataButton.Size = new System.Drawing.Size(115, 30);
            this.userDataButton.TabIndex = 0;
            this.userDataButton.Text = "User Data";
            this.userDataButton.UseVisualStyleBackColor = true;
            this.userDataButton.Click += new System.EventHandler(this.userDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Daily Meal Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.viewAndEdit.ResumeLayout(false);
            this.viewAndEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proteinField)).EndInit();
            this.categoriesEdit.ResumeLayout(false);
            this.categoriesEdit.PerformLayout();
            this.meals.ResumeLayout(false);
            this.meals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage viewAndEdit;
        private System.Windows.Forms.TabPage categoriesEdit;
        private System.Windows.Forms.ComboBox categoriesCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        protected internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox productsBox;
        private System.Windows.Forms.TextBox grammsField;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown caloriesField;
        private System.Windows.Forms.NumericUpDown carbsField;
        private System.Windows.Forms.NumericUpDown fatsField;
        private System.Windows.Forms.NumericUpDown proteinField;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox categoriesBox;
        private System.Windows.Forms.TextBox descriptionField;
        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.Button categoryEditButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button newCategoryButton;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.TabPage meals;
        private System.Windows.Forms.Button userDataButton;
        private System.Windows.Forms.Label dcrLabel;
        private System.Windows.Forms.ListBox mealsBox;
        private System.Windows.Forms.ListBox productsBox2;
        private System.Windows.Forms.ListBox addedProducts;
        private System.Windows.Forms.ComboBox categoryCombo2;
    }
}