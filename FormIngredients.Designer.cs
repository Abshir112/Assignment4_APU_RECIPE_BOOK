namespace Assignment4_APU_RECIPE_BOOK
{
    partial class FormIngredients
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxIngredients = new System.Windows.Forms.GroupBox();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.btnEditIngredient = new System.Windows.Forms.Button();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.lblNumIngredients = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelIngredient = new System.Windows.Forms.Button();
            this.grpBoxIngredients.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of ingredients";
            // 
            // grpBoxIngredients
            // 
            this.grpBoxIngredients.Controls.Add(this.lstIngredients);
            this.grpBoxIngredients.Controls.Add(this.txtIngredient);
            this.grpBoxIngredients.Controls.Add(this.btnDeleteIngredient);
            this.grpBoxIngredients.Controls.Add(this.btnEditIngredient);
            this.grpBoxIngredients.Controls.Add(this.btnAddIngredient);
            this.grpBoxIngredients.Location = new System.Drawing.Point(37, 82);
            this.grpBoxIngredients.Name = "grpBoxIngredients";
            this.grpBoxIngredients.Size = new System.Drawing.Size(610, 415);
            this.grpBoxIngredients.TabIndex = 1;
            this.grpBoxIngredients.TabStop = false;
            this.grpBoxIngredients.Text = "Ingredients";
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 20;
            this.lstIngredients.Location = new System.Drawing.Point(6, 94);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(485, 304);
            this.lstIngredients.TabIndex = 6;
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(6, 47);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(485, 26);
            this.txtIngredient.TabIndex = 5;
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteIngredient.Location = new System.Drawing.Point(509, 123);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(90, 32);
            this.btnDeleteIngredient.TabIndex = 3;
            this.btnDeleteIngredient.Text = "Delete";
            this.btnDeleteIngredient.UseVisualStyleBackColor = false;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.btnDeleteIngredient_Click);
            // 
            // btnEditIngredient
            // 
            this.btnEditIngredient.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditIngredient.Location = new System.Drawing.Point(509, 85);
            this.btnEditIngredient.Name = "btnEditIngredient";
            this.btnEditIngredient.Size = new System.Drawing.Size(90, 32);
            this.btnEditIngredient.TabIndex = 2;
            this.btnEditIngredient.Text = "Edit";
            this.btnEditIngredient.UseVisualStyleBackColor = false;
            this.btnEditIngredient.Click += new System.EventHandler(this.btnEditIngredient_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddIngredient.Location = new System.Drawing.Point(509, 47);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(90, 32);
            this.btnAddIngredient.TabIndex = 1;
            this.btnAddIngredient.Text = "Add";
            this.btnAddIngredient.UseVisualStyleBackColor = false;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // lblNumIngredients
            // 
            this.lblNumIngredients.AutoSize = true;
            this.lblNumIngredients.Location = new System.Drawing.Point(629, 46);
            this.lblNumIngredients.Name = "lblNumIngredients";
            this.lblNumIngredients.Size = new System.Drawing.Size(0, 20);
            this.lblNumIngredients.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOk.Location = new System.Drawing.Point(152, 512);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(122, 32);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOkF_Ingredient_Click);
            // 
            // btnCancelIngredient
            // 
            this.btnCancelIngredient.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelIngredient.Location = new System.Drawing.Point(305, 512);
            this.btnCancelIngredient.Name = "btnCancelIngredient";
            this.btnCancelIngredient.Size = new System.Drawing.Size(124, 32);
            this.btnCancelIngredient.TabIndex = 6;
            this.btnCancelIngredient.Text = "Cancel";
            this.btnCancelIngredient.UseVisualStyleBackColor = false;
            this.btnCancelIngredient.Click += new System.EventHandler(this.btnCancelIngredient_Click);
            // 
            // FormIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 580);
            this.Controls.Add(this.btnCancelIngredient);
            this.Controls.Add(this.lblNumIngredients);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpBoxIngredients);
            this.Controls.Add(this.label1);
            this.Name = "FormIngredients";
            this.Text = "name of the recipe + add ingredients";
            this.grpBoxIngredients.ResumeLayout(false);
            this.grpBoxIngredients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxIngredients;
        private System.Windows.Forms.Label lblNumIngredients;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Button btnEditIngredient;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelIngredient;
        private System.Windows.Forms.ListBox lstIngredients;
    }
}