using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    class Recipe
    {
        public int Id;
        public string Name;
        public List<string> Ingredient { get; set; }


        public Recipe(int id, string name, List<string> ingredient)
        {
            this.Id = id;
            this.Name = name;
            this.Ingredient = ingredient;

        }
        public override string ToString()
        {
            string ingredients = "Ingredients: " + String.Join(",", this.Ingredient);
            string name = "Name: " + String.Join(",", this.Name);
            StringBuilder sb = new StringBuilder();


            sb.Append($"{this.Id},{name},{ingredients}");
            return sb.ToString();

        }
        public Recipe DeepCopy()

        {
            List<string> copyListIngredients = new List<string>();
            foreach (var element in this.Ingredient)
            {
                copyListIngredients.Add(element);
            }

            Recipe deepCopyRecipe = new Recipe(this.Id, this.Name, copyListIngredients);

            return deepCopyRecipe;
        }
        public object Shallowcopy()
        {
            return this.MemberwiseClone();
        }
    }
}
