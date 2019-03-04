using System;
using System.Collections.Generic;
using System.Text;

namespace Kusina.Data.Models
{
    public class Ingredient
    {
        public Guid IngredientId { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Guid RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
