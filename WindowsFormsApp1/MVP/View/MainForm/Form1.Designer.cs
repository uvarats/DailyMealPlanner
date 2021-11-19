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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.increaseButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.caloriesSum = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.deleteFromMealButton = new System.Windows.Forms.Button();
            this.addToMealButton = new System.Windows.Forms.Button();
            this.mealDeleteButton = new System.Windows.Forms.Button();
            this.mealAddButton = new System.Windows.Forms.Button();
            this.mealNameBox = new System.Windows.Forms.TextBox();
            this.mealCaloriesField = new System.Windows.Forms.TextBox();
            this.mealGrammsField = new System.Windows.Forms.TextBox();
            this.mealProductNameField = new System.Windows.Forms.TextBox();
            this.categoryCombo2 = new System.Windows.Forms.ComboBox();
            this.addedProducts = new System.Windows.Forms.ListBox();
            this.mealsBox = new System.Windows.Forms.ListBox();
            this.productsBox2 = new System.Windows.Forms.ListBox();
            this.dcrLabel = new System.Windows.Forms.Label();
            this.userDataButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveMealsButton = new System.Windows.Forms.Button();
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
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.viewAndEdit);
            this.tabControl1.Controls.Add(this.categoriesEdit);
            this.tabControl1.Controls.Add(this.meals);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 449);
            this.tabControl1.TabIndex = 1;
            // 
            // viewAndEdit
            // 
            this.viewAndEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewAndEdit.BackgroundImage")));
            this.viewAndEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.button3.Margin = new System.Windows.Forms.Padding(4);
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
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(313, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Calories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(313, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Carbs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(313, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(313, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Protein";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(313, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gramms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(313, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
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
            this.button2.Margin = new System.Windows.Forms.Padding(4);
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
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
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
            this.categoriesCombo.Margin = new System.Windows.Forms.Padding(4);
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
            this.newCategoryButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.deleteCategoryButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.meals.Controls.Add(this.saveMealsButton);
            this.meals.Controls.Add(this.increaseButton);
            this.meals.Controls.Add(this.label18);
            this.meals.Controls.Add(this.label17);
            this.meals.Controls.Add(this.label16);
            this.meals.Controls.Add(this.label15);
            this.meals.Controls.Add(this.caloriesSum);
            this.meals.Controls.Add(this.label14);
            this.meals.Controls.Add(this.label13);
            this.meals.Controls.Add(this.label12);
            this.meals.Controls.Add(this.label11);
            this.meals.Controls.Add(this.deleteFromMealButton);
            this.meals.Controls.Add(this.addToMealButton);
            this.meals.Controls.Add(this.mealDeleteButton);
            this.meals.Controls.Add(this.mealAddButton);
            this.meals.Controls.Add(this.mealNameBox);
            this.meals.Controls.Add(this.mealCaloriesField);
            this.meals.Controls.Add(this.mealGrammsField);
            this.meals.Controls.Add(this.mealProductNameField);
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
            // increaseButton
            // 
            this.increaseButton.Location = new System.Drawing.Point(490, 111);
            this.increaseButton.Name = "increaseButton";
            this.increaseButton.Size = new System.Drawing.Size(103, 31);
            this.increaseButton.TabIndex = 26;
            this.increaseButton.Text = "+100 gramms";
            this.increaseButton.UseVisualStyleBackColor = true;
            this.increaseButton.Click += new System.EventHandler(this.increaseButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1, 6);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 25;
            this.label18.Text = "Product list";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(448, 84);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 16);
            this.label17.TabIndex = 24;
            this.label17.Text = "Calories";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(448, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 16);
            this.label16.TabIndex = 23;
            this.label16.Text = "Gramms";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(448, 26);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Name";
            // 
            // caloriesSum
            // 
            this.caloriesSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caloriesSum.AutoSize = true;
            this.caloriesSum.Location = new System.Drawing.Point(488, 369);
            this.caloriesSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caloriesSum.Name = "caloriesSum";
            this.caloriesSum.Size = new System.Drawing.Size(105, 16);
            this.caloriesSum.TabIndex = 21;
            this.caloriesSum.Text = "(sum of calories)";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(333, 369);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Added meals calories:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(168, 340);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(297, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Required daily calories rate, based on your data:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(277, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Meal Products";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Meals List";
            // 
            // deleteFromMealButton
            // 
            this.deleteFromMealButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteFromMealButton.Location = new System.Drawing.Point(281, 149);
            this.deleteFromMealButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteFromMealButton.Name = "deleteFromMealButton";
            this.deleteFromMealButton.Size = new System.Drawing.Size(77, 28);
            this.deleteFromMealButton.TabIndex = 16;
            this.deleteFromMealButton.Text = "Delete";
            this.deleteFromMealButton.UseVisualStyleBackColor = true;
            this.deleteFromMealButton.Click += new System.EventHandler(this.deleteFromMealButton_Click);
            // 
            // addToMealButton
            // 
            this.addToMealButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addToMealButton.Location = new System.Drawing.Point(172, 84);
            this.addToMealButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToMealButton.Name = "addToMealButton";
            this.addToMealButton.Size = new System.Drawing.Size(96, 28);
            this.addToMealButton.TabIndex = 15;
            this.addToMealButton.Text = "Add to meal";
            this.addToMealButton.UseVisualStyleBackColor = true;
            this.addToMealButton.Click += new System.EventHandler(this.addToMealButton_Click);
            // 
            // mealDeleteButton
            // 
            this.mealDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealDeleteButton.Location = new System.Drawing.Point(4, 294);
            this.mealDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mealDeleteButton.Name = "mealDeleteButton";
            this.mealDeleteButton.Size = new System.Drawing.Size(96, 27);
            this.mealDeleteButton.TabIndex = 14;
            this.mealDeleteButton.Text = "Delete meal";
            this.mealDeleteButton.UseVisualStyleBackColor = true;
            this.mealDeleteButton.Click += new System.EventHandler(this.mealDeleteButton_Click);
            // 
            // mealAddButton
            // 
            this.mealAddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealAddButton.Location = new System.Drawing.Point(171, 208);
            this.mealAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mealAddButton.Name = "mealAddButton";
            this.mealAddButton.Size = new System.Drawing.Size(88, 27);
            this.mealAddButton.TabIndex = 13;
            this.mealAddButton.Text = "New meal";
            this.mealAddButton.UseVisualStyleBackColor = true;
            this.mealAddButton.Click += new System.EventHandler(this.mealAddButton_Click);
            // 
            // mealNameBox
            // 
            this.mealNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealNameBox.Location = new System.Drawing.Point(171, 176);
            this.mealNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mealNameBox.Name = "mealNameBox";
            this.mealNameBox.Size = new System.Drawing.Size(100, 22);
            this.mealNameBox.TabIndex = 12;
            // 
            // mealCaloriesField
            // 
            this.mealCaloriesField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealCaloriesField.Location = new System.Drawing.Point(510, 81);
            this.mealCaloriesField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mealCaloriesField.Name = "mealCaloriesField";
            this.mealCaloriesField.ReadOnly = true;
            this.mealCaloriesField.Size = new System.Drawing.Size(100, 22);
            this.mealCaloriesField.TabIndex = 11;
            // 
            // mealGrammsField
            // 
            this.mealGrammsField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealGrammsField.Location = new System.Drawing.Point(510, 51);
            this.mealGrammsField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mealGrammsField.Name = "mealGrammsField";
            this.mealGrammsField.ReadOnly = true;
            this.mealGrammsField.Size = new System.Drawing.Size(100, 22);
            this.mealGrammsField.TabIndex = 7;
            // 
            // mealProductNameField
            // 
            this.mealProductNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealProductNameField.Location = new System.Drawing.Point(510, 23);
            this.mealProductNameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mealProductNameField.Name = "mealProductNameField";
            this.mealProductNameField.ReadOnly = true;
            this.mealProductNameField.Size = new System.Drawing.Size(100, 22);
            this.mealProductNameField.TabIndex = 6;
            // 
            // categoryCombo2
            // 
            this.categoryCombo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCombo2.FormattingEnabled = true;
            this.categoryCombo2.Location = new System.Drawing.Point(172, 26);
            this.categoryCombo2.Margin = new System.Windows.Forms.Padding(4);
            this.categoryCombo2.Name = "categoryCombo2";
            this.categoryCombo2.Size = new System.Drawing.Size(105, 24);
            this.categoryCombo2.TabIndex = 5;
            // 
            // addedProducts
            // 
            this.addedProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addedProducts.FormattingEnabled = true;
            this.addedProducts.ItemHeight = 16;
            this.addedProducts.Location = new System.Drawing.Point(281, 26);
            this.addedProducts.Margin = new System.Windows.Forms.Padding(4);
            this.addedProducts.Name = "addedProducts";
            this.addedProducts.Size = new System.Drawing.Size(159, 116);
            this.addedProducts.TabIndex = 4;
            this.addedProducts.SelectedIndexChanged += new System.EventHandler(this.addedProducts_SelectedIndexChanged);
            // 
            // mealsBox
            // 
            this.mealsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mealsBox.FormattingEnabled = true;
            this.mealsBox.ItemHeight = 16;
            this.mealsBox.Location = new System.Drawing.Point(4, 171);
            this.mealsBox.Margin = new System.Windows.Forms.Padding(4);
            this.mealsBox.Name = "mealsBox";
            this.mealsBox.Size = new System.Drawing.Size(159, 116);
            this.mealsBox.TabIndex = 3;
            this.mealsBox.SelectedIndexChanged += new System.EventHandler(this.mealsBox_SelectedIndexChanged);
            // 
            // productsBox2
            // 
            this.productsBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productsBox2.FormattingEnabled = true;
            this.productsBox2.ItemHeight = 16;
            this.productsBox2.Location = new System.Drawing.Point(4, 26);
            this.productsBox2.Margin = new System.Windows.Forms.Padding(4);
            this.productsBox2.Name = "productsBox2";
            this.productsBox2.Size = new System.Drawing.Size(159, 116);
            this.productsBox2.TabIndex = 2;
            // 
            // dcrLabel
            // 
            this.dcrLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dcrLabel.AutoSize = true;
            this.dcrLabel.Location = new System.Drawing.Point(487, 340);
            this.dcrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dcrLabel.Name = "dcrLabel";
            this.dcrLabel.Size = new System.Drawing.Size(121, 16);
            this.dcrLabel.TabIndex = 1;
            this.dcrLabel.Text = "(daily calories rate)";
            // 
            // userDataButton
            // 
            this.userDataButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userDataButton.Location = new System.Drawing.Point(409, 277);
            this.userDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userDataButton.Name = "userDataButton";
            this.userDataButton.Size = new System.Drawing.Size(115, 30);
            this.userDataButton.TabIndex = 0;
            this.userDataButton.Text = "User Data";
            this.userDataButton.UseVisualStyleBackColor = true;
            this.userDataButton.Click += new System.EventHandler(this.userDataButton_Click);
            // 
            // saveMealsButton
            // 
            this.saveMealsButton.Location = new System.Drawing.Point(21, 361);
            this.saveMealsButton.Name = "saveMealsButton";
            this.saveMealsButton.Size = new System.Drawing.Size(105, 29);
            this.saveMealsButton.TabIndex = 27;
            this.saveMealsButton.Text = "Save meals";
            this.saveMealsButton.UseVisualStyleBackColor = true;
            this.saveMealsButton.Click += new System.EventHandler(this.saveMealsButton_Click);
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
        private System.Windows.Forms.TextBox mealCaloriesField;
        private System.Windows.Forms.TextBox mealGrammsField;
        private System.Windows.Forms.TextBox mealProductNameField;
        private System.Windows.Forms.Button mealDeleteButton;
        private System.Windows.Forms.Button mealAddButton;
        private System.Windows.Forms.TextBox mealNameBox;
        private System.Windows.Forms.Button addToMealButton;
        private System.Windows.Forms.Button deleteFromMealButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label caloriesSum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button increaseButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveMealsButton;
    }
}