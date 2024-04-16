using System;
using System.Windows.Forms;

namespace Assignment4_APU_RECIPE_BOOK
{
    /// <summary>
    /// Represents the form for adding ingredients to a recipe.
    /// </summary>
    public partial class FormIngredients : Form
    {

        // The recipe with the ingredients
        private Recipe currentRecipe;

        /// <summary>
        /// Form constructor that initializes the form with a recipe.
        /// </summary>
        /// <param name="recipe"></param>
        public FormIngredients(Recipe recipe)
        {
            InitializeComponent();
            currentRecipe = recipe;
            UpdateIngredientList();
        }

        /// <summary>
        /// Gets the recipe with the ingredients.
        /// </summary>
        /// <returns>The recipe with the ingredients.</returns>
        public Recipe GetRecipe()
        {
            return currentRecipe;
        }

        /// <summary>
        /// Handles the Add Ingredient button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            string ingredient = txtIngredient.Text.Trim();

            if (!string.IsNullOrEmpty(ingredient))
            {
                if (currentRecipe.AddIngredient(ingredient))
                {
                    UpdateIngredientList();
                    txtIngredient.Clear();
                }
                else
                {
                    MessageBox.Show("Unable to add ingredient. Check if the list is full or duplicated.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an ingredient.");
            }
        }

        /// <summary>
        /// Updates the list of ingredients on the form.
        /// </summary>
        private void UpdateIngredientList()
        {
            lstIngredients.Items.Clear();
            foreach (var ingredient in currentRecipe.GetIngredients())
            {
                if (!string.IsNullOrEmpty(ingredient))
                {
                    lstIngredients.Items.Add(ingredient);
                }
            }
            lblNumIngredients.Text = currentRecipe.CurrentNumberOfIngredients().ToString();
        }

        /// <summary>
        /// Edits the selected ingredient in the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditIngredient_Click(object sender, EventArgs e)
        {
            // get the selected index
            int index = lstIngredients.SelectedIndex;
            if (index != -1)
            {
                // get the ingredient at the selected index
                string ingredient = currentRecipe.GetIngredientAt(index);
                // set the ingredient in the text box
                txtIngredient.Text = ingredient;
                // delete the ingredient from the list
                currentRecipe.DeleteIngredientAt(index);
                UpdateIngredientList();
            }
            else
            {
                MessageBox.Show("Please select an ingredient to edit.");
            }
        }

        /// <summary>
        /// Deletes the selected ingredient from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            int index = lstIngredients.SelectedIndex;
            Console.WriteLine(index);
            if (index != -1)
            {
                currentRecipe.DeleteIngredientAt(index);
                UpdateIngredientList();
            }
            else
            {
                MessageBox.Show("Please select an ingredient to delete.");
            }
        }


        /// <summary>
        /// Updates the recipe with the ingredients and closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOkF_Ingredient_Click(object sender, EventArgs e)
        {
 
            UpdateIngredientList();
            this.Close();

        }

        /// <summary>
        /// Closes the form without saving the ingredients.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelIngredient_Click(object sender, EventArgs e)
        {

            this.Close();
           
        }        
    }
}
