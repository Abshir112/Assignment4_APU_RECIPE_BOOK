using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_APU_RECIPE_BOOK
{

    /// <summary>
    /// Represents a recipe with a name, category, description, and ingredients.
    /// </summary>
    public class Recipe
    {

        private FoodCategory category;
        private string description;
        private string[] ingredients;
        private string name;

        /// <summary>
        /// Initializes a new instance of the Recipe class with a predefined number of ingredients.
        /// </summary>
        /// <param name="maxNumOfIngredients">The maximum number of ingredients that the recipe can have.</param>
        public Recipe(int maxNumOfIngredients)
        {
            this.ingredients = new string[maxNumOfIngredients];

        }


        /// <summary>
        /// Adds an ingredient to the recipe.
        /// </summary>
        /// <param name="input">The ingredient to add to the recipe.</param>
        /// <returns>True if the ingredient was added successfully; otherwise, false.</returns>
        public bool AddIngredient(string input)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (string.IsNullOrEmpty(ingredients[i]))
                {
                    ingredients[i] = input;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Gets or sets the name of the recipe.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the name is null or whitespace.</exception>
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be null or whitespace.");
                name = value;
            }
        }

        /// <summary>
        /// Gets or sets the category of the recipe.
        /// </summary>
        public FoodCategory Category
        {
            get { return category; }
            set { category = value; }
        }

        /// <summary>
        /// Gets or sets the description of the recipe.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; } 
        }


        /// <summary>
        /// Changes the ingredient at the specified index.
        /// </summary>
        /// <param name="index">The index at which to change the ingredient.</param>
        /// <param name="value">The new ingredient value.</param>
        /// <returns>True if the ingredient was changed successfully; otherwise, false.</returns>
        public bool ChangeIngredientAt(int index, string value)
        {
            if (CheckIndex(index))
            {
                ingredients[index] = value;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if the specified index is within the bounds of the ingredients array.
        /// </summary>
        /// <param name="index">The index to check.</param>
        /// <returns>True if the index is within bounds; otherwise, false.</returns>
        public bool CheckIndex(int index)
        {
            return index >= 0 && index < ingredients.Length;
        }

        /// <summary>
        /// Gets the current number of non-null ingredients in the recipe.
        /// </summary>
        /// <returns>The number of non-null ingredients.</returns>
        public int CurrentNumberOfIngredients()
        {
            int count = 0;
            foreach (var ingredient in ingredients)
            {
                if (!string.IsNullOrEmpty(ingredient)) count++;
            }
            return count;
        }

        /// <summary>
        /// Gets the array of ingredients.
        /// </summary>
        /// <returns>The ingredients array.</returns>
        public String[] GetIngredients()
        {
            return ingredients;
        }
        
        /// <summary>
        /// Sets all ingredients to null.
        /// </summary>
        public void DefaultValues()
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                ingredients[i] = null;
            }
        }

        /// <summary>
        /// Deletes the ingredient at the specified index.
        /// </summary>
        /// <param name="index"></param>
        public void DeleteIngredientAt(int index)
        {
            if (CheckIndex(index))
            {
                ingredients[index] = null;
            }
        }

        /// <summary>
        /// finds the first vacant position in the ingredients array.
        /// </summary>        
        public int FindVacantPosition()
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (string.IsNullOrEmpty(ingredients[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Gets the ingredient at the specified index.
        /// </summary>
        /// <param name="index">The index of the ingredient to get.</param>
        /// <returns>The ingredient at the specified index or null if out of bounds.</returns>
        public string GetIngredientAt(int index)
            {
            if (CheckIndex(index))
                {
                return ingredients[index];
            }
            return null;
        }

        /// <summary>
        /// Gets a string representation of all ingredients, separated by commas.
        /// </summary>
        /// <returns>A comma-separated string of ingredients.</returns>
        public string GetIngredientsString()
        {
            return string.Join(", ", ingredients.Where(ingredient => !string.IsNullOrEmpty(ingredient)));
        }

        /// <summary>
        /// Returns a string representation of the Recipe with formatted columns.
        /// </summary>
        /// <returns>A string that represents the current Recipe object.</returns>
        public override string ToString()
        {
            
            int namePad = 20;
            int categoryPad = 35;
            int ingredientCountPad = 36; 

            string nameColumn = Name.PadRight(namePad);
            string categoryColumn = Category.ToString().PadLeft(categoryPad);
            string ingredientCountColumn = CurrentNumberOfIngredients().ToString().PadLeft(ingredientCountPad);

            return $"{nameColumn}{categoryColumn}{ingredientCountColumn}";
        }

        /// <summary>
        /// Resets all ingredients in the recipe to null.
        /// </summary>
        public void ClearIngredients()
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                ingredients[i] = null;
            }
        }
    }

}
