using System;
using System.Windows.Forms;

namespace Assignment4_APU_RECIPE_BOOK
{
    /// <summary>
    /// Represents the main form for the recipe book application,
    /// allowing users to add, edit, and view recipes.
    /// </summary>
    public partial class FormMain: Form
    {
        const int MaxNumOfElements = 200;
        const int MaxNumOfIngredients = 50; 

        
        // Instantiate RecipeManager and a temporary Recipe object for adding new recipes
        private RecipeManager recipeManager = new RecipeManager(MaxNumOfElements);
        private Recipe currentRecipe = new Recipe(MaxNumOfIngredients);


        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            cmbFoodCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
            lstRecipes.MouseDoubleClick += new MouseEventHandler(lstRecipes_MouseDoubleClick);
        }

        /// <summary>
        /// Handles the Add Recipe button click event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            // Check if Ingredients are added to the current recipe, if not, add them by instructing the user to do so
            if (currentRecipe.CurrentNumberOfIngredients() == 0)
            {
                MessageBox.Show("Please add ingredients to the recipe.");
                return;
            }

            // Create a new Recipe object with the name and category from the form
            currentRecipe.Name = txtNameRecipe.Text;
            currentRecipe.Category = (FoodCategory)cmbFoodCategory.SelectedItem;
            currentRecipe.Description = txtDescription.Text;


            bool addedSuccessfully = recipeManager.Add(currentRecipe);

            if (addedSuccessfully)
            {
                // Update the list of recipes on the form
                UpdateGUI();
                currentRecipe = new Recipe(MaxNumOfIngredients);
                
            }
            else
            {
                MessageBox.Show("Failed to add recipe. The recipe book may be full.");
            }
        }

        /// <summary>
        /// Handles the Add Ingredients button click event.
        /// Opens the FormIngredients form to add ingredients to the current recipe.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            //Check if a Name and Category have been entered
            if (string.IsNullOrWhiteSpace(txtNameRecipe.Text) || cmbFoodCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a name and select a category for the recipe.");
                return;
            }

            // Open the FormIngredients form to add ingredients to the current recipe
            FormIngredients formIngredients = new FormIngredients(currentRecipe);

            // set the form's title to the name of the recipe + add ingredients
            formIngredients.Text = txtNameRecipe.Text + " + add ingredients";

            formIngredients.ShowDialog();

            UpdateGUI();


        }


        /// <summary>
        /// Handles the Edit-Begin button click event. Allows editing of the selected recipe.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void btnEditBegin_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem != null)
            {
                // Retrieve the recipe from the recipeManager
                int index = lstRecipes.SelectedIndex;
                currentRecipe = recipeManager.GetRecipeAt(index);

                // Fill the form with the recipe details for editing
                txtNameRecipe.Text = currentRecipe.Name;
                cmbFoodCategory.SelectedItem = currentRecipe.Category;
                txtDescription.Text = currentRecipe.Description;
            }
        }

        /// <summary>
        /// Handles the Edit-Finish button click event. Saves the edited recipe details.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        private void btnEditFinish_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem != null)
            {
                int index = lstRecipes.SelectedIndex;

                currentRecipe.Name = txtNameRecipe.Text;
                currentRecipe.Category = (FoodCategory)cmbFoodCategory.SelectedItem;
                currentRecipe.Description = txtDescription.Text;

                recipeManager.ChangeElement(index, currentRecipe);

                UpdateGUI();
            }
        }

        /// <summary>
        /// Handles the Delete button click event. Deletes the selected recipe from the recipe book.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedItem != null)
            {
                int index = lstRecipes.SelectedIndex;
                recipeManager.DeleteElement(index);
                UpdateGUI();
            }
        }

        /// <summary>
        /// clears the form of all input and selections by calling the ClearForm method.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }


        /// <summary>
        /// Updates the list of recipes on the form.
        /// This method should be called whenever the list of recipes is updated.
        /// </summary>
        private void UpdateGUI()
        {
            lstRecipes.Items.Clear();
            foreach (string recipeSummary in recipeManager.RecipeListToString())
            {
                lstRecipes.Items.Add(recipeSummary);
            }
        }

        /// <summary>
        /// shows the details of the selected recipe in a message box.
        /// when the user double-clicks on a recipe in the list.
        /// </summary>
        private void lstRecipes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ViewSelectedRecipeDetails();
        }

        /// <summary>
        /// Displays the details of the selected recipe in a message box.
        /// </summary>
        private void ViewSelectedRecipeDetails()
        {
            // Assuming lstRecipes is your ListBox control where the recipes are listed.
            int selectedIndex = lstRecipes.SelectedIndex;
            if (selectedIndex != -1)
            {
                // Get the selected recipe based on the index.
                Recipe selectedRecipe = recipeManager.GetRecipeAt(selectedIndex);

                // Assuming Ingredients is a string array and Description is a string property.
                string ingredients = selectedRecipe.GetIngredientsString();
                string description = selectedRecipe.Description;

                // Display ingredients and description.
                
                MessageBox.Show($"INGREDIENTS:\n {ingredients}\n\n {description}", "Cooking Instructions", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please select a recipe to view its details.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Clears the form of all input and selections.
        /// </summary>
        private void ClearForm()
        {
            txtNameRecipe.Clear();
            txtDescription.Clear();
            cmbFoodCategory.SelectedIndex = -1;
            lstRecipes.ClearSelected();
        }

    }
}
