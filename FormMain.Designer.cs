namespace Assignment4_APU_RECIPE_BOOK
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.cmbFoodCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtNameRecipe = new System.Windows.Forms.TextBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategoryDisplay = new System.Windows.Forms.Label();
            this.lblNo_of = new System.Windows.Forms.Label();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddRecipe);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.btnAddIngredients);
            this.groupBox1.Controls.Add(this.cmbFoodCategory);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.txtNameRecipe);
            this.groupBox1.Controls.Add(this.lblRecipeName);
            this.groupBox1.Location = new System.Drawing.Point(31, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new recipe";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddRecipe.Location = new System.Drawing.Point(6, 387);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(387, 36);
            this.btnAddRecipe.TabIndex = 1;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = false;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 125);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(387, 245);
            this.txtDescription.TabIndex = 1;
            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddIngredients.Location = new System.Drawing.Point(242, 73);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(151, 38);
            this.btnAddIngredients.TabIndex = 2;
            this.btnAddIngredients.Text = "Add Ingredients";
            this.btnAddIngredients.UseVisualStyleBackColor = false;
            this.btnAddIngredients.Click += new System.EventHandler(this.btnAddIngredients_Click);
            // 
            // cmbFoodCategory
            // 
            this.cmbFoodCategory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbFoodCategory.FormattingEnabled = true;
            this.cmbFoodCategory.Location = new System.Drawing.Point(85, 79);
            this.cmbFoodCategory.Name = "cmbFoodCategory";
            this.cmbFoodCategory.Size = new System.Drawing.Size(151, 28);
            this.cmbFoodCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 82);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 20);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // txtNameRecipe
            // 
            this.txtNameRecipe.Location = new System.Drawing.Point(163, 32);
            this.txtNameRecipe.Name = "txtNameRecipe";
            this.txtNameRecipe.Size = new System.Drawing.Size(230, 26);
            this.txtNameRecipe.TabIndex = 1;
        
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Location = new System.Drawing.Point(6, 35);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(116, 20);
            this.lblRecipeName.TabIndex = 1;
            this.lblRecipeName.Text = "Name of recipe";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(507, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblCategoryDisplay
            // 
            this.lblCategoryDisplay.AutoSize = true;
            this.lblCategoryDisplay.Location = new System.Drawing.Point(710, 30);
            this.lblCategoryDisplay.Name = "lblCategoryDisplay";
            this.lblCategoryDisplay.Size = new System.Drawing.Size(73, 20);
            this.lblCategoryDisplay.TabIndex = 3;
            this.lblCategoryDisplay.Text = "Category";
            // 
            // lblNo_of
            // 
            this.lblNo_of.AutoSize = true;
            this.lblNo_of.Location = new System.Drawing.Point(916, 30);
            this.lblNo_of.Name = "lblNo_of";
            this.lblNo_of.Size = new System.Drawing.Size(51, 20);
            this.lblNo_of.TabIndex = 4;
            this.lblNo_of.Text = "No. of";
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(916, 50);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(87, 20);
            this.lblIngredient.TabIndex = 5;
            this.lblIngredient.Text = "ingredients";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Location = new System.Drawing.Point(458, 393);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 41);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit-Begin";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEditBegin_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFinish.Location = new System.Drawing.Point(600, 393);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(136, 41);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Edit-Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnEditFinish_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(758, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 41);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Location = new System.Drawing.Point(903, 393);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 41);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Selection";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblInfo.Location = new System.Drawing.Point(525, 452);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(408, 20);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = "Double click an item for ingredients_cooking instructions!";
            // 
            // lstRecipes
            // 
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.ItemHeight = 20;
            this.lstRecipes.Location = new System.Drawing.Point(467, 80);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(536, 304);
            this.lstRecipes.TabIndex = 12;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 505);
            this.Controls.Add(this.lstRecipes);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblIngredient);
            this.Controls.Add(this.lblNo_of);
            this.Controls.Add(this.lblCategoryDisplay);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Apu Recipe Book By Abshir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.Button btnAddIngredients;
        private System.Windows.Forms.ComboBox cmbFoodCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtNameRecipe;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategoryDisplay;
        private System.Windows.Forms.Label lblNo_of;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox lstRecipes;
    }
}

