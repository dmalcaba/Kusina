using System;
using System.Collections.Generic;
using System.Text;

namespace Kusina.Data.Models
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
