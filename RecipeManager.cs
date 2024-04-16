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
   public class RecipeManager
     {
         private Recipe[] recipeList;

         /// <summary>
         /// Creates a new instance of the RecipeManager class with a predefined number of Recipe objects.
         /// </summary>
         /// <param name="maxNumOfElements"></param>
         public RecipeManager(int maxNumOfElements)
         {
             recipeList = new Recipe[maxNumOfElements];
         }

         /// <summary>
         /// Adds a new Recipe object to the recipeList if there is space.
         /// </summary>
         /// <param name="recipe"></param>
         /// <returns>True if the recipe was successfully added; otherwise, false.</returns>
         public bool Add(Recipe recipe)
         {
             int index = FindVacantPosition();
             if (index == -1) return false;

             recipeList[index] = recipe;
             return true;
         }

        /// <summary>
        /// Adds a new Recipe object to the recipeList if there is space.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="ingredients"></param>
        /// <returns>True if the recipe was successfully added; otherwise, false.</returns>
         public bool Add(string name, FoodCategory category, string[] ingredients)
         {
             int index = FindVacantPosition();
             if (index == -1) return false;

             Recipe recipe = new Recipe(GetCurrentNumberOfRecipes());
             recipe.Name = name;
             recipe.Category = category;

             foreach (string ingredient in ingredients)
             {
                 if (!recipe.AddIngredient(ingredient))
                 {
                    break;
                 }
             }

             recipeList[index] = recipe;
             return true;
         }

        /// <summary>
        /// Changes the Recipe object at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="recipe"></param>
         public void ChangeElement(int index, Recipe recipe)
         {
             if (CheckIndex(index))
             {
                 recipeList[index] = recipe;
             }
         }

        /// <summary>
        /// Checks if the specified index is within the bounds of the recipeList.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>True if the index is valid; otherwise, false.</returns>
         public bool CheckIndex(int index)
         {
             return index >= 0 && index < recipeList.Length;
         }

        /// <summary>
        /// Deletes the Recipe object at the specified index.
        /// </summary>
        /// <param name="index"></param>
         public void DeleteElement(int index)
         {
             if (CheckIndex(index))
             {
                 recipeList[index] = null;
                 MoveElementsOneStepToLeft(index);
             }
         }

        /// <summary>
        /// Finds the first vacant position in the recipeList.
        /// </summary>
        /// <returns>The index of the first vacant position or -1 if there is no vacant position.</returns>
         public int FindVacantPosition()
         {
             for (int i = 0; i < recipeList.Length; i++)
             {
                 if (recipeList[i] == null)
                 {
                     return i;
                 }
             }
             return -1;
         }

         /// <summary>
         /// Gets the current number of Recipe objects in the recipeList.
         /// </summary>
         /// <returns>The number of Recipe objects in the recipeList.</returns>
         public int GetCurrentNumberOfRecipes()
         {
             int count = 0;
             foreach (var recipe in recipeList)
             {
                 if (recipe != null) count++;
             }
             return count;
         }

          /// <summary>
          /// Gets the Recipe object at the specified index.
          /// </summary>
          /// <param name="index"></param>
          /// <returns>The Recipe object at the specified index or null if the index is invalid.</returns>
         public Recipe GetRecipeAt(int index)
         {
             if (CheckIndex(index))
             {
                 return recipeList[index];
             }
             return null;
         }

        /// <summary>
        /// Moves all elements in the recipeList one step to the left starting from the specified index.
        /// </summary>
        /// <param name="index"></param>
         private void MoveElementsOneStepToLeft(int index)
         {
             for (int i = index; i < recipeList.Length - 1; i++)
             {
                 recipeList[i] = recipeList[i + 1];
             }
             // Set the last element to null after moving elements to the left.
             if (recipeList.Length > 0)
             {
                 recipeList[recipeList.Length - 1] = null;
             }
         }

        /// <summary>
        /// Converts the Recipe objects in the recipeList to an array of strings.
        /// </summary>
        /// <returns></returns>

         public string[] RecipeListToString()
         {
             string[] recipeStrings = new string[GetCurrentNumberOfRecipes()];
             int counter = 0;
             foreach (var recipe in recipeList)
             {
                 if (recipe != null)
                 {
                     recipeStrings[counter++] = recipe.ToString();
                 }
             }
             return recipeStrings;
         }
     }

}
