using System;
using System.Collections.Generic;
using System.Text;

namespace Kusina.Data.Models
{
    public class Step
    {
        public Guid StedId { get; set; }
        public int StepOrder { get; set; }
        public string Description { get; set; }

        public Guid RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
